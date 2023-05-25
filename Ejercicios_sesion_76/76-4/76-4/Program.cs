using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            WriteLine("Bienvenido");
            for (int i = 0; i < 10; i++)
            {
                WriteLine("Por favor ingresa un numero: ");
                int numero= int.Parse(Console.ReadLine());
                numeros.Add(numero); 
                
            }
            WriteLine($"El numero mayor de la lista es {EncontrarNumeroMayor(numeros)}");
            WriteLine($"El numero menor de la lista es {EncontrarNumeroMenor(numeros)}");



        }
        public static int EncontrarNumeroMayor(List<int> numeros) {
            int numeroMayor= 0;
            foreach (int numero in numeros) {
                if (numero > numeroMayor) {
                    numeroMayor = numero;
                }
            }
            return numeroMayor; 

        }
        public static int EncontrarNumeroMenor(List<int> numeros)
        {
            int numeroMenor = numeros[0];
            foreach (int numero in numeros)
            {
                if (numero < numeroMenor)
                {
                    numeroMenor = numero;
                }
            }
            return numeroMenor;

        }
    }
}