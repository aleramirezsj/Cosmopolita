using Data;
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

namespace Desktop.Presentación
{
    public partial class InscriptosView : Form
    {
        CosmopolitaContext db = new CosmopolitaContext();
        public InscriptosView()
        {
            InitializeComponent();
            CargarCboActividades();
            CargarCboSocio();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            if (cboActividad.SelectedValue!=null&&
                cboActividad.SelectedValue.GetType()==typeof(int))
            gridInscriptos.DataSource = db.Inscriptos.Where(i => i.ActividadId == (int)cboActividad.SelectedValue).ToList();
        }

        private void CargarCboActividades()
        {
            cboActividad.DataSource = db.Actividades.ToList();
            cboActividad.DisplayMember = "Nombre";
            cboActividad.ValueMember = "Id";
        }
        private void CargarCboSocio()
        {
            cboSocio.DataSource = db.Socios.ToList();
            cboSocio.DisplayMember = "Apellido_Nombre";
            cboSocio.ValueMember = "Id";
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var inscripcion = new Inscripto()
            {
                SocioId = (int)cboSocio.SelectedValue,
                ActividadId=(int)cboActividad.SelectedValue
            };
            db.Inscriptos.Add(inscripcion);
            db.SaveChanges();
            CargarGrilla();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y nombre del socio inscripto
            var idInscripción = (int)gridInscriptos.CurrentRow.Cells[0].Value;
            var socio = (Socio)gridInscriptos.CurrentRow.Cells[2].Value;

            //preguntamos al usuario si está seguro que quiere borrar
            DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar la inscripción de {socio.Apellido_Nombre}?", "Eliminar inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si contestó que si, borramos la actividad
            if (respuesta == DialogResult.Yes)
            {
                //obtenemos la inscripción a borrar
                var inscripcionABorrar = db.Inscriptos.Find(idInscripción);

                //borramos la inscripción
                db.Inscriptos.Remove(inscripcionABorrar);

                //guardamos los cambios
                db.SaveChanges();

                CargarGrilla();
            }
        }
    }
}
