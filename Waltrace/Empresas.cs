using System.Data;
using System.Data.SqlClient;

namespace Waltrace
{
    public partial class Empresas : Form
    {
        // Variables
        private string urlDoc = string.Empty;
        private static readonly HttpClient client = new();

        public Empresas()
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

                EmpresasBox.DataSource = dt;
                EmpresasBox.ValueMember = "id_empresa";
                EmpresasBox.DisplayMember = "nom_empresa";
                EmpresasBox.SelectedIndex = -1;
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

        // Obtener datos de la empresa basado en el identificador
        private static (string rutEmpresa, string nombreRepresentante, string direccion, long telefono, DateTime añoConst, string logoUrl, string documentacion) ObtenerDatosEmpresa(int idEmpresa)
        {
            string rutEmpresa = "", nombreRepresentante = "", direccion = "", logoUrl = "", documentacion = "";
            long telefono = 0;
            DateTime añoConst = DateTime.MinValue;

            try
            {
                DataBaseConnection.AbrirConexion();

                string consulta = "SELECT rut_empresa, representante, direccion, telefono, año_const, logo, documentacion FROM empresas WHERE id_empresa = @idEmpresa";
                using SqlCommand command = new(consulta, DataBaseConnection.Conexion);
                command.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                using SqlDataReader lector = command.ExecuteReader();
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los datos de la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBaseConnection.CerrarConexion();
            }
            return (rutEmpresa, nombreRepresentante, direccion, telefono, añoConst, logoUrl, documentacion);
        }

        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBaseConnection.VerifyInternetConnection())
            {
                if (EmpresasBox.SelectedIndex >= 0 && EmpresasBox.SelectedValue != null && int.TryParse(EmpresasBox.SelectedValue.ToString(), out int idEmpresa))
                {
                    DatosEmpresa.Enabled = true;

                    // Limpiar posibles datos seleccionados anteriormente
                    WalbuschPanel.Visible = false;
                    MCAPanel.Visible = false;
                    WaltechPanel.Visible = false;

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

                    CargarLogo(logoUrl);

                    // Actualizar la URL de documentación actual
                    urlDoc = documentacion;
                }
            }
        }

        private async void CargarLogo(string urlLogo)
        {
            LoadingText.Visible = true;

            try
            {
                using HttpResponseMessage response = await client.GetAsync(urlLogo);
                using Stream stream = await response.Content.ReadAsStreamAsync();
                if (response.IsSuccessStatusCode)
                {
                    var image = Image.FromStream(stream);

                    Invoke((MethodInvoker)delegate {
                        LogoBox.Image = image;
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

            Clipboard.SetText(nombreRepresentante + "\n" + rutEmpresa + "\n" + direccion + "\n" + telefono + "\n" + año);
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            Principal form = new();
            form.Show();
            Hide();
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