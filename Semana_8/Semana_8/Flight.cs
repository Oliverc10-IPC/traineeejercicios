using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8
{
    internal class Flight
    {
        public int Id { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Fecha { get; set; }

        public float Precio { get; set; }
        public string Aereopuerto { get; set; }

        public Flight(int Id, string Origen, string Destino, string Fecha, float Precio, string Aereopuerto)
        {
            this.Id = Id;
            this.Origen = Origen;
            this.Destino = Destino;
            this.Fecha = Fecha;
            this.Precio = Precio;
            this.Aereopuerto = Aereopuerto;

        }
    }
}
