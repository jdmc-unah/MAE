namespace SistemaGestionAcademica.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btIniciarSesión = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(154, 203);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(129, 238);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(227, 203);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(227, 238);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(183, 23);
            txtContrasena.TabIndex = 4;
            // 
            // btIniciarSesión
            // 
            btIniciarSesión.BackColor = Color.Chocolate;
            btIniciarSesión.BackgroundImageLayout = ImageLayout.Stretch;
            btIniciarSesión.FlatAppearance.BorderColor = Color.Black;
            btIniciarSesión.FlatAppearance.BorderSize = 8;
            btIniciarSesión.FlatAppearance.MouseDownBackColor = Color.Peru;
            btIniciarSesión.FlatStyle = FlatStyle.Popup;
            btIniciarSesión.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIniciarSesión.ForeColor = Color.White;
            btIniciarSesión.Location = new Point(183, 289);
            btIniciarSesión.Name = "btIniciarSesión";
            btIniciarSesión.Size = new Size(183, 36);
            btIniciarSesión.TabIndex = 5;
            btIniciarSesión.Tag = "";
            btIniciarSesión.Text = "Iniciar sesión";
            btIniciarSesión.UseVisualStyleBackColor = false;
            btIniciarSesión.Click += btIniciarSesión_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 466);
            Controls.Add(btIniciarSesión);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btIniciarSesión;
    }
}