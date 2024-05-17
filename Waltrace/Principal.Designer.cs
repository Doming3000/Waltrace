namespace Waltrace
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pictureBox1 = new PictureBox();
            EmpresaButton = new Button();
            TrabajadorButton = new Button();
            LoginButton = new Button();
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
            EmpresaButton.MouseEnter += Button_MouseEnter;
            EmpresaButton.MouseLeave += Button_MouseLeave;
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
            TrabajadorButton.MouseEnter += Button_MouseEnter;
            TrabajadorButton.MouseLeave += Button_MouseLeave;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(676, 412);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 3;
            LoginButton.TabStop = false;
            LoginButton.Text = "Acceder";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            LoginButton.MouseEnter += Button_MouseEnter;
            LoginButton.MouseLeave += Button_MouseLeave;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(782, 453);
            Controls.Add(LoginButton);
            Controls.Add(TrabajadorButton);
            Controls.Add(EmpresaButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button EmpresaButton;
        private Button TrabajadorButton;
        private PictureBox pictureBox1;
        private Button LoginButton;
    }
}