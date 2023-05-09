// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Generador_numeros // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido");
            DetectorCero();
           
        }

        private static void DetectorCero() {
            int numeroMayor = 0;
            int numeroMenor = 100000000;
            int contador = 0;
            while (true) {
                WriteLine("Por favor ingresa un numero(Se detendra al ingresar 0):");
            int numeroIngresado=int.Parse(Console.ReadLine());
                
                if (numeroIngresado == 0)
                {
                    break;
                }
                else if (numeroIngresado > numeroMayor) {
                    numeroMayor = numeroIngresado;

                } else if (numeroIngresado<numeroMenor) { 
                    numeroMenor=numeroIngresado;
                }
                contador++;
            }
            WriteLine("El numero mayor es " + numeroMayor );
            WriteLine("El numero menor es " + numeroMenor);
            int resultado = numeroMayor - numeroMenor;
            WriteLine("Diferencia entre el menor y mayor " + resultado);
            WriteLine("Cantidad de numeros ingresados: "+ contador);


        }
    }
}