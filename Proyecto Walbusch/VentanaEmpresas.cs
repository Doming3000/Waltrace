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
    public partial class VentanaEmpresas : Form
    {
        public VentanaEmpresas()
        {
            InitializeComponent();
        }

        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            VentanaPrincipal form1 = new VentanaPrincipal();
            this.Hide();
            form1.Show();
        }

        private void RegresarButton_MouseEnter(object sender, EventArgs e)
        {
            // 
            Cursor = Cursors.Hand;
        }

        private void RegresarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}