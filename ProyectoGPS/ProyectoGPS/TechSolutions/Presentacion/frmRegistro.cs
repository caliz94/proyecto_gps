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


        // INSTANCIACIÓN DE LA CONEXIÓN

        public cConexion conex = new cConexion();


        // INSTANCIACIÓN DE LA CLASE Producto_DAL

        private Producto_DAL OProductoDAL = new Producto_DAL();
      

        // IMPLEMENTACIÓN DEL PATRON DE SINGLENTON

        private static frmRegistro _Abrir;
        // Propiedad solo get
        public static frmRegistro Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new frmRegistro();
                    return _Abrir;  
            }
        }
        private void frmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }


        // PROGRAMACIÓN DE LOS CONTROLES Y EVENTOS

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
            // Validaciones con expresiones regulares   
            //string todosletras = @"\b(\w*[a-zA-Z0-9]\w.)";
            string numeros = @"[0-9]";
            string mayusculas = @"[A-Z]";
            string minusculas = @"[a-z]";
            string simbolos = "[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]";

            if (txtUsuario.Text.Trim() == string.Empty)
            {
                errorP.SetError(txtUsuario, "Debe ingresar un usuario");
            }
            else if (txt_Contraseña.Text.Trim() == string.Empty)
            {
                errorP.SetError(txtUsuario, "");
                errorP.SetError(txt_Contraseña, "Debe ingresar una contraseña");
            }
            else if (txt_Contraseña.Text.Length >= 8)
            {
                errorP.SetError(cbox_Roles, "");
                //if (Regex.IsMatch(txt_Contraseña.Text, todosletras))
                //{
                    if (Regex.IsMatch(txt_Contraseña.Text, numeros))
                    {
                        if (Regex.IsMatch(txt_Contraseña.Text, mayusculas))
                        {
                            if (Regex.IsMatch(txt_Contraseña.Text, minusculas))
                            {
                                if (Regex.IsMatch(txt_Contraseña.Text, simbolos))
                                {
                                    if (cbox_Roles.SelectedIndex == -1)
                                    {
                                        errorP.SetError(txt_Contraseña, "");
                                        errorP.SetError(cbox_Roles, "Debe seleccionar un rol");
                                    }
                                    else
                                    {
                                        errorP.SetError(txt_Contraseña, "");
                                        OProductoDAL.RegistrarUsuario(txtUsuario.Text, txt_Contraseña.Text.Trim(), cbox_Roles.Text);
                                        MessageBox.Show("Usuario Registrado Satisfactoriamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtUsuario.Clear();
                                        txt_Contraseña.Clear();
                                    }
                                }
                                else
                                {
                                    errorP.SetError(txt_Contraseña, "Debe ingresar al menos un simbolo.");
                                }
                            }
                            else
                            {
                                errorP.SetError(txt_Contraseña, "Debe Ingresar letras minusculas.");
                            }
                        }
                        else
                        {
                            errorP.SetError(txt_Contraseña, "Debe ingresar letras mayusculas");
                        }
                    }
                    else
                    {
                        errorP.SetError(txt_Contraseña, "Debe ingresar al menos un numero.");
                    }
                //}
                //else
                //{
                //    errorP.SetError(txt_Contraseña, "La contraseña no cumple con los parametros necesarios.");
                //}
            }
            else
            {
                errorP.SetError(txt_Contraseña, "La contraseña debe ser mayor de 8 caracteres.");
            }             
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
