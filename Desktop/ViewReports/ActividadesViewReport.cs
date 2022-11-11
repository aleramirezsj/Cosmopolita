using Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class ActividadesViewReport : Form
    {
        CosmopolitaContext db = new CosmopolitaContext();
        ReportViewer reporte = new ReportViewer();
        public ActividadesViewReport()
        {
            InitializeComponent();
            reporte.Dock= DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode=ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private void FrmReporteActividades_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.RptListadoActividades.rdlc";
            var actividades = db.Actividades.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSActividades", actividades));
            reporte.RefreshReport();
        }
    }
}
