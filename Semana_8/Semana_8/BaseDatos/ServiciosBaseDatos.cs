using CsvToDatabase;
using Semana_8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Semana_8.BaseDatos
{
    internal class ServiciosBaseDatos 
    {
        ConexionBD conexion = new ConexionBD(); 

        public ServiciosBaseDatos() {
            
        }
        //Inserta los datos en la tabla 
        public void InsertarDatosTabla(List<Flight> flights) {
            conexion.abrirConection();
            // crea la tabla si no existe
            using (var createTableCmd = new SqlCommand(@"
                        IF OBJECT_ID('Flights') IS NULL
                        BEGIN
                            CREATE TABLE Flights (
                                Id INT PRIMARY KEY,
                                Origen VARCHAR(100),
                                Destino VARCHAR(100),
                                Fecha DATE,
                                Precio DECIMAL(10, 2),
                                Aereopuerto VARCHAR(100)
                            )
                        END", conexion.connection))
            {
                createTableCmd.ExecuteNonQuery();
            }

            // Insertar datos en la tabla
            foreach (var flight in flights)
            {
                var insertCmd = new SqlCommand("INSERT INTO Flights (Id, Origen, Destino, Fecha, Precio, Aereopuerto) VALUES (@Id, @Origen, @Destino, @Fecha, @Precio, @Aereopuerto)", conexion.connection);

                insertCmd.Parameters.AddWithValue("@Id", flight.Id);
                insertCmd.Parameters.AddWithValue("@Origen", flight.Origen);
                insertCmd.Parameters.AddWithValue("@Destino", flight.Destino);
                insertCmd.Parameters.AddWithValue("@Fecha", flight.Fecha);
                insertCmd.Parameters.AddWithValue("@Precio", flight.Precio);
                insertCmd.Parameters.AddWithValue("@Aereopuerto", flight.Aereopuerto);

                insertCmd.ExecuteNonQuery();
            }

        }

        // Busqueda de cualquier tipo
        public void Busqueda(string OpcionBuscar, string TipoBusqueda)
        {
            conexion.abrirConection();
            var selectCmd = new SqlCommand($"SELECT * FROM Flights WHERE {TipoBusqueda} LIKE @{TipoBusqueda}Busqueda", conexion.connection);
            selectCmd.Parameters.AddWithValue($"@{TipoBusqueda}Busqueda", "%" + OpcionBuscar + "%");


            var adapter = new SqlDataAdapter(selectCmd);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            var contador = 0;
            // Mostrar los resultados
            foreach (DataRow row in dataTable.Rows)
            {
                
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.WriteLine($"{col.ColumnName}: {row[col]}");
                }
                Console.WriteLine();
                contador++;
            }
            Console.WriteLine($"Cantidad de Vuelos Disponibles: {contador}");

        }
    }


}
