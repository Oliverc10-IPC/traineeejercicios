// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using static System.Console;

namespace Transformador // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        public static void Menu() {
            WriteLine("Bievenido");
            WriteLine("");
            WriteLine("1. Dolares -> Euros");
            WriteLine("2. Euros -> Dolares");
            WriteLine();
            WriteLine("Por favor ingresa una de las opciones: ");
            int opcion = int.Parse(ReadLine());
            
            switch (opcion)
            {
                case 1:
                    WriteLine("Por favor ingresa la cantidad de Dolares a convertir");
                    double valorDolar = double.Parse(ReadLine());
                    WriteLine("Por favor ingresa el tipo de cambio actual(1 USD a Euro ): ");
                    double factorDolar = double.Parse(ReadLine());
                    WriteLine();
                    WriteLine("El valor en Euros es " + Conversion(valorDolar,factorDolar));
                    break;
                case 2:
                    WriteLine("Por favor ingresa la cantidad de Euros a convertir");
                    double valorEuro = double.Parse(ReadLine());
                    WriteLine("Por favor ingresa el tipo de cambio actual(1 Euro a USD ): ");
                    double factorEuro = double.Parse(ReadLine());
                    WriteLine();
                    WriteLine("El valor en Dolares es " + Conversion(valorEuro, factorEuro));
                    break;
                default:
                    WriteLine("Por favor intenta de nuevo");
                    Menu();
                    break;


            }
        }
        public static double Conversion(double valor, double factorConversion) { 
            var resultado = valor * factorConversion;
            return resultado;
        }
    }
}