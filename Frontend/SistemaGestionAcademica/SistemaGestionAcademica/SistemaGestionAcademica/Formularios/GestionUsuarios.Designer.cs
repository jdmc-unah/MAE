namespace SistemaGestionAcademica.Formularios
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            pbxLogo = new PictureBox();
            lbGestionUsuario = new Label();
            lbNombre = new Label();
            txtNombre = new TextBox();
            lbUsuario = new Label();
            txtUsuario = new TextBox();
            lbcontrasena = new Label();
            lbCorreo = new Label();
            txtCorreo = new TextBox();
            txtContrasena = new MaskedTextBox();
            lbTipoUsuario = new Label();
            cbbTipoUsuario = new ComboBox();
            lbEstado = new Label();
            comboBox1 = new ComboBox();
            lbIdentidad = new Label();
            maskedTextBox1 = new MaskedTextBox();
            btAgregar = new Button();
            btActualizar = new Button();
            btBuscar = new Button();
            btEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.White;
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(229, 28);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(158, 148);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // lbGestionUsuario
            // 
            lbGestionUsuario.AutoSize = true;
            lbGestionUsuario.BackColor = Color.White;
            lbGestionUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGestionUsuario.Location = new Point(185, 171);
            lbGestionUsuario.Name = "lbGestionUsuario";
            lbGestionUsuario.Size = new Size(242, 32);
            lbGestionUsuario.TabIndex = 1;
            lbGestionUsuario.Text = "Gestión de Usuarios";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.White;
            lbNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(127, 242);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(109, 15);
            lbNombre.TabIndex = 2;
            lbNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(242, 239);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 3;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.BackColor = Color.White;
            lbUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(186, 271);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(50, 15);
            lbUsuario.TabIndex = 4;
            lbUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(242, 268);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(145, 23);
            txtUsuario.TabIndex = 5;
            // 
            // lbcontrasena
            // 
            lbcontrasena.AutoSize = true;
            lbcontrasena.BackColor = Color.White;
            lbcontrasena.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbcontrasena.Location = new Point(167, 300);
            lbcontrasena.Name = "lbcontrasena";
            lbcontrasena.Size = new Size(69, 15);
            lbcontrasena.TabIndex = 6;
            lbcontrasena.Text = "Contraseña:";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.BackColor = Color.White;
            lbCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(129, 329);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(107, 15);
            lbCorreo.TabIndex = 8;
            lbCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(242, 326);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(145, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(242, 297);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(145, 23);
            txtContrasena.TabIndex = 10;
            // 
            // lbTipoUsuario
            // 
            lbTipoUsuario.AutoSize = true;
            lbTipoUsuario.BackColor = Color.White;
            lbTipoUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTipoUsuario.Location = new Point(144, 358);
            lbTipoUsuario.Name = "lbTipoUsuario";
            lbTipoUsuario.Size = new Size(92, 15);
            lbTipoUsuario.TabIndex = 11;
            lbTipoUsuario.Text = "Tipo de usuario:";
            // 
            // cbbTipoUsuario
            // 
            cbbTipoUsuario.FormattingEnabled = true;
            cbbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Docente", "Tutor" });
            cbbTipoUsuario.Location = new Point(242, 355);
            cbbTipoUsuario.Name = "cbbTipoUsuario";
            cbbTipoUsuario.Size = new Size(145, 23);
            cbbTipoUsuario.TabIndex = 12;
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.BackColor = Color.White;
            lbEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(191, 387);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(45, 15);
            lbEstado.TabIndex = 13;
            lbEstado.Text = "Estado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox1.Location = new Point(242, 384);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 14;
            // 
            // lbIdentidad
            // 
            lbIdentidad.AutoSize = true;
            lbIdentidad.BackColor = Color.White;
            lbIdentidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIdentidad.Location = new Point(175, 214);
            lbIdentidad.Name = "lbIdentidad";
            lbIdentidad.Size = new Size(61, 15);
            lbIdentidad.TabIndex = 15;
            lbIdentidad.Text = "Identidad:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(242, 211);
            maskedTextBox1.Mask = "####-####-#####";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(98, 23);
            maskedTextBox1.TabIndex = 16;
            // 
            // btAgregar
            // 
            btAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.Location = new Point(184, 413);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 17;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            // 
            // btActualizar
            // 
            btActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btActualizar.Location = new Point(265, 413);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(75, 23);
            btActualizar.TabIndex = 18;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            btBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscar.Location = new Point(346, 210);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(90, 23);
            btBuscar.TabIndex = 19;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            btEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(346, 413);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 20;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 479);
            Controls.Add(btEliminar);
            Controls.Add(btBuscar);
            Controls.Add(btActualizar);
            Controls.Add(btAgregar);
            Controls.Add(maskedTextBox1);
            Controls.Add(lbIdentidad);
            Controls.Add(comboBox1);
            Controls.Add(lbEstado);
            Controls.Add(cbbTipoUsuario);
            Controls.Add(lbTipoUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtCorreo);
            Controls.Add(lbCorreo);
            Controls.Add(lbcontrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lbUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lbNombre);
            Controls.Add(pbxLogo);
            Controls.Add(lbGestionUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxLogo;
        private Label lbGestionUsuario;
        private Label lbNombre;
        private TextBox txtNombre;
        private Label lbUsuario;
        private TextBox txtUsuario;
        private Label lbcontrasena;
        private TextBox textBox1;
        private Label lbCorreo;
        private TextBox txtCorreo;
        private MaskedTextBox txtContrasena;
        private Label lbTipoUsuario;
        private ComboBox cbbTipoUsuario;
        private Label lbEstado;
        private ComboBox comboBox1;
        private Label lbIdentidad;
        private MaskedTextBox maskedTextBox1;
        private Button btAgregar;
        private Button btActualizar;
        private Button btBuscar;
        private Button btEliminar;
    }
}