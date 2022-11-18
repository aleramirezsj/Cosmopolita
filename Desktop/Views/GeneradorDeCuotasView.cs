using Data;
using Desktop.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Modelos;
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

namespace Desktop.Views
{
    public partial class GeneradorDeCuotasView : Form
    {
        IEnumerable<object> _cuotas;
        CosmopolitaContext _context= new CosmopolitaContext();
        public GeneradorDeCuotasView()
        {
            InitializeComponent();
            CargarDatosPantalla();
        }

        private async Task CargarDatosPantalla()
        {
            CargarcboMes();
            CargarcboAño();
            var cargarCboActividadTask= CargarCboActividad();
            var cargarGrillaCuotasTask= CargarGrillaCuotas();
            await Task.WhenAll(cargarCboActividadTask, cargarGrillaCuotasTask);

        }

        private async Task CargarGrillaCuotas()
        {
            var cuotas = await _context.Cuotas.Where(c => c.ActividadId == (int)cboActividad.SelectedValue && c.Año==(int)cboAño.SelectedItem && c.Mes==(MesEnum)cboMes.SelectedIndex+1).Include(c=>c.Socio).DefaultIfEmpty().Include(c=>c.Cobrador).Include(c=>c.Actividad).ToListAsync();
            if (cuotas[0] != null)
            {
                _cuotas = from cuota in cuotas
                          select new
                          {
                              Id = cuota.Id,
                              Socio = cuota.Socio.Apellido_Nombre,
                              Actividad = cuota.Actividad.Nombre,
                              Mes = cuota.Mes,
                              Año = cuota.Año,
                              Importe = cuota.Monto,
                              Vencimiento = cuota.Vencimiento
                          };
                gridCuotas.DataSource = _cuotas.ToList();
            }
            else
            {
                gridCuotas.DataSource = null;
            }
                
            //gridCuotas.Columns["Id"].Visible = false; //Ocultar Id
        }

        private void CargarcboAño()
        {
            for (int i = 2020; i <= DateTime.Now.Year+1; i++)
            {
                cboAño.Items.Add(i);
            }
            cboAño.SelectedItem = DateTime.Now.Year;

        }

        private void CargarcboMes()
        {
            cboMes.DataSource = Enum.GetValues(typeof(MesEnum));
            cboMes.SelectedIndex = DateTime.Now.Month-1;

        }

        private async Task CargarCboActividad()
        {
            cboActividad.DataSource = await _context.Actividades.ToListAsync();
            cboActividad.DisplayMember = "Nombre";
            cboActividad.ValueMember = "Id";
            cboActividad_SelectionChangeCommitted(this, EventArgs.Empty);

        }

        private async void cboActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var actividad = _context.Actividades.Find((int)cboActividad.SelectedValue);
            nudImporte.Value=actividad.Costo;
            await CargarGrillaCuotas();
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            //traemos todos los socios de la actividad seleccionada
            var socios = _context.Inscriptos.Where(i => i.ActividadId == (int)cboActividad.SelectedValue);
            //generamos las cuotas de los socios
            foreach (Inscripto inscripto in socios)
            {
                var cuota = new Cuota()
                {
                    ActividadId = (int)cboActividad.SelectedValue,
                    SocioId = inscripto.SocioId,
                    Año = (int)cboAño.SelectedItem,
                    Mes = (MesEnum)cboMes.SelectedIndex + 1,
                    Monto = nudImporte.Value,
                    Vencimiento = dateTimePicker1.Value.Date
                };
                _context.Cuotas.Add(cuota);
            }
            await _context.SaveChangesAsync();
            await CargarGrillaCuotas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var listadoCuotasView = new CuotasViewReport(_cuotas);
            listadoCuotasView.ShowDialog();
        }

        private async void cboAño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await CargarGrillaCuotas();
        }

        private async void cboMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await CargarGrillaCuotas();
        }
    }
}
