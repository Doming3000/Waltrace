using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Waltrace
{
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
            FormClosing += Trabajadores_FormClosing;

            // Llamada a método para listar los trabajdores en el listview
            ListarTrabajadores();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Establecer placeholder al buscador
            BuscadorEmpleado.Text = "Ingrese nombre o rut";
            BuscadorEmpleado.ForeColor = Color.Gray;
        }

        private void ListarTrabajadores()
        {
            try
            {
                // Abrir la conexión en caso de que no esté abierta
                DataBaseConnection.AbrirConexion();

                string consulta = @"SELECT t.id_trabajador, t.nom_trabajador, t.rut_trabajador, e.nom_empresa, t.cargo FROM trabajadores t INNER JOIN empresas e ON t.id_empresa = e.id_empresa";

                using SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion);
                using SqlDataReader lector = comando.ExecuteReader();
                TrabajadoresList.Items.Clear();

                while (lector.Read())
                {
                    ListViewItem item = new ListViewItem(lector["nom_trabajador"].ToString());
                    item.SubItems.Add(lector["rut_trabajador"].ToString());
                    item.SubItems.Add(lector["cargo"].ToString());
                    item.SubItems.Add(lector["nom_empresa"].ToString());
                    item.Tag = lector["id_trabajador"].ToString();  // ID almacenado en el Tag del item
                    TrabajadoresList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar listar los trabajadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrabajadoresList_ItemActivate(object sender, EventArgs e)
        {
            // Verificar si hay conexión a internet al seleccionar una empresa
            bool checkConnection = NetworkInterface.GetIsNetworkAvailable();
            if (!checkConnection)
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerífica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TrabajadoresList.SelectedItems.Count > 0)
                {
                    ListViewItem item = TrabajadoresList.SelectedItems[0];
                    string nombre = item.SubItems[0].Text;
                    string rut = item.SubItems[1].Text;
                    string cargo = item.SubItems[2].Text;
                    string empresa = item.SubItems[3].Text;
                    string id = item.Tag?.ToString() ?? "";  // Obtener el ID del Tag

                    // Abrir nueva ventana con los datos recolectados
                    TrabajadorSeleccionado form = new(nombre, rut, empresa, cargo, id);
                    form.ShowDialog();
                }
            }
        }

        private void BuscadorEmpleado_TextChanged(object sender, EventArgs e)
        {
            // Código del búscador:
            // Hay que filtrar datos por nombre o por rut.
            // Hay que comprobar el estado de la conexión a internet.
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            Principal form = new();
            form.Show();
            Hide();

            // Cerrar la conexión
            DataBaseConnection.CerrarConexion();
        }

        private void BuscadorEmpleado_Enter(object sender, EventArgs e)
        {
            // Remover el placeholder de los buscadores cuando se haga click en ellos
            if (BuscadorEmpleado.Text == "Ingrese nombre o rut")
            {
                BuscadorEmpleado.Text = "";
                BuscadorEmpleado.ForeColor = Color.Black;
            }
        }

        private void BuscadorEmpleado_Leave(object sender, EventArgs e)
        {
            // Comprobar si el buscador está vacio para colocar el placeholder
            if (BuscadorEmpleado.Text == "")
            {
                BuscadorEmpleado.Text = "Ingrese nombre o rut";
                BuscadorEmpleado.ForeColor = Color.Gray;
            }
        }

        // Al cerrar la ventana
        private void Trabajadores_FormClosing(object? sender, FormClosingEventArgs e)
        {
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
    }
}