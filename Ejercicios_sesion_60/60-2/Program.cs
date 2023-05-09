// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Calculadora // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        public static void MenuPrincipal() {
            WriteLine("Bienvenido");
            WriteLine();
            WriteLine("1- Suma         \n2- Resta         \n3- Multiplicación         \n4- División        \nSeleccione la opción:");
            int opcion=int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    WriteLine("Suma.__");
                    WriteLine("Por favor ingresa el primer numero: ");
                    double primerNumero= double.Parse(Console.ReadLine());
                    WriteLine("Por favor ingrese el segundo numero: ");
                    double segundoNumero= double.Parse(Console.ReadLine());
                    var resultado = primerNumero + segundoNumero;
                    WriteLine("El resultado es "+resultado);   
                    MenuPrincipal(); 
                    break;
                case 2:
                    WriteLine("Resta.__");
                    WriteLine("Por favor ingresa el primer numero: ");
                    double primerNumeroResta = double.Parse(Console.ReadLine());
                    WriteLine("Por favor ingrese el segundo numero: ");
                    double segundoNumeroResta = double.Parse(Console.ReadLine());
                    var resultadoResta = primerNumeroResta - segundoNumeroResta;
                    WriteLine("El resultado es " + resultadoResta);
                    MenuPrincipal();
                    break;
                case 3:
                    WriteLine("Multiplicacion.__");
                    WriteLine("Por favor ingresa el primer numero: ");
                    double primerNumeroMultiplicacion = double.Parse(Console.ReadLine());
                    WriteLine("Por favor ingrese el segundo numero: ");
                    double segundoNumeroMultiplicacion = double.Parse(Console.ReadLine());
                    var resultadoMultiplicacion = primerNumeroMultiplicacion * segundoNumeroMultiplicacion;
                    WriteLine("El resultado es " + resultadoMultiplicacion);
                    MenuPrincipal();
                    break;
                case 4:
                    WriteLine("Division.__");
                    WriteLine("Por favor ingresa el dividendo: ");
                    double dividendo = double.Parse(Console.ReadLine());
                    WriteLine("Por favor ingrese el divisor: ");
                    double divisor = double.Parse(Console.ReadLine());
                    var resultadoDivision = dividendo + divisor;
                    WriteLine("El resultado es " + resultadoDivision);
                    MenuPrincipal();
                    break;
                default:
                    WriteLine("Por favor ingresa una operacion valida");
                    MenuPrincipal();
                    
                    break;



            }
        }
        
    }
}
