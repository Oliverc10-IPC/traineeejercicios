using Semana_8.BaseDatos;
using Semana_8.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8.VistaUsuario
{
    internal class Menu
    {
        public Menu() {

            bool exit = false;
            ServiciosBaseDatos serviciosBaseDatos = new ServiciosBaseDatos();
            LecturaCSV lecturaCSV = new LecturaCSV();
            Console.WriteLine("Cargando datos por favor espere...");
            try
            {
                serviciosBaseDatos.InsertarDatosTabla(lecturaCSV.flights);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los datos han sido cargados anteriormente.");   

            }
            while (!exit)
            {
                Console.WriteLine("----- Menú Principal -----");
                Console.WriteLine("1. Busqueda por Origen");
                Console.WriteLine("2. Busqueda por Destino");
                Console.WriteLine("3. Salir ");
                Console.WriteLine("--------------------------");
                Console.Write("Elige una opción: ");

                string input = Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        Busqueda busqueda = new Busqueda("Origen");
                        Menu menu = new Menu();
                        break;

                    case "2":
                        Busqueda busqueda2 = new Busqueda("Destino");
                        _ = new Menu();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        System.Environment.Exit(0); 
                        break;

                  default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }

                Console.WriteLine();
            }
        }   
    }
}
