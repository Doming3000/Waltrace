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

            TrabajadoresList.EmptyText = "La base de datos está vacía o no hay conexión a ella.\r\nNo hay datos para mostrar.";
            TrabajadoresList.NoResultsText = "No se encontró al trabajador que estás buscando.";
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
                MessageBox.Show("Ha ocurrido un error al cargar las empresas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(TextBoxNom.Text) || string.IsNullOrEmpty(TextBoxRut.Text) || string.IsNullOrEmpty(TextBoxCargo.Text) || string.IsNullOrEmpty(TextBoxCurr.Text) || ComboBoxEmp.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarRut(TextBoxRut.Text))
            {
                MessageBox.Show("El RUT ingresado no es válido.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ValidarUrl(TextBoxCurr.Text))
            {
                MessageBox.Show("La URL del currículum no es válida.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(TextBoxFoto.Text) && !ValidarUrl(TextBoxFoto.Text))
            {
                MessageBox.Show("La URL de la foto no es válida.", "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas proceder?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CargarDatos();
                }
            }
        }

        private void CargarDatos()
        {
            string rut = TextBoxRut.Text.Trim();

            if (DataBaseConnection.VerifyInternetConnection())
            {
                try
                {
                    DataBaseConnection.AbrirConexion();

                    if (RutDuplicado(rut))
                    {
                        MessageBox.Show("El trabajador ingresado ya existe en la base de datos", "Información duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"INSERT INTO trabajadores (id_empresa, nom_trabajador, rut_trabajador, cargo, fecha_inicio, curriculum_url, foto) VALUES (@IdEmpresa, @Nombre, @Rut, @Cargo, @FechaInicio, @CurriculumUrl, @Foto)";
                    using SqlCommand command = new(query, DataBaseConnection.Conexion);
                    command.Parameters.AddWithValue("@IdEmpresa", ComboBoxEmp.SelectedValue);
                    command.Parameters.AddWithValue("@Nombre", TextBoxNom.Text);
                    command.Parameters.AddWithValue("@Rut", rut);
                    command.Parameters.AddWithValue("@Cargo", TextBoxCargo.Text);
                    command.Parameters.AddWithValue("@FechaInicio", DateTimeP.Value);
                    command.Parameters.AddWithValue("@CurriculumUrl", TextBoxCurr.Text);
                    command.Parameters.AddWithValue("@Foto", TextBoxFoto.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Trabajador añadido exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido añadir al trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar al trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DataBaseConnection.CerrarConexion();
                }
            }
        }

        private static bool RutDuplicado(string rut)
        {
            string query = "SELECT COUNT(*) FROM trabajadores WHERE rut_trabajador = @Rut";
            using SqlCommand command = new(query, DataBaseConnection.Conexion);
            command.Parameters.AddWithValue("@Rut", rut);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            ModificarEmpleado.Visible = true;
            InsertarEmpleado.Visible = false;

            ListarTrabajadores();
        }

        private void ListarTrabajadores()
        {
            if (DataBaseConnection.VerifyInternetConnection())
            {
                try
                {
                    DataBaseConnection.AbrirConexion();

                    string consulta = @"SELECT t.id_trabajador, t.nom_trabajador, t.rut_trabajador, e.nom_empresa, t.cargo FROM trabajadores t INNER JOIN empresas e ON t.id_empresa = e.id_empresa";
                    using SqlCommand comando = new(consulta, DataBaseConnection.Conexion);
                    using SqlDataReader lector = comando.ExecuteReader();
                    TrabajadoresList.Items.Clear();

                    while (lector.Read())
                    {
                        ListViewItem item = new(lector["nom_trabajador"].ToString());
                        item.SubItems.Add(lector["rut_trabajador"].ToString());
                        item.SubItems.Add(lector["cargo"].ToString());
                        item.SubItems.Add(lector["nom_empresa"].ToString());
                        item.Tag = lector["id_trabajador"].ToString();
                        TrabajadoresList.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al cargar la lista de trabajadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DataBaseConnection.CerrarConexion();
                }
            }
        }

        private void LimpiarCampos()
        {
            TextBoxNom.Clear();
            TextBoxRut.Clear();
            TextBoxCargo.Clear();
            ComboBoxEmp.SelectedIndex = -1;
            DateTimeP.Value = DateTime.Now;
            TextBoxCurr.Clear();
            TextBoxFoto.Clear();
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            Principal form = new();
            form.Show();
            Hide();
        }

        private void TextBoxRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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