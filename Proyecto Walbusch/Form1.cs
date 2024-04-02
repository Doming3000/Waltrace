using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Walbusch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Botones en el formulario:
        private void TrabajadorButton_Click(object sender, EventArgs e)
        {
            // Cargar nueva ventana y esconder la anterior
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void EmpresaButton_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el estado del cursor al estar sobre un botón
            Cursor = Cursors.Hand;
        }

        private void EmpresaButton_MouseLeave(object sender, EventArgs e)
        {
            // Regresar al cursor predeterminado
            Cursor = Cursors.Default;
        }

        private void TrabajadorButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void TrabajadorButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}