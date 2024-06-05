namespace Waltrace
{
    partial class Trabajadores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabajadores));
            bindingSource1 = new BindingSource(components);
            SearchButton = new Button();
            RegresarButton = new Button();
            TrabajadoresList = new CustomListView();
            NombreTrabajador = new ColumnHeader();
            RutTrabajador = new ColumnHeader();
            cargo = new ColumnHeader();
            EmpresaContr = new ColumnHeader();
            BuscadorEmpleado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(218, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.MouseEnter += Button_MouseEnter;
            SearchButton.MouseLeave += Button_MouseLeave;
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(996, 632);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 2;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            RegresarButton.MouseEnter += Button_MouseEnter;
            RegresarButton.MouseLeave += Button_MouseLeave;
            // 
            // TrabajadoresList
            // 
            TrabajadoresList.Columns.AddRange(new ColumnHeader[] { NombreTrabajador, RutTrabajador, cargo, EmpresaContr });
            TrabajadoresList.EmptyText = "";
            TrabajadoresList.FullRowSelect = true;
            TrabajadoresList.IsSearchResultEmpty = false;
            TrabajadoresList.Location = new Point(12, 47);
            TrabajadoresList.Name = "TrabajadoresList";
            TrabajadoresList.NoResultsText = "";
            TrabajadoresList.Size = new Size(550, 220);
            TrabajadoresList.TabIndex = 15;
            TrabajadoresList.TileSize = new Size(1, 1);
            TrabajadoresList.UseCompatibleStateImageBehavior = false;
            TrabajadoresList.View = View.Details;
            TrabajadoresList.ItemActivate += TrabajadoresList_ItemActivate;
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
            // BuscadorEmpleado
            // 
            BuscadorEmpleado.Location = new Point(12, 12);
            BuscadorEmpleado.Name = "BuscadorEmpleado";
            BuscadorEmpleado.PlaceholderText = "Ingrese nombre o rut";
            BuscadorEmpleado.Size = new Size(200, 27);
            BuscadorEmpleado.TabIndex = 16;
            BuscadorEmpleado.KeyDown += BuscadorEmpleado_KeyDown;
            // 
            // Trabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 673);
            Controls.Add(BuscadorEmpleado);
            Controls.Add(TrabajadoresList);
            Controls.Add(RegresarButton);
            Controls.Add(SearchButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Trabajadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Trabajadores";
            FormClosing += Trabajadores_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private Button SearchButton;
        private Button RegresarButton;
        private CustomListView TrabajadoresList;
        private ColumnHeader NombreTrabajador;
        private ColumnHeader RutTrabajador;
        private ColumnHeader EmpresaContr;
        private ColumnHeader cargo;
        private TextBox BuscadorEmpleado;
    }
}