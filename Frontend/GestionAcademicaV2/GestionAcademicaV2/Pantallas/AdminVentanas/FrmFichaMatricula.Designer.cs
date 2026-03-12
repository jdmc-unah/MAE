namespace GestionAcademicaV2.Pantallas.AdminVentanas
{
    partial class FrmFichaMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbTituloMatricula = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pbxLogoMatricula = new Guna.UI2.WinForms.Guna2PictureBox();
            lbInformacionAlumno = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            lbGenero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            lbFechaNacimiento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogoMatricula).BeginInit();
            SuspendLayout();
            // 
            // lbTituloMatricula
            // 
            lbTituloMatricula.BackColor = Color.Transparent;
            lbTituloMatricula.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloMatricula.Location = new Point(449, 41);
            lbTituloMatricula.Name = "lbTituloMatricula";
            lbTituloMatricula.Size = new Size(257, 32);
            lbTituloMatricula.TabIndex = 0;
            lbTituloMatricula.Text = "FICHA DE MATRÍCULA";
            // 
            // pbxLogoMatricula
            // 
            pbxLogoMatricula.CustomizableEdges = customizableEdges1;
            pbxLogoMatricula.Image = Properties.Resources._2;
            pbxLogoMatricula.ImageRotate = 0F;
            pbxLogoMatricula.Location = new Point(322, -2);
            pbxLogoMatricula.Name = "pbxLogoMatricula";
            pbxLogoMatricula.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbxLogoMatricula.Size = new Size(120, 116);
            pbxLogoMatricula.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogoMatricula.TabIndex = 1;
            pbxLogoMatricula.TabStop = false;
            // 
            // lbInformacionAlumno
            // 
            lbInformacionAlumno.AutoSize = false;
            lbInformacionAlumno.BackColor = Color.Silver;
            lbInformacionAlumno.BorderStyle = BorderStyle.Fixed3D;
            lbInformacionAlumno.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInformacionAlumno.Location = new Point(72, 117);
            lbInformacionAlumno.Name = "lbInformacionAlumno";
            lbInformacionAlumno.Size = new Size(893, 33);
            lbInformacionAlumno.TabIndex = 2;
            lbInformacionAlumno.Text = "INFORMACIÓN DEL ALUMNO";
            lbInformacionAlumno.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lbNombre
            // 
            lbNombre.BackColor = Color.Transparent;
            lbNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(72, 166);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(109, 17);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.BorderColor = Color.Black;
            txtNombre.BorderRadius = 10;
            txtNombre.CustomizableEdges = customizableEdges3;
            txtNombre.DefaultText = "";
            txtNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Location = new Point(187, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNombre.Size = new Size(327, 36);
            txtNombre.TabIndex = 1;
            // 
            // lbGenero
            // 
            lbGenero.BackColor = Color.Transparent;
            lbGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGenero.Location = new Point(520, 166);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(48, 17);
            lbGenero.TabIndex = 5;
            lbGenero.Text = "Genero:";
            // 
            // cbbGenero
            // 
            cbbGenero.BackColor = Color.Transparent;
            cbbGenero.BorderColor = Color.Black;
            cbbGenero.BorderRadius = 10;
            cbbGenero.CustomizableEdges = customizableEdges5;
            cbbGenero.DrawMode = DrawMode.OwnerDrawFixed;
            cbbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGenero.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbGenero.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbGenero.Font = new Font("Segoe UI", 10F);
            cbbGenero.ForeColor = Color.FromArgb(68, 88, 112);
            cbbGenero.ItemHeight = 30;
            cbbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "No Binario" });
            cbbGenero.Location = new Point(574, 156);
            cbbGenero.Name = "cbbGenero";
            cbbGenero.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbGenero.Size = new Size(140, 36);
            cbbGenero.TabIndex = 6;
            // 
            // lbFechaNacimiento
            // 
            lbFechaNacimiento.BackColor = Color.Transparent;
            lbFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechaNacimiento.Location = new Point(720, 166);
            lbFechaNacimiento.Name = "lbFechaNacimiento";
            lbFechaNacimiento.Size = new Size(120, 17);
            lbFechaNacimiento.TabIndex = 7;
            lbFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.BorderRadius = 10;
            dtpFechaNacimiento.BorderThickness = 1;
            dtpFechaNacimiento.Checked = true;
            dtpFechaNacimiento.CustomizableEdges = customizableEdges7;
            dtpFechaNacimiento.FillColor = Color.Silver;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(846, 156);
            dtpFechaNacimiento.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpFechaNacimiento.Size = new Size(119, 36);
            dtpFechaNacimiento.TabIndex = 8;
            dtpFechaNacimiento.Value = new DateTime(2026, 3, 12, 15, 35, 57, 806);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(72, 208);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(59, 17);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "Identidad:";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.Black;
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(137, 198);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(200, 36);
            guna2TextBox1.TabIndex = 10;
            // 
            // FrmFichaMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 607);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lbFechaNacimiento);
            Controls.Add(cbbGenero);
            Controls.Add(lbGenero);
            Controls.Add(txtNombre);
            Controls.Add(lbNombre);
            Controls.Add(lbInformacionAlumno);
            Controls.Add(pbxLogoMatricula);
            Controls.Add(lbTituloMatricula);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmFichaMatricula";
            Text = "Matrícula";
            ((System.ComponentModel.ISupportInitialize)pbxLogoMatricula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbTituloMatricula;
        private Guna.UI2.WinForms.Guna2PictureBox pbxLogoMatricula;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbInformacionAlumno;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGenero;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGenero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFechaNacimiento;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaNacimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}