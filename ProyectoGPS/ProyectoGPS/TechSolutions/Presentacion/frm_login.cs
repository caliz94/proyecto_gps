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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        cConexion conex = new cConexion();

        public void formlog()
        {
            //frmMenu menu = new frmMenu();
            //menu.MdiParent = this ;
            //menu.Show();

            this.Hide();
            frmMenu menu = new frmMenu();
            menu.MdiParent = frm_contenedor.ActiveForm;
            
            menu.Show();
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
                    lbl_login.Text ="";
                    formlog();
                  
                }
                else
                {
                    lbl_login.Text = "usuario no encontrado";                   
                }
                conex.CerrarConex();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un Error");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
            txb_usuario.Clear();
            txb_contraseña.Clear();            
        }
    }
}
