// See https://aka.ms/new-console-template for more information

using static System.Console;

namespace Palindromo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvendio");
            WriteLine();
            WriteLine("Por favor ingresa la palabra para evaluar si es Palindromo: ");
            var palabraIngresada= ReadLine().ToLower();
            palabraIngresada = palabraIngresada.Trim();//Eliminacion de espacion al inicio y final
            palabraIngresada = palabraIngresada.Replace(" ","");//Eliminacion de espacion entre la palabra
            // Evaluacion para imprimir mensaje
            if (EsPalindromo(palabraIngresada)) { 
                WriteLine("La palabra si es palindromo");
            }
            else
            {
                WriteLine("No es palindromo");
            }

        }
        // Funcion para determinar si es palindromo
        private static bool EsPalindromo(String palabra) {
            int contadorInverso = palabra.Length - 1; //contador inverso
            for (int i = 0; i < palabra.Length/2; i++)
            {               
                if (!(palabra[i].Equals(palabra[contadorInverso])))
                {
                        return false;
                        
                }
                contadorInverso--;    
                
                

            }
            return true;
        }
    }
}