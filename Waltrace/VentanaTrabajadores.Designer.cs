namespace Waltrace
{
    partial class VentanaTrabajadores
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
            bindingSource1 = new BindingSource(components);
            SearchButton = new Button();
            RegresarButton = new Button();
            BuscadorEmpleado = new TextBox();
            TrabajadoresList = new ListView();
            NombreTrabajador = new ColumnHeader();
            RutTrabajador = new ColumnHeader();
            EmpresaContr = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(239, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(676, 412);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 2;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            // 
            // BuscadorEmpleado
            // 
            BuscadorEmpleado.Location = new Point(12, 14);
            BuscadorEmpleado.Name = "BuscadorEmpleado";
            BuscadorEmpleado.Size = new Size(221, 27);
            BuscadorEmpleado.TabIndex = 14;
            BuscadorEmpleado.Enter += BuscadorEmpleado_Enter;
            BuscadorEmpleado.Leave += BuscadorEmpleado_Leave;
            // 
            // TrabajadoresList
            // 
            TrabajadoresList.Columns.AddRange(new ColumnHeader[] { NombreTrabajador, RutTrabajador, EmpresaContr });
            TrabajadoresList.Location = new Point(12, 63);
            TrabajadoresList.Name = "TrabajadoresList";
            TrabajadoresList.Size = new Size(394, 121);
            TrabajadoresList.TabIndex = 15;
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
            // EmpresaContr
            // 
            EmpresaContr.Text = "Empresa Contratante";
            EmpresaContr.Width = 160;
            // 
            // VentanaTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(TrabajadoresList);
            Controls.Add(BuscadorEmpleado);
            Controls.Add(RegresarButton);
            Controls.Add(SearchButton);
            Name = "VentanaTrabajadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Trabajadores";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private Button SearchButton;
        private Button RegresarButton;
        private TextBox BuscadorEmpleado;
        private ListView TrabajadoresList;
        private ColumnHeader NombreTrabajador;
        private ColumnHeader RutTrabajador;
        private ColumnHeader EmpresaContr;
    }
}