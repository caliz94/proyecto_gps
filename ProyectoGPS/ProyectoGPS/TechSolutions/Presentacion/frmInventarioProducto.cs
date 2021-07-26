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

namespace Presentacion
{
    public partial class frmInventarioProducto : Form
    {
        public frmInventarioProducto()
        {
            InitializeComponent();
        }


        // INSTANCIACIÓN DE LA CLASE cProducto DE LA CAPA LOGICA

        cProducto lstProducto = new cProducto();


        // IMPLEMENTACIÓN DEL PATRON DE SINGLETON

        private static frmInventarioProducto _Abrir;
        // Propiedad solo get
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

        
        // PROGRAMACIÓN DE LOS MÉTODOS
        
        public void Mostrar()
        {
            dataGridView1.DataSource = lstProducto.tbMostrarInventario();
            dataGridView1.Columns["IdProducto"].Visible = false;
        }

        // PROGRAMACIÓN DEL EVENTO LOAD

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        
    }
}
