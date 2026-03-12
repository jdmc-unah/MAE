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
            if (cbbRol.SelectedIndex == 0)
            {
                lbEspecialidad.Visible = false;
                txtEspecialidad.Visible = false;
                lbPosicion.Visible = true;
                txtPosicion.Visible = true;
                lbUsuario.Visible = true;
                txtUsuario.Visible = true;
                lbContrasena.Visible = true;
                txtContrasena.Visible = true;
                lbCorreo.Visible = true;
                txtCorreo.Visible = true;
                lbSexo.Visible = true;
                cbbSexo.Visible = true;
                lbDireccion.Visible = true;
                txtDireccion.Visible=true;
                lbTelefono.Visible = true;
                txtTelefono.Visible = true;
                lbEstado.Visible = true;
                cbbEstado.Visible = true;
                lbFechaNacimiento.Visible = true;
                dtpFechaNacimiento.Visible=true;
            } else if (cbbRol.SelectedIndex == 1)
                {
                    lbEspecialidad.Visible = true;
                    txtEspecialidad.Visible = true;
                    lbPosicion.Visible = false;
                    txtPosicion.Visible = false;
                    lbUsuario.Visible = true;
                    txtUsuario.Visible = true;
                    lbContrasena.Visible = true;
                    txtContrasena.Visible = true;
                    lbCorreo.Visible = true;
                    txtCorreo.Visible = true;
                    lbSexo.Visible = true;
                    cbbSexo.Visible = true;
                    lbDireccion.Visible = true;
                    txtDireccion.Visible = true;
                    lbTelefono.Visible = true;
                    txtTelefono.Visible = true;
                    lbEstado.Visible = true;
                    cbbEstado.Visible = true;
                    lbFechaNacimiento.Visible = true;
                    dtpFechaNacimiento.Visible = true;
            } else if (cbbRol.SelectedIndex == 2) 
                    {
                        lbUsuario.Visible = true;
                        txtUsuario.Visible = true;
                        lbContrasena.Visible = true;
                        txtContrasena.Visible = true;
                        lbCorreo.Visible = true;
                        txtCorreo.Visible = true;
                        lbParentesco.Visible = true;
                        txtParentesco.Visible = true;
                        lbLugarTrabajo.Visible = true;
                        txtLugarTrabajo.Visible = true;
                        lbTelefono.Visible = true;
                        txtTelefono.Visible = true;
                        lbEstado.Visible = true;
                        cbbEstado.Visible = true;
                        lbEspecialidad.Visible = false;
                        txtEspecialidad.Visible = false;
                        lbPosicion.Visible = false;
                        txtPosicion.Visible = false;
                        lbSexo.Visible = false;
                        cbbSexo.Visible = false;
                        lbDireccion.Visible = false;
                        txtDireccion.Visible = false;
                        lbFechaNacimiento.Visible = false;
                        dtpFechaNacimiento.Visible = false;
            }
            }
        }
    }

