namespace Waltrace
{
    partial class ModificarTrabajador
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
            TextBoxNom = new TextBox();
            TextBoxRut = new TextBox();
            TextBoxCargo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ComboBoxEmp = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            TextBoxFetch = new TextBox();
            TextBoxCurr = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TextBoxFoto = new TextBox();
            CargarButton = new Button();
            SuspendLayout();
            // 
            // TextBoxNom
            // 
            TextBoxNom.Location = new Point(25, 48);
            TextBoxNom.MaxLength = 50;
            TextBoxNom.Name = "TextBoxNom";
            TextBoxNom.Size = new Size(247, 27);
            TextBoxNom.TabIndex = 1;
            // 
            // TextBoxRut
            // 
            TextBoxRut.Location = new Point(25, 101);
            TextBoxRut.MaxLength = 10;
            TextBoxRut.Name = "TextBoxRut";
            TextBoxRut.Size = new Size(125, 27);
            TextBoxRut.TabIndex = 2;
            // 
            // TextBoxCargo
            // 
            TextBoxCargo.Location = new Point(25, 154);
            TextBoxCargo.MaxLength = 30;
            TextBoxCargo.Name = "TextBoxCargo";
            TextBoxCargo.Size = new Size(151, 27);
            TextBoxCargo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 78);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 4;
            label2.Text = "Rut (sin puntos con guión)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Cargo";
            // 
            // ComboBoxEmp
            // 
            ComboBoxEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEmp.FormattingEnabled = true;
            ComboBoxEmp.Location = new Point(25, 207);
            ComboBoxEmp.Name = "ComboBoxEmp";
            ComboBoxEmp.Size = new Size(151, 28);
            ComboBoxEmp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 184);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 7;
            label4.Text = "Empresa contratante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 238);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha de inicio (dd-mm-yyyy)";
            // 
            // TextBoxFetch
            // 
            TextBoxFetch.Location = new Point(25, 261);
            TextBoxFetch.MaxLength = 10;
            TextBoxFetch.Name = "TextBoxFetch";
            TextBoxFetch.Size = new Size(125, 27);
            TextBoxFetch.TabIndex = 5;
            // 
            // TextBoxCurr
            // 
            TextBoxCurr.Location = new Point(25, 314);
            TextBoxCurr.Name = "TextBoxCurr";
            TextBoxCurr.Size = new Size(125, 27);
            TextBoxCurr.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 291);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 11;
            label6.Text = "URL del currículum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 353);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 12;
            label7.Text = "URL de la foto (opcional)";
            // 
            // TextBoxFoto
            // 
            TextBoxFoto.Location = new Point(25, 376);
            TextBoxFoto.Name = "TextBoxFoto";
            TextBoxFoto.Size = new Size(125, 27);
            TextBoxFoto.TabIndex = 7;
            // 
            // CargarButton
            // 
            CargarButton.Location = new Point(666, 405);
            CargarButton.Name = "CargarButton";
            CargarButton.Size = new Size(109, 29);
            CargarButton.TabIndex = 8;
            CargarButton.Text = "Cargar Datos";
            CargarButton.UseVisualStyleBackColor = true;
            CargarButton.Click += CargarButton_Click;
            // 
            // ModificarTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CargarButton);
            Controls.Add(TextBoxFoto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBoxCurr);
            Controls.Add(TextBoxFetch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ComboBoxEmp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxCargo);
            Controls.Add(TextBoxRut);
            Controls.Add(TextBoxNom);
            Name = "ModificarTrabajador";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNom;
        private TextBox TextBoxRut;
        private TextBox TextBoxCargo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ComboBoxEmp;
        private Label label4;
        private Label label5;
        private TextBox TextBoxFetch;
        private TextBox TextBoxCurr;
        private Label label6;
        private Label label7;
        private TextBox TextBoxFoto;
        private Button CargarButton;
    }
}