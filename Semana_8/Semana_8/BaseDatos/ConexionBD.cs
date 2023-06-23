using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8.BaseDatos
{
    internal class ConexionBD : IConexionBD
    {

        string cadenaConexion= "Server=tcp:masterudemynuevo.database.windows.net,1433;Initial Catalog=MasterUdemynueva;Persist Security Info=False;User ID=OliverCruz2023;Password=Oliverc10.";
        public SqlConnection connection = new SqlConnection();

        public ConexionBD()
        {
            connection.ConnectionString = cadenaConexion;
        }
        public void abrirConection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexion Exitosa");

            }
            catch (Exception ex) { 
                Console.WriteLine("Error al conectarse a la BD");
            }

        }
    }
}
