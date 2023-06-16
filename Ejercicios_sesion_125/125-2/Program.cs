using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool activo= true;
            Generica<string> generica = new Generica<string>();
           while (activo) {

                Console.WriteLine("Por favor ingresa un dato:");
                generica.Add(Console.ReadLine());
                Console.WriteLine("Se agrego el dato");
                Console.WriteLine("Deseas ingresar otro dato?\n1. Si\n2. No");
                
                var opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        break;
                    case 2:
                        activo = false;
                        break;
                }

            
            }
            
        }
    }
    public class Generica<T> { 
        public void Add(T input) { }
    
    } 
}