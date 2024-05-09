using System.Configuration;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

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
            if (!VerifyInternetConnection()) return;

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            MessageBox.Show("La conexión está abierta");
        }

        public static void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            MessageBox.Show("La conexión está cerrada");
        }

        public static bool VerifyInternetConnection()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No estás conectado a internet.\r\nVerifica el estado de tu conexión y vuelve a intentarlo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}