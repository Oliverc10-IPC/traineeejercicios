// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Detector // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido");
            WriteLine("");
            WriteLine("Por favor ingresa el caracter a evaluar");
            var dato = ReadLine();
            if (EsNumero(dato)) {
                WriteLine("Es un numero");
            } else if (EsVocal(dato)) {
                Write("Es una Vocal");

            } else if (EsConsonante(dato)) {
                WriteLine("Es una Consonante");
            }
        
        }
        private static bool EsConsonante(String dato)
        {
            String[] vocales = { "a", "e", "i", "o", "u" };
            dato = dato.ToLower();
            for (int i = 0; i < vocales.Length; i++)
            {

                if (dato.Equals(vocales[i]))
                {
                    return false;
                }

            }
            return true;
        }
        private static bool EsVocal(String dato) {
            String[] vocales = { "a", "e", "i", "o", "u" };
            dato=dato.ToLower();
            for (int i = 0; i < vocales.Length; i++) {

                if (dato.Equals(vocales[i])) {
                    return true;
                }
            
            }
            return false;
        }
        private static bool EsNumero(String dato) {
            try
            {
                int numero = int.Parse(dato);
                return true;

            }
            catch (FormatException) {
                return false;

            }
            
        }
    }
}
