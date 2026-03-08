using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GestionAcademicaV2.Modelos.Data;
using GestionAcademicaV2.Modelos;

namespace GestionAcademicaV2.Pantallas.DocenteVentanas
{
    public partial class FrmSeleccionBoleta : Form
    {
        private PantallaDocente pantallaPrincipal;
    
        public FrmSeleccionBoleta(PantallaDocente principal)
        {
            InitializeComponent();
            pantallaPrincipal = principal;
        }

        private void FrmSeleccionBoleta_Load(object sender, EventArgs e)
        {
            btnAbrirBoleta.Enabled = false;
            CargarClases();
        }

        private void CargarClases()
        {
            var clases = DatosDummie.ObtenerClases();

            dgvClases.Rows.Clear();

            foreach (var clase in clases)
            {
                dgvClases.Rows.Add(
                    clase.CargaID,
                    clase.Grado,
                    clase.Seccion,
                    clase.Asignatura
                );
            }
        }

        private void CargarEstudiantes()
        {
            if (dgvClases.CurrentRow == null) return;

            int cargaID = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value);

            var estudiantes = DatosDummie.ObtenerEstudiantes()
                .Where(x => x.CargaID == cargaID)
                .ToList();

            dgvEstudiantes.Rows.Clear();

            foreach (var est in estudiantes)
            {
                dgvEstudiantes.Rows.Add(est.EstudianteID, est.Nombre);
            }
        }

        private void btnCargarEstudiantes_Click(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }

        private void dgvClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrirBoleta_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un estudiante.");
                return;
            }

            int estudianteID = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["ID"].Value);
            string nivel = "PREBASICA"; // temporal

            pantallaPrincipal.MostrarBoletaPorNivel(nivel, estudianteID);
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                btnAbrirBoleta.Enabled = true;
            }
        }
    }
}
