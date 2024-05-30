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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrabajadorSeleccionado));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AceptarButton = new Button();
            DisplayBoxNom = new TextBox();
            DisplayBoxRut = new TextBox();
            DisplayBoxCargo = new TextBox();
            DisplayBoxEmp = new TextBox();
            DisplayBoxAño = new TextBox();
            LoadingText = new Label();
            CurriculumLink = new LinkLabel();
            FotoBox = new PictureBox();
            CopyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FotoBox).BeginInit();
            SuspendLayout();
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
            label3.Location = new Point(190, 114);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 81);
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
            // AceptarButton
            // 
            AceptarButton.Location = new Point(426, 212);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(94, 29);
            AceptarButton.TabIndex = 1;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            AceptarButton.MouseEnter += Button_MouseEnter;
            AceptarButton.MouseLeave += Button_MouseLeave;
            // 
            // DisplayBoxNom
            // 
            DisplayBoxNom.Location = new Point(345, 12);
            DisplayBoxNom.Name = "DisplayBoxNom";
            DisplayBoxNom.ReadOnly = true;
            DisplayBoxNom.Size = new Size(175, 27);
            DisplayBoxNom.TabIndex = 2;
            // 
            // DisplayBoxRut
            // 
            DisplayBoxRut.Location = new Point(345, 45);
            DisplayBoxRut.Name = "DisplayBoxRut";
            DisplayBoxRut.ReadOnly = true;
            DisplayBoxRut.Size = new Size(175, 27);
            DisplayBoxRut.TabIndex = 3;
            // 
            // DisplayBoxCargo
            // 
            DisplayBoxCargo.Location = new Point(345, 111);
            DisplayBoxCargo.Name = "DisplayBoxCargo";
            DisplayBoxCargo.ReadOnly = true;
            DisplayBoxCargo.Size = new Size(175, 27);
            DisplayBoxCargo.TabIndex = 5;
            // 
            // DisplayBoxEmp
            // 
            DisplayBoxEmp.Location = new Point(345, 78);
            DisplayBoxEmp.Name = "DisplayBoxEmp";
            DisplayBoxEmp.ReadOnly = true;
            DisplayBoxEmp.Size = new Size(175, 27);
            DisplayBoxEmp.TabIndex = 4;
            // 
            // DisplayBoxAño
            // 
            DisplayBoxAño.Location = new Point(345, 144);
            DisplayBoxAño.Name = "DisplayBoxAño";
            DisplayBoxAño.ReadOnly = true;
            DisplayBoxAño.Size = new Size(175, 27);
            DisplayBoxAño.TabIndex = 6;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Location = new Point(12, 203);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(115, 20);
            LoadingText.TabIndex = 0;
            LoadingText.Text = "Cargando foto...";
            LoadingText.Visible = false;
            // 
            // CurriculumLink
            // 
            CurriculumLink.AutoSize = true;
            CurriculumLink.Location = new Point(273, 180);
            CurriculumLink.Name = "CurriculumLink";
            CurriculumLink.Size = new Size(247, 20);
            CurriculumLink.TabIndex = 8;
            CurriculumLink.TabStop = true;
            CurriculumLink.Text = "Descargar antecedentes curriculares";
            CurriculumLink.LinkClicked += CurriculumLink_LinkClicked;
            // 
            // FotoBox
            // 
            FotoBox.Location = new Point(12, 12);
            FotoBox.Name = "FotoBox";
            FotoBox.Size = new Size(172, 188);
            FotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FotoBox.TabIndex = 9;
            FotoBox.TabStop = false;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(251, 212);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(169, 29);
            CopyButton.TabIndex = 10;
            CopyButton.Text = "Copiar al portapapeles";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // TrabajadorSeleccionado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(532, 253);
            Controls.Add(CopyButton);
            Controls.Add(FotoBox);
            Controls.Add(CurriculumLink);
            Controls.Add(LoadingText);
            Controls.Add(DisplayBoxAño);
            Controls.Add(DisplayBoxEmp);
            Controls.Add(DisplayBoxCargo);
            Controls.Add(DisplayBoxRut);
            Controls.Add(DisplayBoxNom);
            Controls.Add(AceptarButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TrabajadorSeleccionado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Trabajador";
            ((System.ComponentModel.ISupportInitialize)FotoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AceptarButton;
        private TextBox DisplayBoxNom;
        private TextBox DisplayBoxRut;
        private TextBox DisplayBoxCargo;
        private TextBox DisplayBoxEmp;
        private TextBox DisplayBoxAño;
        private Label LoadingText;
        private LinkLabel CurriculumLink;
        private PictureBox FotoBox;
        private Button CopyButton;
    }
}