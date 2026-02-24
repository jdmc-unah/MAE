namespace SistemaGestionAcademica
{
    public partial class Portada : Form
    {

        public Portada()
        {
            InitializeComponent();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Login forma = new Formularios.Login();
            forma.Show();
            this.Close();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.GestionUsuarios forma = new Formularios.GestionUsuarios();
            forma.Show();
        }

        private void reporteDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.ReporteNotas forma = new Formularios.ReporteNotas();
            forma.Show();
        }
    }
}
