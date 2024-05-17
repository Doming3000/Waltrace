namespace Waltrace
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextboxUser.Text) || string.IsNullOrEmpty(TextboxPass.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool loginSuccess = VerificarCredenciales();

                if (loginSuccess)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, intente de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cambiar por lógica real en base de datos
        private bool VerificarCredenciales()
        {
            string usuario = TextboxUser.Text;
            string contraseña = TextboxPass.Text;

            return usuario == "juan" && contraseña == "1234";
        }
    }
}