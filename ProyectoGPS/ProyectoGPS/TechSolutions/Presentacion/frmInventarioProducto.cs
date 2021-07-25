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
using DATOS;

namespace Presentacion
{
    public partial class frmInventarioProducto : Form
    {
        public frmInventarioProducto()
        {
            InitializeComponent();
        }

        // SINGLETON
        private static frmInventarioProducto _Abrir;
        // PROPIEDAD SOLO GET
        public static frmInventarioProducto Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new frmInventarioProducto();
                return _Abrir;
            }
        }
        private void frmInventarioProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }


        cProducto lstProducto = new cProducto();
        
        public void Mostrar()
        {
            dataGridView1.DataSource = lstProducto.tbMostrarInventario();
            dataGridView1.Columns["IdProducto"].Visible = false;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        
    }
}
