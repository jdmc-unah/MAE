namespace SistemaGestionAcademica.Formularios
{
    partial class ReporteNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteNotas));
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Matematicas = new DataGridViewTextBoxColumn();
            Ingles = new DataGridViewTextBoxColumn();
            Artistica = new DataGridViewTextBoxColumn();
            Espanol = new DataGridViewTextBoxColumn();
            Filosofia = new DataGridViewTextBoxColumn();
            Civica = new DataGridViewTextBoxColumn();
            Biologia = new DataGridViewTextBoxColumn();
            label5 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.White;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(318, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(158, 148);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 151);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 1;
            label1.Text = "Reporte de notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 199);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Identidad:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(344, 196);
            maskedTextBox1.Mask = "####-####-#####";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(95, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(445, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 228);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 228);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Parcial:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "I Parcial", "II Parcial", "III Parcial", "IV Parcial" });
            comboBox1.Location = new Point(439, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Matematicas, Ingles, Artistica, Espanol, Filosofia, Civica, Biologia });
            dataGridView1.Location = new Point(39, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 164);
            dataGridView1.TabIndex = 9;
            // 
            // Matematicas
            // 
            Matematicas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Matematicas.HeaderText = "Matemáticas";
            Matematicas.Name = "Matematicas";
            // 
            // Ingles
            // 
            Ingles.HeaderText = "Inglés";
            Ingles.Name = "Ingles";
            Ingles.Width = 80;
            // 
            // Artistica
            // 
            Artistica.HeaderText = "Artística";
            Artistica.Name = "Artistica";
            Artistica.Width = 90;
            // 
            // Espanol
            // 
            Espanol.HeaderText = "Español";
            Espanol.Name = "Espanol";
            // 
            // Filosofia
            // 
            Filosofia.HeaderText = "Filosofía";
            Filosofia.Name = "Filosofia";
            // 
            // Civica
            // 
            Civica.HeaderText = "Cívica";
            Civica.Name = "Civica";
            // 
            // Biologia
            // 
            Biologia.HeaderText = "Biología";
            Biologia.Name = "Biologia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(566, 228);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Año:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            comboBox2.Location = new Point(604, 225);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 23);
            comboBox2.TabIndex = 11;
            // 
            // ReporteNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Name = "ReporteNotas";
            Text = "ReporteNotas";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Matematicas;
        private DataGridViewTextBoxColumn Ingles;
        private DataGridViewTextBoxColumn Artistica;
        private DataGridViewTextBoxColumn Espanol;
        private DataGridViewTextBoxColumn Filosofia;
        private DataGridViewTextBoxColumn Civica;
        private DataGridViewTextBoxColumn Biologia;
        private Label label5;
        private ComboBox comboBox2;
    }
}