using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        public static string contraseña = "";
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //for (int i = 0; i < txt_Contraseña.Text.Length; i++)
            //{
            //    if ((e.KeyChar < 65) || (e.KeyChar > 90))
            //    {
            //        errorProvider1.SetError(txt_Contraseña, "Se deben ingresar al menos una Mayúscula.");
            //    }
            //    else if ((e.KeyChar < 97) || (e.KeyChar > 122))
            //    {
            //        errorProvider1.SetError(txt_Contraseña, "Se deben ingresar al menos una Minuscula.");
            //    }
               
            //    else if ((e.KeyChar < 32) || (e.KeyChar > 126))
            //    {
            //        errorProvider1.SetError(txt_Contraseña, "Se deben ingresar letras, números, (1) mayúscula, (1) minúscula y caracteres especiales");
            //    }
            //}
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            contraseña = txt_Contraseña.Text;
            bool errorFlag = false;
            int errorCode = 0;
            //for (int i = 0; i < txt_Contraseña.Text.Length; i++)
            //{
            Match matchLongitud = Regex.Match(contraseña, @"^\w{8,15}\b");
            Match matchNumeros = Regex.Match(contraseña, @"\d");
            Match matchEspeciales = Regex.Match(contraseña, @"[ñÑ\-_¿.#¡*+]");
            Match matchMayusculas = Regex.Match(contraseña, @"[A-Z]");
            Match matchMinusculas = Regex.Match(contraseña, @"[a-z]");
            //}
            if (!matchNumeros.Success && matchLongitud.Success && matchEspeciales.Success && matchMayusculas.Success && matchMinusculas.Success)
            {
                errorCode = 1;
                errorFlag = true;
                // numeros
            }
            else if (matchNumeros.Success && !matchLongitud.Success && matchEspeciales.Success && matchMayusculas.Success && matchMinusculas.Success)
            {
                errorCode = 2;
                errorFlag = true;
                // longitud
            }
            else if (matchNumeros.Success && matchLongitud.Success && !matchEspeciales.Success && matchMayusculas.Success && matchMinusculas.Success)
            {
                errorCode = 3;
                errorFlag = true;
                // caracteres especiales
            }
            else if (matchNumeros.Success && matchLongitud.Success && matchEspeciales.Success && !matchMayusculas.Success)
            {
                errorCode = 4;
                errorFlag = true;
                // caracteres especiales
            }
            else if (matchNumeros.Success && matchLongitud.Success && matchEspeciales.Success && matchMayusculas.Success && !matchMinusculas.Success)
            {
                errorCode = 5;
                errorFlag = true;
                // caracteres especiales
            }
            switch (errorCode)
            {
                case 1:
                    errorP.SetError(txt_Contraseña, "Tu contraseña debe de contener al menos 1 número");
                    break;
                case 2:
                    errorP.SetError(txt_Contraseña, "Tu contraseña debe de contener una longitud entre 8-15 caracteres");
                    break;
                case 3:
                    errorP.SetError(txt_Contraseña, "Tu contraseña debe de contener caracteres especiales");
                    break;
                case 4:
                    errorP.SetError(txt_Contraseña, "Tu contraseña debe de contener al menos una Mayúscula");
                    break;
                case 5:
                    errorP.SetError(txt_Contraseña, "Tu contraseña debe de contener al menos una Minúscula");
                    break;
                default:
                    errorP.Clear();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var regex = @"(?!^[0-9]$)(?!^[a-zA-Z]$)^(.{8,15})$";

            if (Regex.IsMatch(txt_Contraseña.Text, regex))
            {
                MessageBox.Show("Ok");
            }
        }
    }
}
