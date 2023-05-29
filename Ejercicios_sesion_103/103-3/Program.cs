using System;

namespace Derivacion // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Vehiculo {

        public bool estado = true;

        public void Reparar() { 
                
        }

        public void Averiar() { 
        
        }
    
    }

    public class Coche : Vehiculo {

        public void Reparar() { 
            this.estado = true;
            
        }
        public void Averiar()
        {
            this.estado = false;
        }
    }
    public class Barco : Vehiculo {
        public void Reparar()
        {
            this.estado = true;

        }
        public void Averiar()
        {
            this.estado = false;
        }

    }
    public class Avion : Vehiculo
    {
        public void Reparar()
        {
            this.estado = true;

        }
        public void Averiar()
        {
            this.estado = false;
        }

    }

}