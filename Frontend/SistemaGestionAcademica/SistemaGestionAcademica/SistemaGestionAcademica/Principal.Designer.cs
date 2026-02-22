namespace SistemaGestionAcademica
{
    partial class Portada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            Temporizador = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            reunionesToolStripMenuItem = new ToolStripMenuItem();
            alertasInformátivasToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            administraciónDeDocentesToolStripMenuItem = new ToolStripMenuItem();
            administraciónDeGradosToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            tutorToolStripMenuItem = new ToolStripMenuItem();
            reporteDeNotasToolStripMenuItem = new ToolStripMenuItem();
            reporteDeReunionesToolStripMenuItem = new ToolStripMenuItem();
            reporteDeAlertasInformátivasToolStripMenuItem = new ToolStripMenuItem();
            sesiónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Temporizador
            // 
            Temporizador.Tick += Temporizador_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { docentesToolStripMenuItem, administraciónToolStripMenuItem, tutorToolStripMenuItem, sesiónToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(724, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mnPrincipal";
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notasToolStripMenuItem, reunionesToolStripMenuItem, alertasInformátivasToolStripMenuItem });
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(76, 21);
            docentesToolStripMenuItem.Text = "Docentes";
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(198, 22);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // reunionesToolStripMenuItem
            // 
            reunionesToolStripMenuItem.Name = "reunionesToolStripMenuItem";
            reunionesToolStripMenuItem.Size = new Size(198, 22);
            reunionesToolStripMenuItem.Text = "Reuniones";
            // 
            // alertasInformátivasToolStripMenuItem
            // 
            alertasInformátivasToolStripMenuItem.Name = "alertasInformátivasToolStripMenuItem";
            alertasInformátivasToolStripMenuItem.Size = new Size(198, 22);
            alertasInformátivasToolStripMenuItem.Text = "Alertas Informátivas";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administraciónDeDocentesToolStripMenuItem, administraciónDeGradosToolStripMenuItem, gestiónDeUsuariosToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(111, 21);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // administraciónDeDocentesToolStripMenuItem
            // 
            administraciónDeDocentesToolStripMenuItem.Name = "administraciónDeDocentesToolStripMenuItem";
            administraciónDeDocentesToolStripMenuItem.Size = new Size(245, 22);
            administraciónDeDocentesToolStripMenuItem.Text = "Administración de docentes";
            // 
            // administraciónDeGradosToolStripMenuItem
            // 
            administraciónDeGradosToolStripMenuItem.Name = "administraciónDeGradosToolStripMenuItem";
            administraciónDeGradosToolStripMenuItem.Size = new Size(245, 22);
            administraciónDeGradosToolStripMenuItem.Text = "Administración de grados";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            gestiónDeUsuariosToolStripMenuItem.Size = new Size(245, 22);
            gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            gestiónDeUsuariosToolStripMenuItem.Click += gestiónDeUsuariosToolStripMenuItem_Click;
            // 
            // tutorToolStripMenuItem
            // 
            tutorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeNotasToolStripMenuItem, reporteDeReunionesToolStripMenuItem, reporteDeAlertasInformátivasToolStripMenuItem });
            tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            tutorToolStripMenuItem.Size = new Size(52, 21);
            tutorToolStripMenuItem.Text = "Tutor";
            // 
            // reporteDeNotasToolStripMenuItem
            // 
            reporteDeNotasToolStripMenuItem.Name = "reporteDeNotasToolStripMenuItem";
            reporteDeNotasToolStripMenuItem.Size = new Size(266, 22);
            reporteDeNotasToolStripMenuItem.Text = "Reporte de notas";
            // 
            // reporteDeReunionesToolStripMenuItem
            // 
            reporteDeReunionesToolStripMenuItem.Name = "reporteDeReunionesToolStripMenuItem";
            reporteDeReunionesToolStripMenuItem.Size = new Size(266, 22);
            reporteDeReunionesToolStripMenuItem.Text = "Reporte de reuniones";
            // 
            // reporteDeAlertasInformátivasToolStripMenuItem
            // 
            reporteDeAlertasInformátivasToolStripMenuItem.Name = "reporteDeAlertasInformátivasToolStripMenuItem";
            reporteDeAlertasInformátivasToolStripMenuItem.Size = new Size(266, 22);
            reporteDeAlertasInformátivasToolStripMenuItem.Text = "Reporte de alertas informátivas";
            // 
            // sesiónToolStripMenuItem
            // 
            sesiónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            sesiónToolStripMenuItem.ForeColor = Color.Black;
            sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            sesiónToolStripMenuItem.Size = new Size(59, 21);
            sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(173, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(173, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // Portada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 617);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Portada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += Portada_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer Temporizador;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sesiónToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem reunionesToolStripMenuItem;
        private ToolStripMenuItem alertasInformátivasToolStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem administraciónDeDocentesToolStripMenuItem;
        private ToolStripMenuItem administraciónDeGradosToolStripMenuItem;
        private ToolStripMenuItem tutorToolStripMenuItem;
        private ToolStripMenuItem reporteDeNotasToolStripMenuItem;
        private ToolStripMenuItem reporteDeReunionesToolStripMenuItem;
        private ToolStripMenuItem reporteDeAlertasInformátivasToolStripMenuItem;
        private ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
    }
}
