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
            InsertarEmpleado = new Panel();
            ModificarButton = new Button();
            RegresarButton = new Button();
            label8 = new Label();
            ModificarEmpleado = new Panel();
            AñadirButton = new Button();
            BuscadorEmpleado = new TextBox();
            SearchButton = new Button();
            TrabajadoresList = new CustomListView();
            NombreTrabajador = new ColumnHeader();
            RutTrabajador = new ColumnHeader();
            cargo = new ColumnHeader();
            EmpresaContr = new ColumnHeader();
            InsertarEmpleado.SuspendLayout();
            ModificarEmpleado.SuspendLayout();
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 45);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 0;
            // 
            // ModificarEmpleado
            // 
            ModificarEmpleado.Controls.Add(AñadirButton);
            ModificarEmpleado.Controls.Add(BuscadorEmpleado);
            ModificarEmpleado.Controls.Add(SearchButton);
            ModificarEmpleado.Controls.Add(TrabajadoresList);
            ModificarEmpleado.Controls.Add(label8);
            ModificarEmpleado.Location = new Point(15, 15);
            ModificarEmpleado.Name = "ModificarEmpleado";
            ModificarEmpleado.Size = new Size(580, 400);
            ModificarEmpleado.TabIndex = 15;
            ModificarEmpleado.Visible = false;
            // 
            // AñadirButton
            // 
            AñadirButton.Location = new Point(455, 357);
            AñadirButton.Name = "AñadirButton";
            AñadirButton.Size = new Size(108, 29);
            AñadirButton.TabIndex = 19;
            AñadirButton.Text = "Añadir Datos";
            AñadirButton.UseVisualStyleBackColor = true;
            AñadirButton.Click += AñadirButton_Click;
            AñadirButton.MouseEnter += Button_MouseEnter;
            AñadirButton.MouseLeave += Button_MouseLeave;
            // 
            // BuscadorEmpleado
            // 
            BuscadorEmpleado.Location = new Point(13, 8);
            BuscadorEmpleado.Name = "BuscadorEmpleado";
            BuscadorEmpleado.PlaceholderText = "Ingrese nombre o rut";
            BuscadorEmpleado.Size = new Size(200, 27);
            BuscadorEmpleado.TabIndex = 18;
            BuscadorEmpleado.KeyDown += BuscadorEmpleado_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(219, 8);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 17;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.MouseEnter += Button_MouseEnter;
            SearchButton.MouseLeave += Button_MouseLeave;
            // 
            // TrabajadoresList
            // 
            TrabajadoresList.Columns.AddRange(new ColumnHeader[] { NombreTrabajador, RutTrabajador, cargo, EmpresaContr });
            TrabajadoresList.EmptyText = "";
            TrabajadoresList.FullRowSelect = true;
            TrabajadoresList.IsSearchResultEmpty = false;
            TrabajadoresList.Location = new Point(13, 41);
            TrabajadoresList.Name = "TrabajadoresList";
            TrabajadoresList.NoResultsText = "";
            TrabajadoresList.Size = new Size(550, 220);
            TrabajadoresList.TabIndex = 16;
            TrabajadoresList.TileSize = new Size(1, 1);
            TrabajadoresList.UseCompatibleStateImageBehavior = false;
            TrabajadoresList.View = View.Details;
            // 
            // NombreTrabajador
            // 
            NombreTrabajador.Text = "Nombre Completo";
            NombreTrabajador.Width = 140;
            // 
            // RutTrabajador
            // 
            RutTrabajador.Text = "Rut";
            RutTrabajador.Width = 90;
            // 
            // cargo
            // 
            cargo.Text = "Cargo";
            cargo.Width = 150;
            // 
            // EmpresaContr
            // 
            EmpresaContr.Text = "Empresa Contratante";
            EmpresaContr.Width = 160;
            // 
            // ModificarTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1102, 673);
            Controls.Add(ModificarEmpleado);
            Controls.Add(InsertarEmpleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            InsertarEmpleado.ResumeLayout(false);
            InsertarEmpleado.PerformLayout();
            ModificarEmpleado.ResumeLayout(false);
            ModificarEmpleado.PerformLayout();
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
        private Panel InsertarEmpleado;
        private Button RegresarButton;
        private Button ModificarButton;
        private Label label8;
        private Panel ModificarEmpleado;
        private CustomListView TrabajadoresList;
        private ColumnHeader NombreTrabajador;
        private ColumnHeader RutTrabajador;
        private ColumnHeader cargo;
        private ColumnHeader EmpresaContr;
        private TextBox BuscadorEmpleado;
        private Button SearchButton;
        private Button AñadirButton;
    }
}