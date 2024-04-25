using System.Net.NetworkInformation;

namespace Waltrace
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Botones en el formulario
        private void TrabajadorButton_Click(object sender, EventArgs e)
        {
            OpenFormIfConnected(new Trabajadores());
        }

        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            OpenFormIfConnected(new Empresas());
        }

        // Método para comprobar la conexión a internet
        private bool IsInternetAvailable()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        // Abrir nuevas ventanas
        private void OpenFormIfConnected(Form form)
        {
            if (!IsInternetAvailable())
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerifica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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