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
using System.Data;
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

            SqlCommand CMD = new SqlCommand("SpCargarComboProducto", conex.AbrirConex());
            CMD.CommandType = CommandType.StoredProcedure;
            SqlDataReader producto = CMD.ExecuteReader();
            while (producto.Read())
            {
                cmb_Producto.Items.Add(producto["NombreProducto"].ToString());
                //cmb_Producto.Tag = cmb_Producto.Items.Add(producto["PrecioUnitario"].ToString()); 
            }
            conex.CerrarConex();

            dgvCarrito.Columns.Add("NombreProducto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("IVA", "I.V.A.");
            dgvCarrito.Columns.Add("Descuento", "Descuento");
            //dgvCarrito.Columns.Add("PrecioUnitario", "Precio Unitario");

        }
       

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            dgvCarrito.Rows.Add(
                cmb_Producto.Text,
                txb_Cantidad.Text,
                txb_IVA.Text,
                txb_Descuento.Text,
                //cmb_Producto.Tag
                //Precio()
            

                );
        }
    }
}
