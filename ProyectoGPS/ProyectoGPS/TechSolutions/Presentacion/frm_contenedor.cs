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
        cConexion conex = new cConexion();
        private void iNGRESARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_login login = new frm_login();
            //login.MdiParent = this;
            //login.Show();
            //menuStrip1.Visible = false;

        }

        private void nUEVOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmIngresarProductos produc = new frmIngresarProductos();
            produc.MdiParent = frm_contenedor.ActiveForm;
            produc.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txb_usuario.Text == string.Empty)
                errorP.SetError(txb_usuario, "Debe de Ingresar el Usuario");
            else if (txb_contraseña.Text == string.Empty)
                errorP.SetError(txb_contraseña, "Debe Ingresar la Contraseña.");
            else
            {
                login();
            }
        }
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

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_contenedor_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta FormVenta = new frmVenta();
            FormVenta.MdiParent = frm_contenedor.ActiveForm;
            FormVenta.Show();
        }

        private void eDITARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditar FormEProducto = new frmEditar();
            FormEProducto.MdiParent = frm_contenedor.ActiveForm;
            FormEProducto.Show();
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

        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar formEliminar = new frmEliminar();
            formEliminar.MdiParent = frm_contenedor.ActiveForm;
            formEliminar.Show();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lISTADODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioProducto FormProducto = new frmInventarioProducto();
            FormProducto.MdiParent = frm_contenedor.ActiveForm;
            FormProducto.Show();
        }

        private void pictNuevoUsuario_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            frmRegistro FormRegistro = new frmRegistro();
            FormRegistro.MdiParent = frm_contenedor.ActiveForm;
            FormRegistro.Show();
        }
    }
}
