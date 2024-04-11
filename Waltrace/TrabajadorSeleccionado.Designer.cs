namespace Waltrace
{
    partial class TrabajadorSeleccionado
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CurriculumButton = new Button();
            RegresarButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            LoadingText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 15);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 0;
            label2.Text = "Rut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 114);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 0;
            label4.Text = "Empresa contratante:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 147);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 0;
            label5.Text = "Fecha inicio:";
            // 
            // CurriculumButton
            // 
            CurriculumButton.Location = new Point(206, 212);
            CurriculumButton.Name = "CurriculumButton";
            CurriculumButton.Size = new Size(164, 29);
            CurriculumButton.TabIndex = 7;
            CurriculumButton.Text = "Descargar Currículum";
            CurriculumButton.UseVisualStyleBackColor = true;
            CurriculumButton.Click += CurriculumButton_Click;
            CurriculumButton.MouseEnter += CurriculumButton_MouseEnter;
            CurriculumButton.MouseLeave += CurriculumButton_MouseLeave;
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(376, 212);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 1;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += RegresarButton_MouseEnter;
            RegresarButton.MouseLeave += RegresarButton_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(345, 45);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(345, 78);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(345, 111);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(345, 144);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Location = new Point(12, 175);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(115, 20);
            LoadingText.TabIndex = 0;
            LoadingText.Text = "Cargando foto...";
            LoadingText.Visible = false;
            // 
            // TrabajadorSeleccionado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(LoadingText);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RegresarButton);
            Controls.Add(CurriculumButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "TrabajadorSeleccionado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Trabajador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CurriculumButton;
        private Button RegresarButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label LoadingText;
    }
}