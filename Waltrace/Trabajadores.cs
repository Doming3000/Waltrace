using System.Data.SqlClient;

namespace Waltrace
{
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
            ListarTrabajadores();

            TrabajadoresList.EmptyText = "La base de datos está vacía o no hay conexión a ella.\r\nNo hay datos para mostrar.";
            TrabajadoresList.NoResultsText = "No se encontró al trabajador que estás buscando.";
        }

        private void ListarTrabajadores()
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

        private void TrabajadoresList_ItemActivate(object sender, EventArgs e)
        {

            if (TrabajadoresList.SelectedItems.Count > 0)
            {
                ListViewItem item = TrabajadoresList.SelectedItems[0];
                string nombre = item.SubItems[0].Text;
                string rut = item.SubItems[1].Text;
                string cargo = item.SubItems[2].Text;
                string empresa = item.SubItems[3].Text;
                string id = item.Tag?.ToString() ?? "";

                TrabajadorSeleccionado form = new(nombre, rut, empresa, cargo, id);
                form.ShowDialog();
            }

        }

        private void BuscadorEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar que el evento se propague
                e.SuppressKeyPress = true;

                if (BuscadorEmpleado.Text == "")
                {
                    ListarTrabajadores();
                }
                else
                {
                    BuscarEmpleado();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (BuscadorEmpleado.Text == "")
            {
                ListarTrabajadores();
            }
            else
            {
                BuscarEmpleado();
            }
        }

        private void BuscarEmpleado()
        {
            string searchTerm = BuscadorEmpleado.Text.Trim();

            try
            {
                DataBaseConnection.AbrirConexion();

                string query = @"SELECT t.id_trabajador, t.nom_trabajador, t.rut_trabajador, e.nom_empresa, t.cargo FROM trabajadores t INNER JOIN empresas e ON t.id_empresa = e.id_empresa WHERE t.nom_trabajador LIKE @searchTerm OR t.rut_trabajador LIKE @searchTerm";

                using SqlCommand command = new(query, DataBaseConnection.Conexion);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using SqlDataReader reader = command.ExecuteReader();
                TrabajadoresList.Items.Clear();
                TrabajadoresList.IsSearchResultEmpty = true;

                while (reader.Read())
                {
                    ListViewItem item = new(reader["nom_trabajador"].ToString());
                    item.SubItems.Add(reader["rut_trabajador"].ToString());
                    item.SubItems.Add(reader["cargo"].ToString());
                    item.SubItems.Add(reader["nom_empresa"].ToString());
                    item.Tag = reader["id_trabajador"].ToString();

                    TrabajadoresList.Items.Add(item);
                    TrabajadoresList.IsSearchResultEmpty = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error en la base de datos: " + ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBaseConnection.CerrarConexion();
            }

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