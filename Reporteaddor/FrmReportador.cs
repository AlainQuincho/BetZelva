using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Reflection;

namespace Reporteaddor
{
    public partial class FrmReportador : Form
    {
        MetodosReporte _Reporte = new MetodosReporte();
        List<ReportDataSource> _DataSource;
        string _ReportPath;
        List<ReportParameter> _Parameter; 
        ReportViewer _rpvReporteLocal;

        public FrmReportador(List<ReportDataSource> DataSource, String ReportPath, List<ReportParameter> Parameter)
        {
            _DataSource = DataSource;
            _ReportPath = ReportPath;
            _Parameter  = Parameter;
            InitializeComponent();
        }

        private void FrmReportador_Load(object sender, EventArgs e)
        {
            _Reporte.MetodoPrincipal(_DataSource,_ReportPath,_Parameter,ref ReportViewer);
        }
    }
}
