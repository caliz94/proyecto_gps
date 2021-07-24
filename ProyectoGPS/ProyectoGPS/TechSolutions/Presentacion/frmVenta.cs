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

        public cConexion conex = new cConexion();

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            dgvCompra.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("PrecioUnitario", "Precio por Unidad");
            dgvCompra.Columns.Add("SubTotal", "SubTotal");
            dgvCompra.Columns.Add("IVA", "I.V.A.");
            dgvCompra.Columns.Add("Descuento", "Descuento");
            dgvCompra.Columns.Add("Total", "Total");


        }


        private void btnCargar_Click(object sender, EventArgs e)
        {




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
