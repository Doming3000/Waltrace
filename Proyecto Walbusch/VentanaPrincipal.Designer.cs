namespace Proyecto_Walbusch
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            pictureBox1 = new PictureBox();
            EmpresaButton = new Button();
            TrabajadorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(292, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EmpresaButton
            // 
            EmpresaButton.Location = new Point(193, 249);
            EmpresaButton.Name = "EmpresaButton";
            EmpresaButton.Size = new Size(180, 30);
            EmpresaButton.TabIndex = 1;
            EmpresaButton.Text = "Consultar por empresa";
            EmpresaButton.UseVisualStyleBackColor = true;
            EmpresaButton.Click += EmpresaButton_Click;
            EmpresaButton.MouseEnter += EmpresaButton_MouseEnter;
            EmpresaButton.MouseLeave += EmpresaButton_MouseLeave;
            // 
            // TrabajadorButton
            // 
            TrabajadorButton.Location = new Point(409, 249);
            TrabajadorButton.Name = "TrabajadorButton";
            TrabajadorButton.Size = new Size(180, 30);
            TrabajadorButton.TabIndex = 2;
            TrabajadorButton.Text = "Consultar por trabajador";
            TrabajadorButton.UseVisualStyleBackColor = true;
            TrabajadorButton.Click += TrabajadorButton_Click;
            TrabajadorButton.MouseEnter += TrabajadorButton_MouseEnter;
            TrabajadorButton.MouseLeave += TrabajadorButton_MouseLeave;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 453);
            Controls.Add(TrabajadorButton);
            Controls.Add(EmpresaButton);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Walbusch";
            Load += VentanaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button EmpresaButton;
        private Button TrabajadorButton;
    }
}