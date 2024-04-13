using System.Net.NetworkInformation;

namespace Waltrace
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Botones en el formulario:
        private void TrabajadorButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay conexión a internet al cargar la ventana
            bool checkConnection = NetworkInterface.GetIsNetworkAvailable();
            if (!checkConnection)
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerífica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Cargar nueva ventana y esconder la anterior
                Trabajadores form1 = new Trabajadores();
                this.Hide();
                form1.Show();
            }
        }
        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            bool checkConnection = NetworkInterface.GetIsNetworkAvailable();
            if (!checkConnection)
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerífica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empresas form1 = new Empresas();
                this.Hide();
                form1.Show();
            }
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