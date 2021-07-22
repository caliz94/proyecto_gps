using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;

namespace Presentacion
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        public void habilitarControles()
        {
            txb_producto.Text = string.Empty;
            txb_producto.Enabled = true;
            txb_producto.ReadOnly = false;
            txb_cantidad.Text = string.Empty;
            txb_cantidad.Enabled = true;
            txb_cantidad.ReadOnly = false;
            txb_precio.Text = string.Empty;
            txb_precio.Enabled = true;
            txb_precio.ReadOnly = false;
            txb_marca.Text = string.Empty;
            txb_marca.Enabled = true;
            txb_marca.ReadOnly = false;
        }

        public cConexion conex = new cConexion();
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "select * from Producto where IdProducto like @IdProducto+'%'";

            SqlCommand cmd = new SqlCommand(sql, conex.Cadena);
            cmd.Parameters.AddWithValue("@IdProducto", textBox1.Text);

            if (textBox1.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textBox1, "no se permite campo vacio");
                textBox1.Text = "";
            }

            else
            {
                errorProvider1.SetError(textBox1, "");
                SqlDataReader leer;
                conex.AbrirConex();
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conex.CerrarConex();
                dataGridView1.DataSource = tabla;
                textBox1.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarControles();
        }
    }
}
