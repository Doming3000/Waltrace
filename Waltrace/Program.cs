using System.Configuration;
using System.Data.SqlClient;

namespace Waltrace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }

    public static class DataBaseConnection
    {
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        private static readonly SqlConnection conexion = new(cadenaConexion);

        public static SqlConnection Conexion => conexion;


        public static void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                //MessageBox.Show("Abierto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir conexión: " + ex.Message);
            }
        }

        public static void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //MessageBox.Show("Cerrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}