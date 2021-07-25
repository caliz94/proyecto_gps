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
using System.Text.RegularExpressions;
using DATOS;

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        public cConexion conex = new cConexion();
        private Producto_DAL OProductoDAL = new Producto_DAL();
        public static string contraseña = "";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand("SpCargarComboRol", conex.AbrirConex());
            CMD.CommandType = CommandType.StoredProcedure;
            SqlDataReader producto = CMD.ExecuteReader();
            while (producto.Read())
            {
                cbox_Roles.Items.Add(producto["DescripcionRol"].ToString());
                cbox_Roles.DisplayMember = "DescripcionRol";
                cbox_Roles.Text = "Seleccione un Rol";
            }
            conex.CerrarConex();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var todosletras = @"\b(\w*[a-zA-Z0-9]\w.)";
            var numeros = @"\b(\w*[0-9]\w.)";
            var mayusculas = @"\b(\w*[A-Z]\w.)";
            var minusculas = @"\b(\w*[a-z]\w.)";
            var simbolos = @"\b(\w*[!#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]\w.)";
            if (txt_Contraseña.Text.Length >= 8)
            {
                if (Regex.IsMatch(txt_Contraseña.Text, todosletras))
                {


                    if (Regex.IsMatch(txt_Contraseña.Text, numeros))
                    {

                        if (Regex.IsMatch(txt_Contraseña.Text, mayusculas))
                        {


                            if (Regex.IsMatch(txt_Contraseña.Text, minusculas))
                            {

                                if (Regex.IsMatch(txt_Contraseña.Text, simbolos))
                                {
                                    OProductoDAL.RegistrarUsuario(txtUsuario.Text, txt_Contraseña.Text.Trim(), cbox_Roles.Text);
                                    MessageBox.Show("Usuario Registrado Satisfactoriamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //MessageBox.Show("contraseña correcta");
                                }
                                else
                                {
                                    MessageBox.Show("contraseña ingrese un simbolo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese letras minusculas");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ingrese letras mayusculas");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ingrese numeros,");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no cumple con los parametros necesarios");
                }
            }
            else
            {
                MessageBox.Show("la contraseña debe ser de 8 caracteres");
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            //var todosletras = @"\b(\w*[a-zA-Z0-9]\w.)";
            //var numeros = @"\b(\w*[0-9]\w.)";
            //var mayusculas = @"\b(\w*[A-Z]\w.)";
            //var minusculas = @"\b(\w*[a-z]\w.)";
            //if (txt_Contraseña.Text.Length >= 8)
            //{
            //    if (Regex.IsMatch(txt_Contraseña.Text, todosletras))
            //    {


            //        if (Regex.IsMatch(txt_Contraseña.Text, numeros))
            //        {
            //            MessageBox.Show("numeros");
            //        }
            //        if (Regex.IsMatch(txt_Contraseña.Text, mayusculas))
            //        {
            //            MessageBox.Show("mayus");
            //        }
            //        if (Regex.IsMatch(txt_Contraseña.Text, minusculas))
            //        {
            //            MessageBox.Show("min");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("La contraseña no cumple con los parametros necesarios");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("la contraseña debe ser de 8 caracteres");
            //}
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }
        }
    }
