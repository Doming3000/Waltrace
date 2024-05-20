using System.Data.SqlClient;

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
                bool loginSuccess = VerificarCredenciales(TextboxUser.Text, TextboxPass.Text);

                if (loginSuccess)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Las credenciales de acceso son incorrectas. Por favor, intente de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static bool VerificarCredenciales(string usuario, string contraseña)
        {
            bool isValid = false;

            try
            {
                DataBaseConnection.AbrirConexion();

                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña";
                using SqlCommand command = new(query, DataBaseConnection.Conexion);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                int count = Convert.ToInt32(command.ExecuteScalar());
                isValid = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al verificar las credenciales: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBaseConnection.CerrarConexion();
            }

            return isValid;
        }
    }
}