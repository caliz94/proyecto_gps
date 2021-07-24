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


        // Declaración de Variables Globales
        public static string nombreProducto = "", cantidad = "", precioUnitario = "", subTotal = "", descuento = "", iva = "", total = "", idProducto = "";
        public static int i = 500;
        public static int x = 0;
        public static string[] _idproducto = new string[i];
        public static string[] _cantidad = new string[i];


        // Instanciar Conexión a la Base de Datos
        private cConexion conex = new cConexion();


        // Instanciar Objeto de la Capa de Datos
        private Producto_DAL _ProductoDAL = new Producto_DAL();


        // Inicialización del Formulario y Controles
        private void frmVenta_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            dgvCompra.Columns.Add("IdProducto", "IdProducto");
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


        // Programación de los componentes
        private void txb_Cantidad_KeyUp(object sender, KeyEventArgs e)
        {
            txb_IVA.Enabled = true;
            txb_IVA.ReadOnly = false;
            txb_Descuento.Enabled = true;
            txb_Descuento.ReadOnly = false;
        }


        private void btnDescargar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txb_Cliente.Text == string.Empty)
                errorP.SetError(txb_Cliente, "Debe Ingresar el nombre del Cliente");
            else if (txb_Cantidad.Text == string.Empty)
                errorP.SetError(txb_Cliente, "Debe Ingresar la cantidad de producto");
            else if (Convert.ToInt32(txb_Cantidad.Text) >= 1)
            {
                dgvCompra.Rows.Add
                    (
                        idProducto = dgvCarrito.CurrentRow.Cells["IdProducto"].Value.ToString(),
                        //Nombre Producto
                        nombreProducto = dgvCarrito.CurrentRow.Cells["NombreProducto"].Value.ToString(),
                        //Cantidad
                         cantidad = txb_Cantidad.Text.ToString(),
                        //Precio Unitario
                        precioUnitario = dgvCarrito.CurrentRow.Cells["PrecioUnitario"].Value.ToString(),
                        //Sub-Total
                        subTotal = ((Convert.ToInt32(cantidad)) * (Convert.ToDouble(precioUnitario))).ToString(),
                        //Descuento
                        descuento = (Convert.ToDouble(subTotal) * (Convert.ToDouble(txb_Descuento.Text)/100)).ToString(),
                        //IVA
                        iva = ((Convert.ToDouble(subTotal) - Convert.ToDouble(descuento ))*(Convert.ToInt32(txb_IVA.Text))/100).ToString(),
                        //Total
                        total = ((Convert.ToDouble(subTotal) - Convert.ToDouble(descuento)) + Convert.ToDouble(iva)).ToString()
                    );

                // Se almacenan los datos en el arreglo para grabar la venta
                _idproducto[x] = idProducto;

                _cantidad[x] = Convert.ToString(cantidad);

                // Se sumarizan los subtotales y se envian los valores
                txb_Subtotal.Text = ((Convert.ToDouble(txb_Subtotal.Text)) + (Convert.ToDouble(subTotal))).ToString();

                txb_TotDescuento.Text = ((Convert.ToDouble(txb_TotDescuento.Text)) + (Convert.ToDouble(descuento))).ToString();

                txb_TotIVA.Text = ((Convert.ToDouble(txb_TotIVA.Text)) + (Convert.ToDouble(iva))).ToString();

                txb_TotCompra.Text = ((Convert.ToDouble(txb_TotCompra.Text)) + (Convert.ToDouble(total))).ToString();

                txb_Cantidad.Text = "0";
                txb_Descuento.Text = "0";
                txb_IVA.Text = "15";

                // Se incrementa la variable para capturar la cantidad de articulos
                x = x + 1;
            }
           else
            {
                // Mensaje de validación de cantidad de producto
                MessageBox.Show("Favor digite la cantidad del Producto","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }


        private void txb_Producto_KeyUp(object sender, KeyEventArgs e)
        {
            conex.AbrirConex();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE NombreProducto LIKE ('%" + txb_Producto.Text + "%')", conex.AbrirConex());
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


        private void btnPagar_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < x; fila++)
            {
                _ProductoDAL.grabarVenta(
                    Convert.ToInt32(_idproducto[fila]),
                    txb_Cliente.Text.ToString(),
                    Convert.ToInt32(_cantidad[fila]),
                    Convert.ToDecimal(subTotal),
                    Convert.ToDecimal(descuento),
                    Convert.ToDecimal(iva),
                    Convert.ToDecimal(total));
            }
            lblMensaje.Visible = true;
        }
    }
}
