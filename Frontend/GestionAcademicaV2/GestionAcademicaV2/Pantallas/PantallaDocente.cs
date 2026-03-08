using GestionAcademicaV2.Pantallas.DocenteVentanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionAcademicaV2.Pantallas
{
    public partial class PantallaDocente : Form
    {
        private Form formularioActivo = null;

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;

            formularioHijo.Show();
            formularioHijo.BringToFront();
        }

        public void MostrarBoletaPorNivel(string nivel, int estudianteID)
        {
            if (nivel == "PREBASICA")
                AbrirFormularioEnPanel(new FrmBoletaPrebasica(estudianteID));
           // else if (nivel == "PRIMARIA")
             //   AbrirFormularioEnPanel(new FrmBoletaPrimaria(estudianteID));
           // else if (nivel == "SECUNDARIA")
               // AbrirFormularioEnPanel(new FrmBoletaSecundaria(estudianteID));
        }
        private bool menuExpandido = true;
        public PantallaDocente()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
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

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmSeleccionBoleta(this));
        }
    }
}
