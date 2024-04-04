using System.Data.SqlClient;

namespace Proyecto_Walbusch
{
    public partial class VentanaEmpresas : Form
    {
        public VentanaEmpresas()
        {
            InitializeComponent();

            // Llamada a método para listar las empresas
            ListarEmpresasBox();
        }

        // Método para listar las empresas en Empresasbox almacenadas en la base de datos.
        private void ListarEmpresasBox()
        {
            try
            {
                DataBaseConnection.AbrirConexion();

                // Crear el comando SQL para seleccionar los nombres de las empresas
                using (SqlCommand comando = new SqlCommand("SELECT nom_empresa FROM empresas", DataBaseConnection.Conexion))

                // Ejecutar el comando y recibir los datos
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    // Leer los datos y agregar al ComboBox
                    while (lector.Read())
                    {
                        EmpresasBox.Items.Add(lector["nom_empresa"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar listar las empresas: " + ex.Message);
            }
        }
        private void EmpresasBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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