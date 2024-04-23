using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Waltrace
{
    public partial class Empresas : Form
    {
        // Variables
        string urlDoc = string.Empty;

        public Empresas()
        {
            InitializeComponent();

            // Llamada a método para listar las empresas
            ListarEmpresasBox();
        }

        // Método para listar las empresas en EmpresasBox almacenadas en la base de datos.
        private void ListarEmpresasBox()
        {
            try
            {
                // Abrir la conexión en caso de que no esté abierta
                DataBaseConnection.AbrirConexion();

                // Comando SQL ajustado para seleccionar solo el ID y el nombre de las empresas
                using (SqlCommand comando = new SqlCommand("SELECT id_empresa, nom_empresa FROM empresas", DataBaseConnection.Conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(lector);
                    EmpresasBox.DataSource = dt;
                    EmpresasBox.ValueMember = "id_empresa"; // Establecer la columna que representa el valor único de cada ítem
                    EmpresasBox.DisplayMember = "nom_empresa"; // Establecer la columna para mostrar en el ComboBox

                    EmpresasBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar listar las empresas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener datos de la empresa badados en el ID de la empresa
        private (string rutEmpresa, string nombreRepresentante, string direccion, long telefono, DateTime añoConst, string logoUrl, string documentacion) ObtenerDatosEmpresa(int idEmpresa)
        {
            string rutEmpresa = "", nombreRepresentante = "", direccion = "", logoUrl = "", documentacion = "";
            long telefono = 0;
            DateTime añoConst = DateTime.MinValue;

            try
            {
                string consulta = "SELECT rut_empresa, representante, direccion, telefono, año_const, logo, documentacion FROM empresas WHERE id_empresa = @idEmpresa";

                using (SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion))
                {
                    comando.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            rutEmpresa = lector["rut_empresa"]?.ToString() ?? "";
                            nombreRepresentante = lector["representante"]?.ToString() ?? "";
                            direccion = lector["direccion"]?.ToString() ?? "";
                            telefono = lector["telefono"] as long? ?? 0;
                            añoConst = lector["año_const"] as DateTime? ?? DateTime.MinValue;
                            logoUrl = lector["logo"]?.ToString() ?? "";
                            documentacion = lector["documentacion"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los datos de la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (rutEmpresa, nombreRepresentante, direccion, telefono, añoConst, logoUrl, documentacion);
        }

        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay conexión a internet al seleccionar una empresa
            bool checkConnection = NetworkInterface.GetIsNetworkAvailable();
            if (!checkConnection)
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerífica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Comprobar si existe una selección válida
                if (EmpresasBox.SelectedIndex >= 0 && EmpresasBox.SelectedValue != null && int.TryParse(EmpresasBox.SelectedValue.ToString(), out int idEmpresa))
                {
                    // Habilitar GroupBox al seleccionar una empresa
                    GroupBox1.Enabled = true;

                    // Limpiar posibles datos seleccionados anteriormente
                    WalbuschPanel.Visible = false;
                    MCAPanel.Visible = false;
                    WaltechPanel.Visible = false;

                    // Comprobar cuál empresa se seleccionó:
                    if (idEmpresa == 1) // Walbusch SA
                    {
                        WalbuschPanel.Visible = true;
                    }
                    else if (idEmpresa == 2) // MCA SA
                    {
                        MCAPanel.Visible = true;
                    }
                    else if (idEmpresa == 3) // Waltech
                    {
                        WaltechPanel.Visible = true;
                    }

                    // Consultar la base de datos para obtener la información a imprimir
                    var (rutEmpresa, nombreRepresentante, direccion, telefono, añoConst, logoUrl, documentacion) = ObtenerDatosEmpresa(idEmpresa);

                    // Imprimir los datos en sus respectivos textboxes
                    DisplayBoxRep.Text = nombreRepresentante;
                    DisplayBoxRut.Text = rutEmpresa;
                    DisplayBoxDir.Text = direccion;
                    DisplayBoxTel.Text = telefono.ToString();
                    DisplayBoxAño.Text = añoConst.ToString("d-MM-yyyy");

                    // Llamada a método para cargar el logo de la empresa
                    CargarLogo(logoUrl);

                    // Actualizar la URL de documentación actual
                    urlDoc = documentacion;
                }
            }
        }

        private async void CargarLogo(string urlLogo)
        {
            // Mostrar texto "Cargando logotipo"
            LoadingText.Visible = true;

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(urlLogo))
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Crear una imagen desde el stream de manera asincrónica
                        var image = Image.FromStream(stream);

                        Invoke((MethodInvoker)delegate
                        {
                            LogoBox.Image = image;
                            LoadingText.Visible = false;
                        });
                    }
                    else
                    {
                        throw new Exception("No se ha podido cargar el logo. El servidor ha respondido con el código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar el logo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadingText.Visible = false;
            }
        }

        private void DocsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(urlDoc))
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = urlDoc,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido acceder a la documentación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Obtener información de los textboxes 
            string nombreRepresentante = DisplayBoxRep.Text;
            string rutEmpresa = DisplayBoxRut.Text;
            string direccion = DisplayBoxDir.Text;
            string telefono = DisplayBoxTel.Text;
            string año = DisplayBoxAño.Text;

            // Copiar información al portapapeles
            Clipboard.SetText(nombreRepresentante + "\n" + rutEmpresa + "\n" + direccion + "\n" + telefono + "\n" + año);
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            Principal form = new Principal();
            form.Show();
            Hide();

            // Cerrar conexión
            DataBaseConnection.CerrarConexion();
        }

        // Simular efecto Hover del cursor
        private void RegresarButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void RegresarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void CopyButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CopyButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void DocsButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void DocsButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void FlotaButton_Click(object sender, EventArgs e)
        {
            FlotaWalbusch form = new FlotaWalbusch();
            form.ShowDialog();
        }
    }
}