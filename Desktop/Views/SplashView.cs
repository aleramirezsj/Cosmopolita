using Data;
using Microsoft.Reporting.WinForms;
using Presentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Presentación
{
    public partial class SplashView : Form
    {
        bool ConexionRealizada=false;
        bool ImpresionRealizada=false;
        CosmopolitaContext db = new CosmopolitaContext();

        public SplashView()
        {
            InitializeComponent();
            var db = new CosmopolitaContext();
            db.Database.EnsureCreated();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 2;
            if (ConexionRealizada && ImpresionRealizada)
            {
                timer.Enabled = false;
                this.Visible = false;
                var frmMenuPrincipal = new MenuPrincipalView();
                frmMenuPrincipal.ShowDialog();
                this.Close();
            }
        }

        private async void FrmSplash_Activated(object sender, EventArgs e)
        {
            await ConectarConDb();
            await ImprimirReporte();
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.RptListadoActividades.rdlc";
                var actividades = db.Actividades.ToList();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSActividades", actividades));
                reporte.RefreshReport();
                ImpresionRealizada = true;
            });
        }

        private async Task ConectarConDb()
        {
            await Task.Run(() =>
            {
                db.Database.CanConnectAsync();
                ConexionRealizada = true;
            });
        }
    }
}
