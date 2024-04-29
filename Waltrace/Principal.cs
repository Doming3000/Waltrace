using System.Net.NetworkInformation;

namespace Waltrace
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

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
                Trabajadores form = new();
                form.Show();
                Hide();
            }
        }

        private void EmpresaButton_Click(object sender, EventArgs e)
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
                Empresas form = new();
                form.Show();
                Hide();
            }
        }

        // Simular efecto Hover del cursor
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}