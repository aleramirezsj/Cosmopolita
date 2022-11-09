using Data;
using Microsoft.Reporting.WinForms;
using Modelos;
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
    public partial class ListadoCuotasView : Form
    {
        IEnumerable<object> _cuotas;
        ReportViewer reporte = new ReportViewer();
        public ListadoCuotasView(IEnumerable<object> cuotas)
        {
            InitializeComponent();
            reporte.Dock= DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode=ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
            this._cuotas = cuotas;
        }

        private void FrmReporteActividades_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.RptListadoCuotas.rdlc";
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCuotas", this._cuotas));
            reporte.RefreshReport();
        }
    }
}
