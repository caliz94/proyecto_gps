using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATOS;

namespace Presentacion
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        // SINGLETON
        private static frmEliminar _Abrir;
        // PROPIEDAD SOLO GET
        public static frmEliminar Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new frmEliminar();
                return _Abrir;
            }
        }
        private void frmEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        public Producto_DAL proc = new Producto_DAL();
        public cConexion conex = new cConexion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "select * from Producto where NombreProducto like '%'+@NombreProducto+'%'";

            SqlCommand cmd = new SqlCommand(sql, conex.Cadena);
            cmd.Parameters.AddWithValue("@NombreProducto", txb_Buscar.Text);

            if (txb_Buscar.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txb_Buscar, "no se permite campo vacio");
                txb_Buscar.Text = "";
            }

            else
            {
                errorProvider1.SetError(txb_Buscar, "");
                SqlDataReader leer;
                conex.AbrirConex();
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conex.CerrarConex();
                dgvResultados.DataSource = tabla;
                dgvResultados.Columns["IdProducto"].Visible = false;
                dgvResultados.Columns["CodProducto"].Visible = false;
                txb_Buscar.Text = "";

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvResultados.CurrentRow.Cells["Cantidad"].Value.ToString()) == 0)
                {
                    if (MessageBox.Show("Favor confirmar Eliminación del Registro", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        txbIdProducto.Text = dgvResultados.CurrentRow.Cells["IdProducto"].Value.ToString();
                        proc.Eliminar(Convert.ToInt32(txbIdProducto.Text));
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = Color.Blue;
                        lblMensaje.Text = "REGISTRO ELIMINADO CORRECTAMENTE";
                    }

                }
                else
                {
                    MessageBox.Show("No se pueden eliminar Productos con existencias diferente de cero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMensaje.Visible = true;
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Operación Cancelada: El Producto posee existencias.";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione el producto a eliminar");
            }
            

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CodProducto.Text = dgvResultados.CurrentRow.Cells["CodProducto"].Value.ToString();
            txb_CodProducto.ReadOnly = true;
            txb_CodProducto.Visible = true;
            lblCodProducto.Visible = true;
            txbIdProducto.Text = dgvResultados.CurrentRow.Cells["IdProducto"].Value.ToString();
            txb_producto.Text = dgvResultados.CurrentRow.Cells["NombreProducto"].Value.ToString();
            txb_cantidad.Text = dgvResultados.CurrentRow.Cells["Cantidad"].Value.ToString();
            //habilitarControles();
        }
        
    }
}
