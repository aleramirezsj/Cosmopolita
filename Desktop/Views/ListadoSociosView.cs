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
    public partial class ListadoSociosView : Form
    {
        ReportViewer reporte = new ReportViewer();
        CosmopolitaContext db = new CosmopolitaContext();
        public ListadoSociosView()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            Controls.Add(reporte);
        }

        private void FrmReporteSocios_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.RptListadoSocios.rdlc";
            var socios = db.Socios.OrderBy(s=>s.Apellido_Nombre).ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSSocios",socios));
            
            reporte.RefreshReport();
        }
    }
}
