using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Desktop.Presentación;
using Desktop.Views;
using Modelos;
using Presentación;


namespace Presentación
{
    public partial class MenuPrincipalView : Form
    {
        public static Usuario UsuarioLogueado { get; set; }
        public MenuPrincipalView()
        {
            InitializeComponent();
            CboModoOscuroClaro.SelectedIndex = 0;
            
            
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void acercaDeSistemaClubSocialCosmopolitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            acercaDeSistemaClubSocialCosmopolitaToolStripMenuItem_Click(sender,e);
        }

        private void ocultarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnOpciones.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        private void mostrarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BtnOpciones.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BtnSalir.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void mostrarEtiquetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarEtiquetasToolStripMenuItem_Click(sender, e);
        }

        private void ocultarEtiquetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultarEtiquetasToolStripMenuItem_Click(sender, e);
        }

        private void CboModoOscuroClaro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //modo claro
            if(CboModoOscuroClaro.SelectedIndex==0)
            {
                this.BackColor = SystemColors.Control;
                LblEstado.Text = "Modo claro";
                StsBarraDeEstado.BackColor = SystemColors.Control;
            }else//modo oscuro
            {
                this.BackColor=SystemColors.ControlDark;
                LblEstado.Text = "Modo oscuro";
                StsBarraDeEstado.BackColor = SystemColors.ControlDark;
            }
        }

        private void modoOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CboModoOscuroClaro.SelectedIndex = 1;
        }

        private void curoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CboModoOscuroClaro.SelectedIndex = 0;
        }

        private void FrmMenuPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                CmsMenuContextual.Show(MousePosition);
            }
        }

        private void nuevoCobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarCobrador = new NuevoEditarCobradorView();
            frmNuevoEditarCobrador.ShowDialog();
        }

        private void nuevaDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarActividad = new NuevoEditarActividadView();
            frmNuevoEditarActividad.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmListadoActividades = new GestiónDeActividadesView();
            frmListadoActividades.ShowDialog();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmListadoCobradores = new GestiónDeCobradoresView();
            frmListadoCobradores.ShowDialog();
        }

        private void listado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmListado2Actividades = new Actividades2View();
            frmListado2Actividades.ShowDialog();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            
            //si no hay un usuario logueado
            if (UsuarioLogueado==null)
            {
                //instanciamos el formulario FrmLogin
                var frmLogin = new LoginView();
                //mostramos el formulario en modo Modal
                //(está por encima de todo)
                frmLogin.ShowDialog();
                //luego de salir del formulario login
                //chequeamos si se almaceno en la propiedad UsuarioLogueado a algún usuario
                if(UsuarioLogueado==null)
                    Application.Exit();
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void impresiónListaDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmReporteSocios=new SociosViewReport();
            frmReporteSocios.ShowDialog();  
        }

        private void impresiónListadoDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmReporteActidades = new ActividadesViewReport();
            frmReporteActidades.ShowDialog();
        }

        private void iconMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMenuAcercaDe_Click(object sender, EventArgs e)
        {
            var texto = "Hecho por: Tomás Benitez";
            texto += Environment.NewLine;
            texto += "Materia: Programación 1";
            texto += Environment.NewLine;
            texto += "Carrera: TSD Software";
            var titulo = "Acerca de...";
            MessageBox.Show(texto, titulo);
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AcercaDeView frmAcercaDe = new AcercaDeView();
            frmAcercaDe.ShowDialog();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmGestionSocios = new GestiónDeSociosView();
            frmGestionSocios.ShowDialog();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            var frmInscriptos = new InscriptosView();
            frmInscriptos.ShowDialog();
        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var generadorDeCuotasView=new GeneradorDeCuotasView();
            generadorDeCuotasView.ShowDialog();
        }

        private void cuotasDeDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cobranzaView = new CobranzaView();
            cobranzaView.ShowDialog();
        }
    }
}