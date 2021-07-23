﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using LOGICA;

namespace Presentacion
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        public void limpiarcontrols()
        {
            txb_producto.Text = string.Empty;
            txb_cantidad.Text = string.Empty;
            txb_precio.Text = string.Empty;
            txb_marca.Text = string.Empty;
            txb_CodProducto.Text = string.Empty;
        }
        public void habilitarControles()
        {
            txb_producto.Enabled = true;
            txb_producto.ReadOnly = false;
            txb_cantidad.Enabled = true;
            txb_cantidad.ReadOnly = false;
            txb_precio.Enabled = true;
            txb_precio.ReadOnly = false;
            txb_marca.Enabled = true;
            txb_marca.ReadOnly = false;
        }

        public cConexion conex = new cConexion();


        public void ActualizarGrid()
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "select * from Producto where NombreProducto like '%'+@NombreProducto+'%'";

            SqlCommand cmd = new SqlCommand(sql, conex.Cadena);
            cmd.Parameters.AddWithValue("@NombreProducto", textBox1.Text);

            if (textBox1.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textBox1, "no se permite campo vacio");
                textBox1.Text = "";
            }

            else
            {
                errorProvider1.SetError(textBox1, "");
                SqlDataReader leer;
                conex.AbrirConex();
                leer = cmd.ExecuteReader();
                tabla.Load(leer);
                conex.CerrarConex();
                dataGridView1.DataSource = tabla;
                dataGridView1.Columns["IdProducto"].Visible = false;
                dataGridView1.Columns["CodProducto"].Visible = false;
                textBox1.Text = "";

            }
        }
        cProducto prod = new cProducto();
        public void edit()
        {
            prod.Editar(txb_producto.Text,Convert.ToInt32(txb_cantidad.Text),Convert.ToDecimal(txb_precio.Text), txb_marca.Text, Convert.ToInt32(txb_IdProducto.Text));

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            edit();
            limpiarcontrols();
            MessageBox.Show("Producto Actualizado");           
            dataGridView1.DataSource = "";
            txb_CodProducto.Visible = false;
            lblCodProducto.Visible = false;
        }
        
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CodProducto.Text = dataGridView1.CurrentRow.Cells["CodProducto"].Value.ToString();
            txb_CodProducto.ReadOnly = true;
            txb_CodProducto.Visible = true;
            lblCodProducto.Visible = true;
            txb_IdProducto.Text = dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString();
            txb_producto.Text = dataGridView1.CurrentRow.Cells["NombreProducto"].Value.ToString();
            txb_cantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
            txb_precio.Text = dataGridView1.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
            txb_marca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
            habilitarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarcontrols();
            dataGridView1.DataSource = "";
            txb_CodProducto.Visible = false;
            lblCodProducto.Visible = false;
        }
    }
}
