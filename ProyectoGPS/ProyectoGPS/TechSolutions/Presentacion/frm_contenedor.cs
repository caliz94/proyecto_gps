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
    public partial class frm_contenedor : Form
    {
        public frm_contenedor()
        {
            InitializeComponent();
        }

        // INSTANCIACIÓN DE LA CONEXIÓN

        cConexion conex = new cConexion();

        //public static string rol = "";


        // PROGRAMACIÓN DE LOS MÉTODOS

        public void login()
        {
            try
            {

                SqlDataReader leer;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conex.AbrirConex();
                cmd.CommandText = "Sp_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", txb_usuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", txb_contraseña.Text);
                leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    lbl_login.Text = "";
                    menuStrip1.Visible = true;
                    panel1.Visible = false;
                }
                else
                {
                    lbl_login.Visible = true;
                    lbl_login.Text = "USUARIO O CONTRASEÑA INVÁLIDOS";
                }
                conex.CerrarConex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error");
            }
        }

        
        // PROGRAMACIÓN DE LOS CONTROLES Y EVENTOS

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validación de ingreso de los textbox de usuario y contraseña
            if (txb_usuario.Text == string.Empty)
                errorP.SetError(txb_usuario, "Debe de Ingresar el Usuario");
            else if (txb_contraseña.Text == string.Empty)
            {
                errorP.SetError(txb_usuario, "");
                errorP.SetError(txb_contraseña, "Debe Ingresar la Contraseña.");
            }
            else
            {
                login();
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_contenedor_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_contraseña_TextChanged(object sender, EventArgs e)
        {
            lbl_login.Visible = false;
        }

        private void txb_usuario_TextChanged(object sender, EventArgs e)
        {
            lbl_login.Visible = false;
        }

        private void editarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditar AbrirForm = frmEditar.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void eliminarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminar AbrirForm = frmEliminar.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void listadoDeProductosDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioProducto AbrirForm = frmInventarioProducto.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void ingresarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresarProductos AbrirForm = frmIngresarProductos.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta AbrirForm = frmVenta.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            frmRegistro AbrirForm = frmRegistro.Abrir;
            AbrirForm.MdiParent = frm_contenedor.ActiveForm;
            AbrirForm.Show();
        }

        private void txb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
