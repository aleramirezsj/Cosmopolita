using Data;
using Desktop.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

namespace Desktop.Views
{
    public partial class GeneradorDeCuotasView : Form
    {
        CosmopolitaContext _context= new CosmopolitaContext();
        public GeneradorDeCuotasView()
        {
            InitializeComponent();
            CargarCboActividad();           
            CargarcboMes();
            CargarcboAño();
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

        private void cboActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var actividad = _context.Actividades.Find((int)cboActividad.SelectedValue);
            nudImporte.Value=actividad.Costo;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //traemos todos los socios de la actividad seleccionada
            var socios = _context.Inscriptos.Where(i => i.ActividadId == (int)cboActividad.SelectedValue);
            //generamos las cuotas de los socios
            foreach (Inscripto inscripto in socios)
            {
                var cuota= new Cuota()
                {
                    ActividadId=(int)cboActividad.SelectedValue,
                    SocioId=inscripto.SocioId,
                    Año=(int)cboAño.SelectedItem,
                    Mes =cboMes.SelectedIndex+1,
                    Monto=nudImporte.Value                
                };
                _context.Cuotas.Add(cuota);
            }
            _context.SaveChangesAsync();
        }
    }
}
