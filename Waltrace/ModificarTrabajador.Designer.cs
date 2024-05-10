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
            TextBoxCurr = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TextBoxFoto = new TextBox();
            CargarButton = new Button();
            DateTimeP = new DateTimePicker();
            InsertarTrabajador = new Panel();
            RegresarButton = new Button();
            InsertarTrabajador.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxNom
            // 
            TextBoxNom.Location = new Point(15, 38);
            TextBoxNom.MaxLength = 50;
            TextBoxNom.Name = "TextBoxNom";
            TextBoxNom.Size = new Size(227, 27);
            TextBoxNom.TabIndex = 1;
            // 
            // TextBoxRut
            // 
            TextBoxRut.Location = new Point(15, 91);
            TextBoxRut.MaxLength = 10;
            TextBoxRut.Name = "TextBoxRut";
            TextBoxRut.Size = new Size(227, 27);
            TextBoxRut.TabIndex = 2;
            TextBoxRut.KeyPress += TextBoxRut_KeyPress;
            // 
            // TextBoxCargo
            // 
            TextBoxCargo.Location = new Point(15, 144);
            TextBoxCargo.MaxLength = 30;
            TextBoxCargo.Name = "TextBoxCargo";
            TextBoxCargo.Size = new Size(227, 27);
            TextBoxCargo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 4;
            label2.Text = "Rut (sin puntos con guión)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 121);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Cargo";
            // 
            // ComboBoxEmp
            // 
            ComboBoxEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEmp.FormattingEnabled = true;
            ComboBoxEmp.Location = new Point(15, 197);
            ComboBoxEmp.Name = "ComboBoxEmp";
            ComboBoxEmp.Size = new Size(227, 28);
            ComboBoxEmp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 174);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 7;
            label4.Text = "Empresa contratante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 228);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha de inicio";
            // 
            // TextBoxCurr
            // 
            TextBoxCurr.Location = new Point(15, 304);
            TextBoxCurr.Name = "TextBoxCurr";
            TextBoxCurr.Size = new Size(227, 27);
            TextBoxCurr.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 281);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 11;
            label6.Text = "URL del currículum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 334);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 12;
            label7.Text = "URL de la foto (opcional)";
            // 
            // TextBoxFoto
            // 
            TextBoxFoto.Location = new Point(15, 357);
            TextBoxFoto.Name = "TextBoxFoto";
            TextBoxFoto.Size = new Size(227, 27);
            TextBoxFoto.TabIndex = 7;
            // 
            // CargarButton
            // 
            CargarButton.Location = new Point(379, 356);
            CargarButton.Name = "CargarButton";
            CargarButton.Size = new Size(109, 29);
            CargarButton.TabIndex = 9;
            CargarButton.Text = "Cargar Datos";
            CargarButton.UseVisualStyleBackColor = true;
            CargarButton.Click += CargarButton_Click;
            CargarButton.MouseEnter += Button_MouseEnter;
            CargarButton.MouseLeave += Button_MouseLeave;
            // 
            // DateTimeP
            // 
            DateTimeP.Format = DateTimePickerFormat.Short;
            DateTimeP.Location = new Point(15, 251);
            DateTimeP.Name = "DateTimeP";
            DateTimeP.Size = new Size(121, 27);
            DateTimeP.TabIndex = 5;
            DateTimeP.Value = new DateTime(2024, 5, 8, 7, 57, 47, 0);
            // 
            // InsertarTrabajador
            // 
            InsertarTrabajador.Controls.Add(RegresarButton);
            InsertarTrabajador.Controls.Add(CargarButton);
            InsertarTrabajador.Controls.Add(TextBoxFoto);
            InsertarTrabajador.Controls.Add(DateTimeP);
            InsertarTrabajador.Controls.Add(label7);
            InsertarTrabajador.Controls.Add(label1);
            InsertarTrabajador.Controls.Add(TextBoxCurr);
            InsertarTrabajador.Controls.Add(label6);
            InsertarTrabajador.Controls.Add(TextBoxNom);
            InsertarTrabajador.Controls.Add(label2);
            InsertarTrabajador.Controls.Add(TextBoxRut);
            InsertarTrabajador.Controls.Add(label3);
            InsertarTrabajador.Controls.Add(label5);
            InsertarTrabajador.Controls.Add(TextBoxCargo);
            InsertarTrabajador.Controls.Add(ComboBoxEmp);
            InsertarTrabajador.Controls.Add(label4);
            InsertarTrabajador.Location = new Point(15, 15);
            InsertarTrabajador.Name = "InsertarTrabajador";
            InsertarTrabajador.Size = new Size(500, 400);
            InsertarTrabajador.TabIndex = 14;
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(279, 356);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 8;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += Button_MouseEnter;
            RegresarButton.MouseLeave += Button_MouseLeave;
            // 
            // ModificarTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1102, 673);
            Controls.Add(InsertarTrabajador);
            Name = "ModificarTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            InsertarTrabajador.ResumeLayout(false);
            InsertarTrabajador.PerformLayout();
            ResumeLayout(false);
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
        private TextBox TextBoxCurr;
        private Label label6;
        private Label label7;
        private TextBox TextBoxFoto;
        private Button CargarButton;
        private DateTimePicker DateTimeP;
        private Panel InsertarTrabajador;
        private Button RegresarButton;
    }
}