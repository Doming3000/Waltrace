using System.Data.SqlClient;

namespace Waltrace
{
    public partial class TrabajadorSeleccionado : Form
    {
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

                string consulta = "SELECT fecha_inicio, foto FROM trabajadores WHERE id_trabajador = @Identificador";

                using (SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion))
                {
                    comando.Parameters.AddWithValue("@Identificador", identificador);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            DateTime fechaInicio = (DateTime)lector["fecha_inicio"];
                            DisplayBoxAño.Text = fechaInicio.ToString("dd-MM-yyyy");

                            // Obtener la URL de la foto del trabajador
                            string urlFoto = lector["foto"]?.ToString() ?? "";

                            // Llamada al método para cargar la foto
                            CargarFoto(urlFoto);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el trabajador seleccionado.", "Información no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
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
            // Mostrar texto "Cargando foto..."
            LoadingText.Visible = true;

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(urlFoto))
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
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
                        throw new Exception("No se ha podido cargar la foto. El servidor ha respondido con el código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la foto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadingText.Visible = false;
            }
        }

        // Botón Aceptar:
        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void AceptarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}