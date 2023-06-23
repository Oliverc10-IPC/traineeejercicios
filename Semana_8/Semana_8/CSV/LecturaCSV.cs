using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8.CSV
{
    internal class LecturaCSV
    {
        private string csvFile = "Vuelos_disponibles.csv";
        public List<Flight> flights = new List<Flight>();
        public LecturaCSV()
        {
                  
            // Leer archivo CSV
            using (var reader = new StreamReader(csvFile))
            {
                string separador = ",";
                string linea;
                reader.ReadLine();
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] parts = linea.Split(separador);
                    int Id = int.Parse(parts[0]);
                    string Origen = parts[1];
                    string Destino = parts[2];
                    string Fecha = (parts[3]);

                    float Precio = float.Parse(parts[4].Replace("$", ""));
                    string Aereopuerto = parts[5];
                    Flight flight = new Flight(Id, Origen, Destino, Fecha, Precio, Aereopuerto);
                    this.flights.Add(flight);
            }


            }
        }
    }
}
