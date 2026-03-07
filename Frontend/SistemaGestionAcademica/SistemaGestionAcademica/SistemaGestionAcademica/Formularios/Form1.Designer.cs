namespace SistemaGestionAcademica.Formularios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            pbLogo = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label22 = new Label();
            label20 = new Label();
            Materia = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label21 = new Label();
            label23 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Carlos Alvarez", "Bryan Cruz", "Kisha Moore", "Josue Varela", "Josue Mejia" });
            comboBox1.Location = new Point(326, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(401, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Selecciona Alumno";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 52);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Alumno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(749, 49);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Parcial";
            label2.Click += label2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            comboBox2.Location = new Point(797, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(39, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(357, 9);
            label3.Name = "label3";
            label3.Size = new Size(296, 32);
            label3.TabIndex = 4;
            label3.Text = "Ingreso de calificaciones";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 186);
            label4.Name = "label4";
            label4.Size = new Size(189, 30);
            label4.TabIndex = 11;
            label4.Text = "Áreas Curriculares";
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.White;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 9);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(191, 160);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 16;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 93);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 17;
            label7.Text = "Alumno:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(424, 93);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 18;
            label8.Text = "Promedio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(555, 93);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 19;
            label9.Text = "Estado: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(316, 93);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 20;
            label10.Text = "Juan Perez";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(492, 93);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 21;
            label11.Text = "87";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(609, 93);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 22;
            label12.Text = "En progreso";
            // 
            // button1
            // 
            button1.Location = new Point(255, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(357, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 24;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(459, 126);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 25;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4669132F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9742146F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.558876F));
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(label22, 0, 1);
            tableLayoutPanel1.Controls.Add(label20, 1, 0);
            tableLayoutPanel1.Controls.Add(Materia, 0, 0);
            tableLayoutPanel1.Controls.Add(label19, 0, 8);
            tableLayoutPanel1.Controls.Add(label18, 0, 7);
            tableLayoutPanel1.Controls.Add(label17, 0, 6);
            tableLayoutPanel1.Controls.Add(label16, 0, 5);
            tableLayoutPanel1.Controls.Add(label15, 0, 4);
            tableLayoutPanel1.Controls.Add(label14, 0, 3);
            tableLayoutPanel1.Controls.Add(label13, 0, 2);
            tableLayoutPanel1.Controls.Add(label23, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox7, 1, 7);
            tableLayoutPanel1.Controls.Add(textBox8, 1, 8);
            tableLayoutPanel1.Controls.Add(textBox9, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox10, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox11, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox12, 2, 4);
            tableLayoutPanel1.Controls.Add(textBox13, 2, 5);
            tableLayoutPanel1.Controls.Add(textBox14, 2, 6);
            tableLayoutPanel1.Controls.Add(label21, 2, 8);
            tableLayoutPanel1.Controls.Add(textBox15, 2, 7);
            tableLayoutPanel1.Cursor = Cursors.No;
            tableLayoutPanel1.Location = new Point(124, 221);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(603, 261);
            tableLayoutPanel1.TabIndex = 28;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Location = new Point(3, 29);
            label22.Name = "label22";
            label22.Size = new Size(33, 15);
            label22.TabIndex = 10;
            label22.Text = "Nota";
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Location = new Point(126, 0);
            label20.Name = "label20";
            label20.Size = new Size(33, 15);
            label20.TabIndex = 8;
            label20.Text = "Nota";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.BackColor = Color.Transparent;
            Materia.Location = new Point(3, 0);
            Materia.Name = "Materia";
            Materia.Size = new Size(47, 15);
            Materia.TabIndex = 0;
            Materia.Text = "Materia";
            Materia.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Location = new Point(3, 232);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 7;
            label19.Text = "Arts";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(3, 203);
            label18.Name = "label18";
            label18.Size = new Size(89, 15);
            label18.TabIndex = 6;
            label18.Text = "Civic Education";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(3, 174);
            label17.Name = "label17";
            label17.Size = new Size(106, 15);
            label17.TabIndex = 5;
            label17.Text = "Physical Education";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(3, 145);
            label16.Name = "label16";
            label16.Size = new Size(79, 15);
            label16.TabIndex = 4;
            label16.Text = "Social Studies";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(3, 116);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 3;
            label15.Text = "Science";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(3, 87);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 2;
            label14.Text = "Math";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(3, 58);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 1;
            label13.Text = "Spanish";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Location = new Point(252, 232);
            label21.Name = "label21";
            label21.Size = new Size(0, 15);
            label21.TabIndex = 9;
            label21.TextAlign = ContentAlignment.TopCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Location = new Point(252, 0);
            label23.Name = "label23";
            label23.Size = new Size(73, 15);
            label23.TabIndex = 11;
            label23.Text = "Observación";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 148);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(126, 177);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(126, 206);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 35;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(126, 235);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 36;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(252, 32);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(347, 23);
            textBox9.TabIndex = 37;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(252, 61);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(347, 23);
            textBox10.TabIndex = 38;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(252, 90);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(347, 23);
            textBox11.TabIndex = 39;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(252, 119);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(347, 23);
            textBox12.TabIndex = 40;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(252, 148);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(347, 23);
            textBox13.TabIndex = 41;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(252, 177);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(347, 23);
            textBox14.TabIndex = 42;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(252, 206);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(347, 23);
            textBox15.TabIndex = 43;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 505);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogo;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Materia;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label22;
        private Label label23;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
    }
}