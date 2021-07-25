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
            var regex = @"(?!^[0-9]$)(?!^[a-zA-Z]$)^(.{8,15})$";

            if (Regex.IsMatch(txt_Contraseña.Text, regex))
            {
                OProductoDAL.RegistrarUsuario(txtUsuario.Text, txt_Contraseña.Text, cbox_Roles.Text);
                MessageBox.Show("Usuario Registrado Satisfactoriamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorP.SetError(txt_Contraseña, "Debe contener letras mayusculas, minusculas, numeros, simbolos y longitud mayor de 7 caracteres");
            }

            //var regex = @"(?!^[0-9]$)(?!^[a-zA-Z]$)^(.{8,15})$";

            //if (Regex.IsMatch(textBox1.Text, regex))
            //{
            //    MessageBox.Show("Ok");
            //}


        }


    }
}
