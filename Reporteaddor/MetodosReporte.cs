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
    public class MetodosReporte
    {
        List<ReportDataSource> dts;
        List<ReportParameter> param;
        String ReportPath;
        IList<Stream> m_streams = new List<Stream>();
        SaveFileDialog savedialogo = new SaveFileDialog();

        public void MetodoPrincipal(List<ReportDataSource> DataSource, String _ReportPath, List<ReportParameter> Parameter, ref ReportViewer rpvReporteLocal)
        {
            dts = DataSource;
            ReportPath = _ReportPath;
            param = Parameter;

            MOSTRAR_REPORTE(ref rpvReporteLocal);
        }

        public void MOSTRAR_REPORTE(ref ReportViewer rpvReporteLocal)
        {
            rpvReporteLocal.ProcessingMode = ProcessingMode.Local;
            rpvReporteLocal.LocalReport.EnableExternalImages = true;

            Assembly assembly = Assembly.LoadFrom("Reporteaddor.dll");
            Stream stream = assembly.GetManifestResourceStream("Reporteaddor." + ReportPath);
            rpvReporteLocal.LocalReport.LoadReportDefinition(stream);

            ReportDataSource dtsunico = new ReportDataSource();
            if (param != null)
            {
                rpvReporteLocal.LocalReport.SetParameters(param);
            }
            for (int i = 0; i < dts.Count(); i++)
            {
                dtsunico.Name = dts[i].Name;
                dtsunico.Value = dts[i].Value;
                rpvReporteLocal.LocalReport.DataSources.Add(new ReportDataSource(dtsunico.Name, dtsunico.Value));
            }

            rpvReporteLocal.RefreshReport();
        }
    }
}
