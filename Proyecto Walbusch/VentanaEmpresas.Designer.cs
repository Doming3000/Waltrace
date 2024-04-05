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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(100, 26);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(389, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 360);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // VentanaEmpresas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 453);
            Controls.Add(groupBox1);
            Controls.Add(RegresarButton);
            Controls.Add(label1);
            Controls.Add(EmpresasBox);
            Name = "VentanaEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Empresas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EmpresasBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Button RegresarButton;
        private GroupBox groupBox1;
    }
}