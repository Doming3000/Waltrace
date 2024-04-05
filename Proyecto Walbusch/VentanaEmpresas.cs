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


        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprobar si existe una selección válida
            if (EmpresasBox.SelectedIndex >= 0 && int.TryParse(EmpresasBox.SelectedValue.ToString(), out int idEmpresa))
            {
                // Habilitar GroupBox al seleccionar una empresa
                GroupBox1.Enabled = true;

                // Consultar la base de datos para obtener la información a imprimir
                var (rutEmpresa, nombreRepresentante) = ObtenerDatosEmpresa(idEmpresa);

                // Imprimir datos en sus respectivos textboxes
                DisplayBoxRep.Text = nombreRepresentante;
                DisplayBoxRut.Text = rutEmpresa;
            }
        }

        // Método para obtener datos de la empresa badados en el ID de la empresa
        private (string rutEmpresa, string nombreRepresentante) ObtenerDatosEmpresa(int idEmpresa)
        {
            string rutEmpresa = "";
            string nombreRepresentante = "";

            try
            {
                string consulta = "SELECT rut_empresa, representante FROM empresas WHERE id_empresa = @idEmpresa";

                using (SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion))
                {
                    // Asegurar que el parámetro se añada de forma segura para evitar inyecciones SQL
                    comando.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            rutEmpresa = lector["rut_empresa"].ToString();
                            nombreRepresentante = lector["representante"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar obtener los datos de la empresa: " + ex.Message);
            }

            return (rutEmpresa, nombreRepresentante);
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
    }
}