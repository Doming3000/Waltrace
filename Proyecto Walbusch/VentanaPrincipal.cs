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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        // Botones en el formulario:
        private void TrabajadorButton_Click(object sender, EventArgs e)
        {
            // Cargar nueva ventana y esconder la anterior
            VentanaTrabajadores form2 = new VentanaTrabajadores();
            this.Hide();
            form2.Show();
        }
        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            VentanaEmpresas form3 = new VentanaEmpresas();
            this.Hide();
            form3.Show();
        }

        private void EmpresaButton_MouseEnter(object sender, EventArgs e)
        {
            // Alternar el estado del cursor al posicionarse sobre un botón
            Cursor = Cursors.Hand;
        }

        private void EmpresaButton_MouseLeave(object sender, EventArgs e)
        {
            // Regresar al cursor predeterminado al retirar del botón
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