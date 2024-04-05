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
            label2 = new Label();
            DisplayBoxRep = new TextBox();
            label3 = new Label();
            DisplayBoxRut = new TextBox();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EmpresasBox
            // 
            EmpresasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpresasBox.FormattingEnabled = true;
            EmpresasBox.Location = new Point(26, 52);
            EmpresasBox.Name = "EmpresasBox";
            EmpresasBox.Size = new Size(230, 28);
            EmpresasBox.TabIndex = 0;
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
            RegresarButton.TabIndex = 3;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += RegresarButton_MouseEnter;
            RegresarButton.MouseLeave += RegresarButton_MouseLeave;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(DisplayBoxRut);
            GroupBox1.Controls.Add(label3);
            GroupBox1.Controls.Add(label2);
            GroupBox1.Controls.Add(DisplayBoxRep);
            GroupBox1.Enabled = false;
            GroupBox1.Location = new Point(26, 121);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(320, 125);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
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
            DisplayBoxRep.Size = new Size(125, 27);
            DisplayBoxRep.TabIndex = 0;
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
            // DisplayBoxRut
            // 
            DisplayBoxRut.Location = new Point(167, 75);
            DisplayBoxRut.Name = "DisplayBoxRut";
            DisplayBoxRut.ReadOnly = true;
            DisplayBoxRut.Size = new Size(125, 27);
            DisplayBoxRut.TabIndex = 3;
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
            Name = "VentanaEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Empresas";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
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
    }
}