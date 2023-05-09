// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;



namespace Generador_Tabla // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido");
            WriteLine();
            WriteLine("Por favor ingresa la tabla del numero que deseas conocer: ");
            int numero=int.Parse(Console.ReadLine());
            ImpresionTabla(numero);
        }
        private static void ImpresionTabla(int numero) { 
        Console.WriteLine("Tabla del "+ numero);
        for (int i = 0; i <= numero; i++) {
                int resultado = i * numero;
                WriteLine(i+" * "+ numero +" = "+ resultado);
            }
        }
    }
}
