using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmIngresarProductos : Form
    {
        public frmIngresarProductos()
        {
            InitializeComponent();
        }

        public void LimpiarControles()
        {
            txb_precio.Text = string.Empty;
            txb_marca.Text = string.Empty;
            txb_producto.Text = string.Empty;
            txb_cantidad.Text = string.Empty;
            txb_CodProducto.Text = string.Empty;
        }

        cProducto cprod = new cProducto();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cprod.Insertar(txb_CodProducto.Text,txb_producto.Text, Convert.ToInt32(txb_cantidad.Text), Convert.ToDecimal(txb_precio.Text), txb_marca.Text);

            MessageBox.Show("Producto Guardado Satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarControles();
        }

        private void txb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            //REFERENCIA
            //var regex = @"[0-9]+[.]{1}[0-9]{2}$";

            //if (Regex.IsMatch(txb_cantidad.Text, regex))
            //{
            //    e.Handled = true;
            //}


        }
    }
}
