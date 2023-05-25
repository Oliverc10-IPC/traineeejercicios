using static System.Console;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); 

            for (int i = 0; i < 999; i++) {
                numeros.Add(i+1);
            }
            int suma = 0;
            foreach (int i in numeros) {
                suma += i;
                WriteLine(suma);
            }

        }
    }
}