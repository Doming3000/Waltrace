using System.Data;
using System.Data.SqlClient;

namespace Waltrace
{
    public partial class VentanaTrabajadores : Form
    {
        public VentanaTrabajadores()
        {
            InitializeComponent();

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

                string consulta = @"SELECT t.nom_trabajador, t.rut_trabajador, e.nom_empresa FROM trabajadores t INNER JOIN empresas e ON t.id_empresa = e.id_empresa";

                using (SqlCommand comando = new SqlCommand(consulta, DataBaseConnection.Conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    TrabajadoresList.Items.Clear();

                    while (lector.Read())
                    {
                        ListViewItem item = new ListViewItem(lector["nom_trabajador"].ToString());
                        item.SubItems.Add(lector["rut_trabajador"].ToString());
                        item.SubItems.Add(lector["nom_empresa"].ToString());
                        TrabajadoresList.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar listar los trabajadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            // Regresar al formulario inicial
            VentanaPrincipal form1 = new VentanaPrincipal();
            this.Hide();
            form1.Show();
        }

        private void BuscadorEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}