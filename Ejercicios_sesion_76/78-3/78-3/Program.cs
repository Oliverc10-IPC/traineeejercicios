using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido");
            List<int> numeros = new List<int>();
            for (int i = 0; i < 10; i++) {
                WriteLine("Por favor ingresa un numero: ");
                int numero= int.Parse(Console.ReadLine());  
                numeros.Add(numero); 

            }
            int sumaPares=0;
            int sumaImpares = 0;
            foreach (int num in numeros) {
                if (num % 2 == 0)
                {
                    sumaPares += num;

                }
                else { 
                    sumaImpares += num; 
                
                }
            
            }
            WriteLine($"La suma de los numeros pares es {sumaPares}");
            WriteLine($"La suma de los numeros impares es {sumaImpares}");
        }
    }
}