namespace Waltrace
{
    partial class Empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresas));
            EmpresasBox = new ComboBox();
            label1 = new Label();
            RegresarButton = new Button();
            DatosEmpresa = new GroupBox();
            CopyButton = new Button();
            DisplayBoxDir = new TextBox();
            DocsButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            DisplayBoxAño = new TextBox();
            DisplayBoxTel = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DisplayBoxRut = new TextBox();
            DisplayBoxRep = new TextBox();
            LoadingText = new Label();
            LogoBox = new PictureBox();
            FlotaButton = new Button();
            WalbuschPanel = new Panel();
            WaltechPanel = new Panel();
            label9 = new Label();
            button3 = new Button();
            label7 = new Label();
            button1 = new Button();
            MCAPanel = new Panel();
            label8 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            DatosEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            WalbuschPanel.SuspendLayout();
            WaltechPanel.SuspendLayout();
            MCAPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EmpresasBox
            // 
            EmpresasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpresasBox.FormattingEnabled = true;
            EmpresasBox.Location = new Point(25, 105);
            EmpresasBox.Name = "EmpresasBox";
            EmpresasBox.Size = new Size(230, 28);
            EmpresasBox.TabIndex = 1;
            EmpresasBox.SelectedIndexChanged += EmpresasBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 82);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione empresa:";
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(996, 632);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 9;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += Button_MouseEnter;
            RegresarButton.MouseLeave += Button_MouseLeave;
            // 
            // DatosEmpresa
            // 
            DatosEmpresa.Controls.Add(CopyButton);
            DatosEmpresa.Controls.Add(DisplayBoxDir);
            DatosEmpresa.Controls.Add(DocsButton);
            DatosEmpresa.Controls.Add(label6);
            DatosEmpresa.Controls.Add(label5);
            DatosEmpresa.Controls.Add(label4);
            DatosEmpresa.Controls.Add(DisplayBoxAño);
            DatosEmpresa.Controls.Add(DisplayBoxTel);
            DatosEmpresa.Controls.Add(label3);
            DatosEmpresa.Controls.Add(label2);
            DatosEmpresa.Controls.Add(DisplayBoxRut);
            DatosEmpresa.Controls.Add(DisplayBoxRep);
            DatosEmpresa.Enabled = false;
            DatosEmpresa.Location = new Point(25, 150);
            DatosEmpresa.Name = "DatosEmpresa";
            DatosEmpresa.Size = new Size(354, 303);
            DatosEmpresa.TabIndex = 6;
            DatosEmpresa.TabStop = false;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(141, 249);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(169, 29);
            CopyButton.TabIndex = 8;
            CopyButton.Text = "Copiar al portapapeles";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            CopyButton.MouseEnter += Button_MouseEnter;
            CopyButton.MouseLeave += Button_MouseLeave;
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
            DocsButton.BackgroundImageLayout = ImageLayout.None;
            DocsButton.ImageAlign = ContentAlignment.MiddleLeft;
            DocsButton.Location = new Point(167, 207);
            DocsButton.Name = "DocsButton";
            DocsButton.Size = new Size(160, 29);
            DocsButton.TabIndex = 7;
            DocsButton.Text = "Documentación legal ";
            DocsButton.UseVisualStyleBackColor = true;
            DocsButton.Click += DocsButton_Click;
            DocsButton.MouseEnter += Button_MouseEnter;
            DocsButton.MouseLeave += Button_MouseLeave;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 74);
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
            // DisplayBoxRut
            // 
            DisplayBoxRut.Location = new Point(167, 71);
            DisplayBoxRut.Name = "DisplayBoxRut";
            DisplayBoxRut.ReadOnly = true;
            DisplayBoxRut.Size = new Size(160, 27);
            DisplayBoxRut.TabIndex = 3;
            // 
            // DisplayBoxRep
            // 
            DisplayBoxRep.Location = new Point(167, 38);
            DisplayBoxRep.Name = "DisplayBoxRep";
            DisplayBoxRep.ReadOnly = true;
            DisplayBoxRep.Size = new Size(160, 27);
            DisplayBoxRep.TabIndex = 2;
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Location = new Point(890, 285);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(145, 20);
            LoadingText.TabIndex = 9;
            LoadingText.Text = "Cargando logotipo...";
            LoadingText.Visible = false;
            // 
            // LogoBox
            // 
            LogoBox.Location = new Point(890, 82);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(200, 200);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 8;
            LogoBox.TabStop = false;
            // 
            // FlotaButton
            // 
            FlotaButton.Location = new Point(267, 159);
            FlotaButton.Name = "FlotaButton";
            FlotaButton.Size = new Size(94, 29);
            FlotaButton.TabIndex = 10;
            FlotaButton.Text = "Flota";
            FlotaButton.UseVisualStyleBackColor = true;
            // 
            // WalbuschPanel
            // 
            WalbuschPanel.Controls.Add(WaltechPanel);
            WalbuschPanel.Controls.Add(label7);
            WalbuschPanel.Controls.Add(button1);
            WalbuschPanel.Controls.Add(FlotaButton);
            WalbuschPanel.Location = new Point(454, 105);
            WalbuschPanel.Name = "WalbuschPanel";
            WalbuschPanel.Size = new Size(375, 202);
            WalbuschPanel.TabIndex = 12;
            WalbuschPanel.Visible = false;
            // 
            // WaltechPanel
            // 
            WaltechPanel.Controls.Add(label9);
            WaltechPanel.Controls.Add(button3);
            WaltechPanel.Location = new Point(0, 40);
            WaltechPanel.Name = "WaltechPanel";
            WaltechPanel.Size = new Size(375, 202);
            WaltechPanel.TabIndex = 14;
            WaltechPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 15);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 12;
            label9.Text = "Panel Waltech";
            // 
            // button3
            // 
            button3.Location = new Point(258, 160);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 11;
            button3.Text = "Organigrama";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 15);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 12;
            label7.Text = "Panel Walbusch Sa";
            // 
            // button1
            // 
            button1.Location = new Point(156, 159);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 11;
            button1.Text = "Organigrama";
            button1.UseVisualStyleBackColor = true;
            // 
            // MCAPanel
            // 
            MCAPanel.Controls.Add(label8);
            MCAPanel.Controls.Add(button2);
            MCAPanel.Location = new Point(454, 191);
            MCAPanel.Name = "MCAPanel";
            MCAPanel.Size = new Size(375, 202);
            MCAPanel.TabIndex = 13;
            MCAPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 15);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 12;
            label8.Text = "Panel MCA SA";
            // 
            // button2
            // 
            button2.Location = new Point(258, 160);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 11;
            button2.Text = "Organigrama";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 44);
            panel1.TabIndex = 14;
            // 
            // Empresas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1102, 673);
            Controls.Add(panel1);
            Controls.Add(MCAPanel);
            Controls.Add(WalbuschPanel);
            Controls.Add(LoadingText);
            Controls.Add(DatosEmpresa);
            Controls.Add(RegresarButton);
            Controls.Add(label1);
            Controls.Add(LogoBox);
            Controls.Add(EmpresasBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Empresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Empresas";
            DatosEmpresa.ResumeLayout(false);
            DatosEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            WalbuschPanel.ResumeLayout(false);
            WalbuschPanel.PerformLayout();
            WaltechPanel.ResumeLayout(false);
            WaltechPanel.PerformLayout();
            MCAPanel.ResumeLayout(false);
            MCAPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EmpresasBox;
        private Label label1;
        private Button RegresarButton;
        private GroupBox DatosEmpresa;
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
        private Button FlotaButton;
        private Panel WalbuschPanel;
        private Button button1;
        private Label label7;
        private Panel MCAPanel;
        private Label label8;
        private Button button2;
        private Panel WaltechPanel;
        private Label label9;
        private Button button3;
        private Button CopyButton;
        private Panel panel1;
    }
}