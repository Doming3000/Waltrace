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
            if (DataBaseConnection.VerifyInternetConnection())
            {
                Trabajadores form = new();
                form.Show();
                Hide();
            }
        }

        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            if (DataBaseConnection.VerifyInternetConnection())
            {
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

        // Quitar esto después
        private void button1_Click(object sender, EventArgs e)
        {
            ModificarTrabajador form = new();
            form.Show();
            Hide();
        }
    }
}