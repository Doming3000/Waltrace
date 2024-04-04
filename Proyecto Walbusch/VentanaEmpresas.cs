using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Walbusch
{
    public partial class VentanaEmpresas : Form
    {
        public VentanaEmpresas()
        {
            InitializeComponent();
            ListarEmpresasBox();
        }

        private void ListarEmpresasBox()
        {
            try
            {
                DataBaseConnection.AbrirConexion();

                using (SqlCommand comando = new SqlCommand("SELECT nom_empresa FROM empresas", DataBaseConnection.Conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
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