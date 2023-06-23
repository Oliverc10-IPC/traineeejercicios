using Semana_8.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8.VistaUsuario
{
    internal class Busqueda
    {
        private ServiciosBaseDatos serviciosBaseDatos=new ServiciosBaseDatos();
        public Busqueda(string tipoBusqueda)
        {
            Console.WriteLine();
            Console.WriteLine($"-----Menú {tipoBusqueda} -----");
            Console.WriteLine();
            Console.Write($"Ingresa un criterio de búsqueda para el {tipoBusqueda}: ");
            string datoBusqueda = Console.ReadLine();
            serviciosBaseDatos.Busqueda(datoBusqueda.Trim(), tipoBusqueda);
            _ = new Menu();
        }


    }

}
