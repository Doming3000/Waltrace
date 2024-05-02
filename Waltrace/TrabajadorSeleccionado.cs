using System.Data.SqlClient;

namespace Waltrace
{
    public partial class TrabajadorSeleccionado : Form
    {
        // Variables
        string urlCurr = string.Empty;
        private static readonly HttpClient client = new();

        public TrabajadorSeleccionado(string nombre, string rut, string empresa, string cargo, string id)
        {
            InitializeComponent();

            // Asignar los valores a los TextBoxes u otros controles
            DisplayBoxNom.Text = nombre;
            DisplayBoxRut.Text = rut;
            DisplayBoxEmp.Text = empresa;
            DisplayBoxCargo.Text = cargo;

            // Cargar información adicional usando el ID
            ListarNuevaInformacion(id);
        }

        private void ListarNuevaInformacion(string identificador)
        {
            try
            {
                DataBaseConnection.AbrirConexion();

                string consulta = "SELECT fecha_inicio, curriculum_url, foto FROM trabajadores WHERE id_trabajador = @Identificador";
                using SqlCommand command = new(consulta, DataBaseConnection.Conexion);
                command.Parameters.AddWithValue("@Identificador", identificador);

                using SqlDataReader lector = command.ExecuteReader();
                if (lector.Read())
                {
                    DateTime fechaInicio = (DateTime)lector["fecha_inicio"];
                    DisplayBoxAño.Text = fechaInicio.ToString("dd-MM-yyyy");

                    string urlFoto = lector["foto"].ToString() ?? "";
                    CargarFoto(urlFoto);

                    urlCurr = lector["curriculum_url"].ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el trabajador seleccionado.", "Información no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error en base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBaseConnection.CerrarConexion();
            }
        }

        private async void CargarFoto(string urlFoto)
        {
            // Utilizar imagen predeterminada si el trabajaddor seleccionado no tiene foto
            Bitmap defaultImage = Properties.Resources.NoFoto;

            // Mostrar texto "Cargando foto..."
            LoadingText.Visible = true;

            try
            {
                if (string.IsNullOrEmpty(urlFoto))
                {
                    FotoBox.Image = defaultImage;
                    LoadingText.Visible = false;
                    return;
                }

                using HttpResponseMessage response = await client.GetAsync(urlFoto);
                using Stream stream = await response.Content.ReadAsStreamAsync();
                if (response.IsSuccessStatusCode)
                {
                    // Crear una imagen desde el stream de manera asincrónica
                    var image = Image.FromStream(stream);

                    Invoke((MethodInvoker)delegate
                    {
                        FotoBox.Image = image;
                        LoadingText.Visible = false;
                    });
                }
                else
                {
                    throw new Exception("No se ha podido cargar el logo. El servidor ha respondido con el código de estado: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                FotoBox.Image = defaultImage;
                LoadingText.Visible = false;
                MessageBox.Show("No se ha podido cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CurriculumLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(urlCurr))
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = urlCurr,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido acceder al currículum: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Close();
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