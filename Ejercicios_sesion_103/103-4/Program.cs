using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Vehiculo {

        public int ruedas { get; set; }
        public int puertas { get; set; }

        public Vehiculo() { 
            this.puertas = 0;
            this.ruedas = 0;
        
        }
        public Vehiculo(int ruedas, int puertas) {
            this.ruedas = ruedas;
            this.puertas = puertas;
        
        }
        public Vehiculo(int ruedas) {
            this.ruedas = ruedas;
            this.puertas = 0;
        
        }
    
    
    }
}