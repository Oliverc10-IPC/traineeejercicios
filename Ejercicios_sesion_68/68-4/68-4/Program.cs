// See https://aka.ms/new-console-template for more information
using static System.Console;
using System;
using System.Text;

namespace Numeros // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            WriteLine("Bienvenido");
            AgregarStringBuilder(sb, "primer");
            AgregarStringBuilder(sb, "segundo");
            AgregarStringBuilder(sb, "tercer");
            AgregarStringBuilder(sb, "cuarto");

            WriteLine(sb); 

        }

        public static void AgregarStringBuilder(StringBuilder sb,String orden) { 
            WriteLine("Ingrese un numero");
            String dato = ReadLine();
            sb.AppendLine($"El {orden} numero introducido es: ");
            sb.AppendLine(dato);

        }
        
    }
}