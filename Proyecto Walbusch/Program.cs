using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_Walbusch
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Abrir la conexión al inicio de la aplicación
            DataBaseConnection.AbrirConexion();

            Application.Run(new VentanaPrincipal());

            // Cerrar la conexión cuando la aplicación se cierra
            DataBaseConnection.CerrarConexion();
        }
    }

    public static class DataBaseConnection
    {
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        private static readonly SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static SqlConnection Conexion => conexion;

        public static void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }

        public static void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}