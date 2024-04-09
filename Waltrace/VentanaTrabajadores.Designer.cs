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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            BuscadorEmpleado = new TextBox();
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
            RegresarButton.Location = new Point(576, 412);
            RegresarButton.Name = "RegresarButton";
            RegresarButton.Size = new Size(94, 29);
            RegresarButton.TabIndex = 2;
            RegresarButton.Text = "Regresar";
            RegresarButton.UseVisualStyleBackColor = true;
            RegresarButton.Click += RegresarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 274);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 307);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 5;
            label2.Text = "Rut:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 340);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 6;
            label3.Text = "Empresa contratante:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 373);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha inicio:";
            label4.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(180, 414);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 8;
            button1.Text = "Descargar Currículum";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(218, 337);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            textBox4.Visible = false;
            // 
            // BuscadorEmpleado
            // 
            BuscadorEmpleado.Location = new Point(12, 14);
            BuscadorEmpleado.Name = "BuscadorEmpleado";
            BuscadorEmpleado.Size = new Size(221, 27);
            BuscadorEmpleado.TabIndex = 14;
            // 
            // VentanaTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 453);
            Controls.Add(BuscadorEmpleado);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox BuscadorEmpleado;
    }
}