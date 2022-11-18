using Data;
using Microsoft.EntityFrameworkCore;
using Modelos;
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

namespace Desktop.Views
{
    public partial class CobranzaView : Form
    {
        CosmopolitaContext _context = new CosmopolitaContext();
        public CobranzaView()
        {
            InitializeComponent();
            CargarDatosPantallaAsync();
        }



        private async void CargarDatosPantallaAsync()
        {
            await CargarCboCobradorAsync();
            await CargarGrillaSociosAsync();
            await CargarGrillaCuotasAdeudadasAsync();
            await CargarGrillaCuotasPagasAsync();
        }

        private async Task CargarGrillaCuotasPagasAsync()
        {

                Debug.Print("Ejecutando CargarGrillaCuotasPagasAsync");

                if (gridSocios.RowCount > 0)
                {
                    var idSocioSeleccionado = (int)gridSocios.CurrentRow.Cells[0].Value;
                gridCuotasPagas.DataSource = await _context.Cuotas.Where(c => c.SocioId == idSocioSeleccionado && c.Cobrada).AsNoTracking().ToListAsync();
                }
                else
                {
                    gridCuotasPagas.DataSource = null;
                }
            
        }

        private async Task CargarGrillaCuotasAdeudadasAsync()
        {

                Debug.Print("Ejecutando CargarGrillaCuotasAdeudadasAsync");

                if (gridSocios.RowCount > 0)
                {
                    var idSocioSeleccionado = (int)gridSocios.CurrentRow.Cells[0].Value;
                gridCuotasAdeudadas.DataSource = await _context.Cuotas.Where(c => c.SocioId == idSocioSeleccionado && !c.Cobrada).AsNoTracking().ToListAsync();
                }
                else
                {
                    gridCuotasAdeudadas.DataSource = null;
                }
        }

        private async Task CargarGrillaSociosAsync()
        {
            Debug.Print("Ejecutando CargarGrillaSociosAsync");

            if (!String.IsNullOrEmpty(txtBuscarSocio.Text))
            {
                gridSocios.DataSource = await _context.Socios.Where(s => s.Apellido_Nombre.Contains(txtBuscarSocio.Text)).AsNoTracking().ToListAsync();


            }
            else
            {
                gridSocios.DataSource = await _context.Socios.AsNoTracking().ToListAsync();
            }
            
        }

        private async Task CargarCboCobradorAsync()
        {
            Debug.Print("Ejecutando CargarCboCobradorAsync");

            cboCobrador.DataSource = await _context.Cobradores.AsNoTracking().ToListAsync();
            cboCobrador.DisplayMember = "Apellido_Nombre";
            cboCobrador.ValueMember = "Id";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CargarGrillaSociosAsync();
        }



        //como los botones necesitan habilitarse o deshabilitarse según si hay datos en las grillas hacemos que en el evento DataBindingComplete se determine si se encienden o apagan cuando tienen filas(RowCount>0)
        private void gridCuotasAdeudadas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btnRegistrarPago.Enabled = gridCuotasAdeudadas.RowCount > 0;
        }

        private void gridCuotasPagas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            btnAnularPago.Enabled = gridCuotasPagas.RowCount > 0;
        }

        private async void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            var idCuotaSeleccionada = (int)gridCuotasAdeudadas.CurrentRow.Cells[0].Value;
            Cuota cuotaAMarcarComoPaga = await _context.Cuotas.FindAsync(idCuotaSeleccionada);
            cuotaAMarcarComoPaga.Cobrada = true;
            cuotaAMarcarComoPaga.CobradorId = (int)cboCobrador.SelectedValue;
            _context.Entry(cuotaAMarcarComoPaga).State= EntityState.Modified;
            await _context.SaveChangesAsync();
             await CargarGrillaCuotasAdeudadasAsync();
             await CargarGrillaCuotasPagasAsync();
        }

        private async void btnAnularPago_Click(object sender, EventArgs e)
        {
            var idCuotaSeleccionada = (int)gridCuotasPagas.CurrentRow.Cells[0].Value;
            Cuota cuotaAMarcarComoAdeudada = await _context.Cuotas.FindAsync(idCuotaSeleccionada);
            cuotaAMarcarComoAdeudada.Cobrada = false;
            cuotaAMarcarComoAdeudada.CobradorId = 0;
            _context.Entry(cuotaAMarcarComoAdeudada).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            await CargarGrillaCuotasAdeudadasAsync();
            await CargarGrillaCuotasPagasAsync();
        }

        private async void gridSocios_Click(object sender, EventArgs e)
        {
            await CargarGrillaCuotasAdeudadasAsync();
            await CargarGrillaCuotasPagasAsync();
        }

        private async void gridSocios_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up || e.KeyCode== Keys.Down)
            {
                await CargarGrillaCuotasAdeudadasAsync();
                await CargarGrillaCuotasPagasAsync();
            }
            
        }
    }
}
