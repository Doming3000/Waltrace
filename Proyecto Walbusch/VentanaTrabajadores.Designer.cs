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
            BuscadorEmpleado = new TextBox();
            SearchButton = new Button();
            RegresarButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BuscadorEmpleado
            // 
            BuscadorEmpleado.Location = new Point(12, 21);
            BuscadorEmpleado.Name = "BuscadorEmpleado";
            BuscadorEmpleado.Size = new Size(220, 27);
            BuscadorEmpleado.TabIndex = 1;
            BuscadorEmpleado.TextChanged += BuscadorEmpleado_TextChanged;
            BuscadorEmpleado.Enter += BuscadorEmpleado_Enter;
            BuscadorEmpleado.Leave += BuscadorEmpleado_Leave;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(238, 21);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // RegresarButton
            // 
            RegresarButton.Location = new Point(576, 412);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 2;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(320, 320);
            dataGridView1.TabIndex = 3;
            // 
            // VentanaTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dataGridView1);
            Controls.Add(RegresarButton);
            Controls.Add(SearchButton);
            Controls.Add(BuscadorEmpleado);
            Name = "VentanaTrabajadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waltrace - Trabajadores";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private TextBox BuscadorEmpleado;
        private Button SearchButton;
        private Button RegresarButton;
        private DataGridView dataGridView1;
    }
}