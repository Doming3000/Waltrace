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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login form = new();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                ModificarTrabajador form2 = new();
                form2.Show();
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