namespace Waltrace
{
    partial class VentanaEmpresas
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
            EmpresasBox = new ComboBox();
            label1 = new Label();
            RegresarButton = new Button();
            GroupBox1 = new GroupBox();
            LoadingText = new Label();
            DisplayBoxDir = new TextBox();
            DocsButton = new Button();
            LogoBox = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            DisplayBoxAño = new TextBox();
            DisplayBoxTel = new TextBox();
            DisplayBoxRut = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DisplayBoxRep = new TextBox();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // EmpresasBox
            // 
            EmpresasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpresasBox.FormattingEnabled = true;
            EmpresasBox.Location = new Point(26, 52);
            EmpresasBox.Name = "EmpresasBox";
            EmpresasBox.Size = new Size(230, 28);
            EmpresasBox.TabIndex = 1;
            EmpresasBox.SelectedIndexChanged += EmpresasBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione empresa:";
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(676, 412);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 8;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += RegresarButton_MouseEnter;
            RegresarButton.MouseLeave += RegresarButton_MouseLeave;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(LoadingText);
            GroupBox1.Controls.Add(DisplayBoxDir);
            GroupBox1.Controls.Add(DocsButton);
            GroupBox1.Controls.Add(LogoBox);
            GroupBox1.Controls.Add(label6);
            GroupBox1.Controls.Add(label5);
            GroupBox1.Controls.Add(label4);
            GroupBox1.Controls.Add(DisplayBoxAño);
            GroupBox1.Controls.Add(DisplayBoxTel);
            GroupBox1.Controls.Add(DisplayBoxRut);
            GroupBox1.Controls.Add(label3);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(DisplayBoxRep);
            GroupBox1.Enabled = false;
            GroupBox1.Location = new Point(26, 121);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(744, 285);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Location = new Point(513, 15);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(145, 20);
            LoadingText.TabIndex = 9;
            LoadingText.Text = "Cargando logotipo...";
            LoadingText.Visible = false;
            // 
            // DisplayBoxDir
            // 
            DisplayBoxDir.Location = new Point(167, 108);
            DisplayBoxDir.Name = "DisplayBoxDir";
            DisplayBoxDir.ReadOnly = true;
            DisplayBoxDir.Size = new Size(160, 27);
            DisplayBoxDir.TabIndex = 4;
            // 
            // DocsButton
            // 
            DocsButton.Location = new Point(167, 207);
            DocsButton.Name = "DocsButton";
            DocsButton.Size = new Size(160, 29);
            DocsButton.TabIndex = 7;
            DocsButton.Text = "Documentación legal ";
            DocsButton.UseVisualStyleBackColor = true;
            DocsButton.Click += DocsButton_Click;
            DocsButton.MouseEnter += DocsButton_MouseEnter;
            DocsButton.MouseLeave += DocsButton_MouseLeave;
            // 
            // LogoBox
            // 
            LogoBox.Location = new Point(513, 38);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(207, 163);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 8;
            LogoBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 177);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 11;
            label6.Text = "Año de constitución:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 144);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 111);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Dirección:";
            // 
            // DisplayBoxAño
            // 
            DisplayBoxAño.Location = new Point(167, 174);
            DisplayBoxAño.Name = "DisplayBoxAño";
            DisplayBoxAño.ReadOnly = true;
            DisplayBoxAño.Size = new Size(160, 27);
            DisplayBoxAño.TabIndex = 6;
            // 
            // DisplayBoxTel
            // 
            DisplayBoxTel.Location = new Point(167, 141);
            DisplayBoxTel.Name = "DisplayBoxTel";
            DisplayBoxTel.ReadOnly = true;
            DisplayBoxTel.Size = new Size(160, 27);
            DisplayBoxTel.TabIndex = 5;
            // 
            // DisplayBoxRut
            // 
            DisplayBoxRut.Location = new Point(167, 75);
            DisplayBoxRut.Name = "DisplayBoxRut";
            DisplayBoxRut.ReadOnly = true;
            DisplayBoxRut.Size = new Size(160, 27);
            DisplayBoxRut.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 78);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Rut de empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 41);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Representante legal:";
            // 
            // DisplayBoxRep
            // 
            DisplayBoxRep.Location = new Point(167, 38);
            DisplayBoxRep.Name = "DisplayBoxRep";
            DisplayBoxRep.ReadOnly = true;
            DisplayBoxRep.Size = new Size(160, 27);
            DisplayBoxRep.TabIndex = 2;
            // 
            // VentanaEmpresas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 453);
            Controls.Add(GroupBox1);
            Controls.Add(RegresarButton);
            Controls.Add(label1);
            Controls.Add(EmpresasBox);
            MaximizeBox = false;
            Name = "VentanaEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Empresas";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EmpresasBox;
        private Label label1;
        private Button RegresarButton;
        private GroupBox GroupBox1;
        private Label label2;
        private TextBox DisplayBoxRep;
        private TextBox DisplayBoxRut;
        private Label label3;
        private TextBox DisplayBoxAño;
        private TextBox DisplayBoxTel;
        private Label label4;
        private Label label6;
        private Label label5;
        private PictureBox LogoBox;
        private Button DocsButton;
        private TextBox DisplayBoxDir;
        private Label LoadingText;
    }
}