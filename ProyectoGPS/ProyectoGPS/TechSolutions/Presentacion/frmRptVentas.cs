using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Reportes;

namespace Presentacion
{
    public partial class frmRptVentas : Form
    {
        public frmRptVentas()
        {
            InitializeComponent();
        }

        //IMPLEMENTACIÓN SINGLENTON
        private static frmRptVentas _Abrir;

        public static frmRptVentas Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new frmRptVentas();
                return _Abrir;
            }

        }

        private void frmRptVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }


        private void frmRptVentas_Load(object sender, EventArgs e)
        {
            CachedCrystalReportVentas ReporteVenta = new CachedCrystalReportVentas();
            CrystalViewerVentas.ReportSource = ReporteVenta;
        }

        
    }
}
