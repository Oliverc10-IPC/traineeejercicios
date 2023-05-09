// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Billetes_Monedas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static int contBilletes100 = 0;
        public static int contBilletes50 = 0;
        public static int contBilletes20 = 0;
        public static int contBilletes10 = 0;
        public static int contBilletes5 = 0;
        public static int contMonedas1 = 0;
       

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido");
            WriteLine();
            WriteLine("Por favor ingresa la cantidad a reducir: ");
            WriteLine();
            int cantidad=int.Parse(ReadLine());
            Reducidor(cantidad);
            WriteLine();
            WriteLine("Cantidades Desglosadas.__");
            WriteLine("Billetes de 100: " + contBilletes100);
            WriteLine("Billetes de 50: " + contBilletes50);
            WriteLine("Billetes de 20: " + contBilletes20);
            WriteLine("Billetes de 10: " + contBilletes10);
            WriteLine("Billetes de 5: " + contBilletes5);
            WriteLine("Monedas de 1: " + contMonedas1);



        }
        public static void Reducidor(int  cantidad ) {
            if (cantidad % 100 == 0 && cantidad > 0) {
                contBilletes100++;
                Reducidor(cantidad - 100);

            } else if (cantidad % 50 == 0 && cantidad > 0) {
                contBilletes50++;
                Reducidor(cantidad - 50);
            }
            else if (cantidad % 20 == 0 && cantidad > 0)
            {
                contBilletes20++;
                Reducidor(cantidad - 20);
            }
            else if (cantidad % 10 == 0 && cantidad > 0)
            {
                contBilletes10++;
                Reducidor(cantidad - 10);
            }
            else if (cantidad % 5 == 0 && cantidad > 0)
            {
                contBilletes5++;
                Reducidor(cantidad - 5);
            }
            else if (cantidad % 1 == 0 && cantidad > 0)
            {
                contMonedas1++;
                Reducidor(cantidad - 1);
            }
        }
            
        }
    }

