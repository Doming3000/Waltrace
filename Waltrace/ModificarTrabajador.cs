using System.Data.SqlClient;
using System.Data;

namespace Waltrace
{
    public partial class ModificarTrabajador : Form
    {
        public ModificarTrabajador()
        {
            InitializeComponent();
            ListarEmpresas();
        }

        private void ListarEmpresas()
        {
            try
            {
                DataBaseConnection.AbrirConexion();

                using SqlCommand comando = new("SELECT id_empresa, nom_empresa FROM empresas", DataBaseConnection.Conexion);
                using SqlDataReader lector = comando.ExecuteReader();
                DataTable dt = new();
                dt.Load(lector);

                ComboBoxEmp.DataSource = dt;
                ComboBoxEmp.ValueMember = "id_empresa";
                ComboBoxEmp.DisplayMember = "nom_empresa";
                ComboBoxEmp.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar listar las empresas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBaseConnection.CerrarConexion();
            }
        }

        public static bool ValidarRut(string rut)
        {
            bool validacion = false;
            try
            {
                if (rut.Count(c => c == '-') != 1 || rut.StartsWith('-') || rut.EndsWith('-'))
                {
                    return false;
                }

                string[] partes = rut.Split('-');
                if (partes.Length != 2)
                {
                    return false;
                }

                string cuerpo = partes[0];
                string digitoVerificador = partes[1].ToUpper();

                if (!int.TryParse(cuerpo, out int rutAux))
                {
                    return false;
                }

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                char dvEsperado = (char)(s != 0 ? s + 47 : 75);

                if (digitoVerificador == dvEsperado.ToString())
                {
                    validacion = true;
                }
            }
            catch
            {
                validacion = false;
            }
            return validacion;
        }

        public static bool ValidarUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNom.Text) || string.IsNullOrEmpty(TextBoxRut.Text) || string.IsNullOrEmpty(TextBoxCargo.Text) || string.IsNullOrEmpty(TextBoxFetch.Text) || string.IsNullOrEmpty(TextBoxCurr.Text) || ComboBoxEmp.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarRut(TextBoxRut.Text))
            {
                MessageBox.Show("El RUT ingresado no es válido.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ValidarUrl(TextBoxCurr.Text))
            {
                MessageBox.Show("La URL del currículum no es válida.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(TextBoxFoto.Text) && !ValidarUrl(TextBoxFoto.Text))
            {
                MessageBox.Show("La URL de la foto no es válida.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    DataBaseConnection.AbrirConexion();

                    string query = @"INSERT INTO trabajadores (id_empresa, nom_trabajador, rut_trabajador, cargo, fecha_inicio, curriculum_url, foto) VALUES (@IdEmpresa, @Nombre, @Rut, @Cargo, @FechaInicio, @CurriculumUrl, @Foto)";

                    using SqlCommand command = new(query, DataBaseConnection.Conexion);
                    command.Parameters.AddWithValue("@IdEmpresa", ComboBoxEmp.SelectedValue);
                    command.Parameters.AddWithValue("@Nombre", TextBoxNom.Text);
                    command.Parameters.AddWithValue("@Rut", TextBoxRut.Text);
                    command.Parameters.AddWithValue("@Cargo", TextBoxCargo.Text);
                    command.Parameters.AddWithValue("@FechaInicio", DateTime.Parse(TextBoxFetch.Text));
                    command.Parameters.AddWithValue("@CurriculumUrl", TextBoxCurr.Text);
                    command.Parameters.AddWithValue("@Foto", TextBoxFoto.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Trabajador añadido exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo añadir al trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DataBaseConnection.CerrarConexion();
                }
            }
        }   
    }
}