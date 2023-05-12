// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;



namespace Validacion_Alejandro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            WriteLine();
            WriteLine("Por favor ingresa tu nombre para ver si te conozco:");
            var nombre = ReadLine().ToLower();
            nombre = nombre.Trim();
            if (nombre.Equals("alejandro"))
            {
                Console.WriteLine("Hola");

            }
            else { 
                WriteLine("No te conozco");  
            }

        }
    }
}
