using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();
            perro.Andar();
            perro.Saltar();

        }
    }

    interface IAnimal {

        public void Andar();
        public bool esPerro();
        public void Saltar();
    
    }

    public class Animal : IAnimal
    {

        public void Andar()
        {
            Console.WriteLine("Andando");
        }
        public bool esPerro()
        {

            Console.WriteLine("Es perro");
                return true;
        }
        public void Saltar() {
            Console.WriteLine("Saltando");
        
        }
    }
}
