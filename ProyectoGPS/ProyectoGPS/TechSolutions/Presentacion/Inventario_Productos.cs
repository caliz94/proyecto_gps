﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA;

namespace Presentacion
{
    public partial class Inventario_Productos : Form
    {
        public Inventario_Productos()
        {
            InitializeComponent();
        }

        cProducto cprod = new cProducto();
        private void button1_Click(object sender, EventArgs e)
        {
            cprod.Insertar(txb_producto.Text, Convert.ToInt32(txb_cantidad.Text), Convert.ToDecimal(txb_precio.Text), txb_marca.Text);
        }
    }
}