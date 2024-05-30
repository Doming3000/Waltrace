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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTrabajador));
            label4 = new Label();
            ComboBoxEmp = new ComboBox();
            TextBoxCargo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            TextBoxRut = new TextBox();
            label2 = new Label();
            TextBoxNom = new TextBox();
            label6 = new Label();
            TextBoxCurr = new TextBox();
            label1 = new Label();
            label7 = new Label();
            DateTimeP = new DateTimePicker();
            TextBoxFoto = new TextBox();
            CargarButton = new Button();
            RegresarButton = new Button();
            ModificarButton = new Button();
            InsertarEmpleado = new Panel();
            InsertarEmpleado.SuspendLayout();
            SuspendLayout();
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
            // ComboBoxEmp
            // 
            ComboBoxEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEmp.FormattingEnabled = true;
            ComboBoxEmp.Location = new Point(15, 197);
            ComboBoxEmp.Name = "ComboBoxEmp";
            ComboBoxEmp.Size = new Size(227, 28);
            ComboBoxEmp.TabIndex = 4;
            // 
            // TextBoxCargo
            // 
            TextBoxCargo.Location = new Point(15, 144);
            TextBoxCargo.MaxLength = 30;
            TextBoxCargo.Name = "TextBoxCargo";
            TextBoxCargo.Size = new Size(227, 27);
            TextBoxCargo.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 121);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Cargo";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 4;
            label2.Text = "Rut (sin puntos con guión)";
            // 
            // TextBoxNom
            // 
            TextBoxNom.Location = new Point(15, 38);
            TextBoxNom.MaxLength = 50;
            TextBoxNom.Name = "TextBoxNom";
            TextBoxNom.Size = new Size(227, 27);
            TextBoxNom.TabIndex = 1;
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
            // TextBoxCurr
            // 
            TextBoxCurr.Location = new Point(15, 304);
            TextBoxCurr.Name = "TextBoxCurr";
            TextBoxCurr.Size = new Size(227, 27);
            TextBoxCurr.TabIndex = 6;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 334);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 12;
            label7.Text = "URL de la foto (opcional)";
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
            // ModificarButton
            // 
            ModificarButton.Location = new Point(364, 15);
            ModificarButton.Name = "ModificarButton";
            ModificarButton.Size = new Size(124, 29);
            ModificarButton.TabIndex = 13;
            ModificarButton.Text = "Modificar Datos";
            ModificarButton.UseVisualStyleBackColor = true;
            ModificarButton.Click += ModificarButton_Click;
            ModificarButton.MouseEnter += Button_MouseEnter;
            ModificarButton.MouseLeave += Button_MouseLeave;
            // 
            // InsertarEmpleado
            // 
            InsertarEmpleado.Controls.Add(ModificarButton);
            InsertarEmpleado.Controls.Add(RegresarButton);
            InsertarEmpleado.Controls.Add(CargarButton);
            InsertarEmpleado.Controls.Add(TextBoxFoto);
            InsertarEmpleado.Controls.Add(DateTimeP);
            InsertarEmpleado.Controls.Add(label7);
            InsertarEmpleado.Controls.Add(label1);
            InsertarEmpleado.Controls.Add(TextBoxCurr);
            InsertarEmpleado.Controls.Add(label6);
            InsertarEmpleado.Controls.Add(TextBoxNom);
            InsertarEmpleado.Controls.Add(label2);
            InsertarEmpleado.Controls.Add(TextBoxRut);
            InsertarEmpleado.Controls.Add(label3);
            InsertarEmpleado.Controls.Add(label5);
            InsertarEmpleado.Controls.Add(TextBoxCargo);
            InsertarEmpleado.Controls.Add(ComboBoxEmp);
            InsertarEmpleado.Controls.Add(label4);
            InsertarEmpleado.Location = new Point(15, 15);
            InsertarEmpleado.Name = "InsertarEmpleado";
            InsertarEmpleado.Size = new Size(500, 400);
            InsertarEmpleado.TabIndex = 14;
            // 
            // ModificarTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1102, 673);
            Controls.Add(InsertarEmpleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            InsertarEmpleado.ResumeLayout(false);
            InsertarEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private ComboBox ComboBoxEmp;
        private TextBox TextBoxCargo;
        private Label label5;
        private Label label3;
        private TextBox TextBoxRut;
        private Label label2;
        private TextBox TextBoxNom;
        private Label label6;
        private TextBox TextBoxCurr;
        private Label label1;
        private Label label7;
        private DateTimePicker DateTimeP;
        private TextBox TextBoxFoto;
        private Button CargarButton;
        private Button RegresarButton;
        private Button ModificarButton;
        private Panel InsertarEmpleado;
    }
}