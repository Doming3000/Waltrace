using System.Data;
using System.Data.SqlClient;

namespace Waltrace
{
    public partial class VentanaEmpresas : Form
    {
        public VentanaEmpresas()
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
                MessageBox.Show("Ha ocurrido un error al intentar listar las empresas: " + ex.Message);
            }
        }

        // Método para obtener datos de la empresa badados en el ID de la empresa
        private (string rutEmpresa, string nombreRepresentante, string direccion, long telefono, DateTime añoConst, string logoUrl) ObtenerDatosEmpresa(int idEmpresa)
        {
            string rutEmpresa = "", nombreRepresentante = "", direccion = "", logoUrl = "";
            long telefono = 0;
            DateTime añoConst = DateTime.MinValue;

            try
            {
                string consulta = "SELECT rut_empresa, representante, direccion, telefono, año_const, logo FROM empresas WHERE id_empresa = @idEmpresa";

                using (SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion))
                {
                    comando.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            rutEmpresa = lector["rut_empresa"].ToString();
                            nombreRepresentante = lector["representante"].ToString();
                            direccion = lector["direccion"].ToString();
                            telefono = (long)lector["telefono"];
                            añoConst = (DateTime)lector["año_const"];
                            logoUrl = lector["logo"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los datos de la empresa: " + ex.Message);
            }

            return (rutEmpresa, nombreRepresentante, direccion, telefono, añoConst, logoUrl);
        }

        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprobar si existe una selección válida
            if (EmpresasBox.SelectedIndex >= 0 && int.TryParse(EmpresasBox.SelectedValue.ToString(), out int idEmpresa))
            {
                // Habilitar GroupBox al seleccionar una empresa
                GroupBox1.Enabled = true;

                // Consultar la base de datos para obtener la información a imprimir
                var (rutEmpresa, nombreRepresentante, direccion, telefono, añoConst, logoUrl) = ObtenerDatosEmpresa(idEmpresa);

                // Imprimir los datos en sus respectivos textboxes
                DisplayBoxRep.Text = nombreRepresentante;
                DisplayBoxRut.Text = rutEmpresa;
                DisplayBoxDir.Text = direccion;
                DisplayBoxTel.Text = telefono.ToString();
                DisplayBoxAño.Text = añoConst.ToString("d-MM-yyyy");

                // Llamada a método para cargar el logo de la empresa
                CargarLogo(logoUrl);
            }
        }

        private void CargarLogo(string url)
        {
            try
            {
                // Comprobar que la url no esté vacía
                if (!string.IsNullOrWhiteSpace(url))
                {
                    // Utiliza el método Load del PictureBox para cargar la imagen desde la URL
                    LogoBox.Load(url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el logo: " + ex.Message);
            }
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            VentanaPrincipal form1 = new VentanaPrincipal();
            this.Hide();
            form1.Show();
        }

        private void RegresarButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void RegresarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void DocsButton_Click(object sender, EventArgs e)
        {

        }
    }
}