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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }
        public static string nombreProducto = "", cantidad = "", precioUnitario = "", subTotal = "", descuento = "", iva = "", total = "";

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public cConexion conex = new cConexion();

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            dgvCompra.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("PrecioUnitario", "Precio por Unidad");
            dgvCompra.Columns.Add("SubTotal", "SubTotal");
            dgvCompra.Columns.Add("Descuento", "Descuento");
            dgvCompra.Columns.Add("IVA", "I.V.A.");
            dgvCompra.Columns.Add("Total", "Total");

            txb_Cantidad.Text = "0";
            txb_Subtotal.Text = "0";
            txb_TotDescuento.Text = "0";
            txb_TotIVA.Text = "0";
            txb_TotCompra.Text = "0";
        }

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txb_Cliente.Text == string.Empty)
                errorP.SetError(txb_Cliente, "Debe Ingresar el nombre del Cliente");
            else if (Convert.ToInt32(txb_Cantidad.Text) >= 1)
            {
               
                dgvCompra.Rows.Add(
           //Nombre Producto
           nombreProducto = dgvCarrito.CurrentRow.Cells["NombreProducto"].Value.ToString(),
           //Cantidad
           cantidad = txb_Cantidad.Text.ToString(),
           //Precio Unitario
           precioUnitario = dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString(),
           //Sub-Total
           subTotal = ((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))).ToString(),
           //Descuento
           descuento = (((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) * Convert.ToDouble(txb_Descuento.Text)).ToString(),
           //IVA
           iva = (((((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) - ((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) * Convert.ToDouble(txb_Descuento.Text))) * Convert.ToDouble(txb_IVA.Text)).ToString(),
           //Total
           total = ((((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) - ((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) * Convert.ToDouble(txb_Descuento.Text)) + ((((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) - ((Convert.ToDouble(txb_Cantidad.Text)) * (Convert.ToDouble(dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString()))) * Convert.ToDouble(txb_Descuento.Text))) * Convert.ToDouble(txb_IVA.Text)).ToString()
           );

                txb_Subtotal.Text = ((Convert.ToDouble(txb_Subtotal.Text)) + (Convert.ToDouble(subTotal))).ToString();

                txb_TotDescuento.Text = ((Convert.ToDouble(txb_TotDescuento.Text)) + (Convert.ToDouble(descuento))).ToString();

                txb_TotIVA.Text = ((Convert.ToDouble(txb_TotIVA.Text)) + (Convert.ToDouble(iva))).ToString();

                txb_TotCompra.Text = ((Convert.ToDouble(txb_TotCompra.Text)) + (Convert.ToDouble(total))).ToString();

                txb_Cantidad.Text = "0";
            }
           else
            {
                MessageBox.Show("Favor digite la cantidad del Producto","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conex.AbrirConex();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE NombreProducto LIKE ('%"+textBox1.Text+"%')", conex.AbrirConex());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);

            dgvCarrito.DataSource = dt;
            dgvCarrito.Columns["IdProducto"].Visible = false;
            dgvCarrito.Columns["CodProducto"].Visible = false;
            dgvCarrito.Columns["PrecioUnitario"].Visible = false;
            dgvCarrito.Columns["Cantidad"].HeaderText = "Cantidad en Existencia";
            dgvCarrito.Columns["NombreProducto"].HeaderText = "Nombre del Producto";
            conex.CerrarConex();



        }
    }
}
