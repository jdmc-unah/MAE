using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionAcademicaV2.Pantallas.AdminVentanas
{
    public partial class FrmGestionUsuarios : Form
    {
        private PantallaAdmin pantallaPrincipal;
        public FrmGestionUsuarios(PantallaAdmin principal)
        {
            InitializeComponent();
            pantallaPrincipal = principal;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void cbbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRol.SelectedIndex == 1)
            {
                lbEspecialidad.Visible = false;
                txtEspecialidad.Visible = false;
                lbPosicion.Visible = true;
                txtPosicion.Visible = true;
            } else if (cbbRol.SelectedIndex == 2)
                {
                lbEspecialidad.Visible = true;
                txtEspecialidad.Visible = true;
                lbPosicion.Visible = false;
                txtPosicion.Visible = false;
                }
                else
                {
                    
                }
            }
        }
    }

