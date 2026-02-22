using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestionAcademica.Formularios
{
    public partial class Principal : Form
    {
        int tiempoRestante = 15; // en segundos
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Temporizador.Start();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            if (tiempoRestante <= 0)
            {
                Temporizador.Stop();
                Formularios.Login forma = new Formularios.Login();
                forma.Show();
                this.Hide();
            }
        }
    }
}
