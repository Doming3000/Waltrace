namespace Waltrace
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            TextboxUser = new TextBox();
            TextboxPass = new TextBox();
            Acceder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // TextboxUser
            // 
            TextboxUser.Location = new Point(126, 48);
            TextboxUser.MaxLength = 30;
            TextboxUser.Name = "TextboxUser";
            TextboxUser.Size = new Size(170, 27);
            TextboxUser.TabIndex = 2;
            // 
            // TextboxPass
            // 
            TextboxPass.Location = new Point(126, 80);
            TextboxPass.MaxLength = 30;
            TextboxPass.Name = "TextboxPass";
            TextboxPass.Size = new Size(170, 27);
            TextboxPass.TabIndex = 3;
            TextboxPass.UseSystemPasswordChar = true;
            // 
            // Acceder
            // 
            Acceder.Location = new Point(231, 137);
            Acceder.Name = "Acceder";
            Acceder.Size = new Size(94, 29);
            Acceder.TabIndex = 4;
            Acceder.Text = "Acceder";
            Acceder.UseVisualStyleBackColor = true;
            Acceder.Click += Acceder_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(342, 193);
            Controls.Add(Acceder);
            Controls.Add(TextboxPass);
            Controls.Add(TextboxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextboxUser;
        private TextBox TextboxPass;
        private Button Acceder;
    }
}