using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Modelos;
using Presentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        CosmopolitaContext _context;

        public SplashView()
        {
            InitializeComponent();
            
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
            var conectarDbTask= ConectarConDb();
            var imprimirReporteTask= ImprimirReporte();
            await Task.WhenAll(conectarDbTask, imprimirReporteTask);
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                var inicio = DateTime.Now;
                Debug.Print("se inició la impresión del reporte:" + inicio.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.RptListadoActividades.rdlc";
                var actividades = new List<Actividad>();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSActividades", actividades));
                reporte.RefreshReport();
                ImpresionRealizada = true;
                var fin = DateTime.Now;
                Debug.Print("finalizó la impresión del reporte:" + fin.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
                TimeSpan result = fin.Subtract(inicio);

                Debug.Print("tiempo transcurrido de impresión en milisegundos " + result.TotalMilliseconds);
            });

        }

        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                _context = new CosmopolitaContext();
                var inicio = DateTime.Now;
                Debug.Print("se inició la conexión a la db:" + inicio.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
                await _context.Database.CanConnectAsync();
                ConexionRealizada = true;
                var fin = DateTime.Now;
                Debug.Print("finalizó la conexión a la db sin await:" + fin.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
                TimeSpan result = fin.Subtract(inicio);

                Debug.Print("tiempo transcurrido de conexión db en milisegundos " + result.TotalMilliseconds);

                _context.Database.EnsureCreated();
            });
        }
    }
}
