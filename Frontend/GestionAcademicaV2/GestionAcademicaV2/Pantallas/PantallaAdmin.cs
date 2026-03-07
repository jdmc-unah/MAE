using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionAcademicaV2.Pantallas
{
    public partial class PantallaAdmin : Form
    {
        private bool menuExpandido = true;
        public PantallaAdmin()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {

        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {

        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                pnlMenu.Width = 60;
                menuExpandido = false;
            }
            else
            {
                pnlMenu.Width = 220;
                menuExpandido = true;
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
