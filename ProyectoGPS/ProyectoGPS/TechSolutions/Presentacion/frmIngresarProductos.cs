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


        // INSTANCIACIÓN DE LA CLASE cProducto DE LA CAPA DE LOGICA

        cProducto cprod = new cProducto();


        // IMPLEMENTACIÓN DEL PATRÓN DE SINGLETON

        private static frmIngresarProductos _Abrir;
        // PROPIEDAD SOLO GET
        public static frmIngresarProductos Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new frmIngresarProductos();
                return _Abrir;
            }
        }
        private void frmIngresarProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }


        // PROGRAMACIÓN DE LOS MÉTODOS

        public void LimpiarControles()
        {
            txb_precio.Text = string.Empty;
            txb_marca.Text = string.Empty;
            txb_producto.Text = string.Empty;
            txb_cantidad.Text = string.Empty;
            txb_CodProducto.Text = string.Empty;
        }


        // PROGRAMACIÓN DE LOS CONTROLES Y EVENTOS

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_marca.Text!=string.Empty)
                {
                    cprod.Insertar(txb_CodProducto.Text, txb_producto.Text, Convert.ToInt32(txb_cantidad.Text), Convert.ToDecimal(txb_precio.Text), txb_marca.Text);
                    MessageBox.Show("Producto Guardado Satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Obligatorios");
            }
        }


        // VALIDACIONES

        private void txb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        }

        private void txb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_CodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        }
    }
}
