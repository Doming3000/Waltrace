namespace Proyecto_Walbusch
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
            pictureBox1 = new PictureBox();
            RegresarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EmpresasBox
            // 
            EmpresasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpresasBox.FormattingEnabled = true;
            EmpresasBox.Items.AddRange(new object[] { "Empresa 1", "Empresa 2", "Empresa 3", "Empresa 4", "Empresa 5", "Empresa 6", "Empresa 7", "Empresa 8", "Empresa 9" });
            EmpresasBox.Location = new Point(46, 63);
            EmpresasBox.Name = "EmpresasBox";
            EmpresasBox.Size = new Size(161, 28);
            EmpresasBox.TabIndex = 0;
            EmpresasBox.SelectedIndexChanged += EmpresasBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione empresa:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(560, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            // VentanaEmpresas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 453);
            Controls.Add(RegresarButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(EmpresasBox);
            Name = "VentanaEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EmpresasBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Button RegresarButton;
    }
}