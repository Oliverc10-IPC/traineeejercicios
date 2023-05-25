// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Data;
using static System.Console;

namespace Lector // Note: actual namespace depends on the project name.
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
            WriteLine("Por favor ingresa una frase para poder evaluarla:");
            string frase = ReadLine();
            frase = frase.Trim();
            if (LongitudFrasePalabra(frase))
            {
                WriteLine("Palabra Aceptada\n");
                WriteLine($"Longitud de la cadena: {frase.Length}\n");
                RemplazoLetra(frase);
                WriteLine($"Frase en mayusculas: {frase.ToUpper()}\n" );
                WriteLine($"Frase en minusculas: {frase.ToLower()}\n");
                EliminarPrimerasTresLetras(frase);
                ObtenerPosiciones(frase);
                WriteLine($"Frase Invertida: {InvertirPalabra(frase)}");
                WriteLine($"Cantidad de Palabras: {NumeroDePalabra(frase)}");
                WriteLine($"Tercera Palabra: {ObtenerTerceraPalabra(frase)}");
                MenuPrincipal();



            }

            else
            {
                WriteLine("Palabra Denegada");
                
                MenuPrincipal();
            }
            WriteLine();



        }
        public static bool LongitudFrasePalabra(string frase) { 
            string[] palabras= frase.Split(' ');
            if (frase.Length >= 20 && palabras.Length>=4) {
                return true;
            }
            return false;
        }
        public static void RemplazoLetra(string frase) { 
            frase = frase.Trim();
            frase = frase.Replace("a", "x");
            frase = frase.Replace("A", "X");
            WriteLine("Frase Reemplazada");
            WriteLine(frase);
            WriteLine();

        }
        public static void EliminarPrimerasTresLetras(string frase) {
            string primerasTresLetras = frase.Remove(3);
            frase=frase.Replace(primerasTresLetras, "");
            WriteLine($"La frase sin las primeras 3 letras es: {frase}.");
        
        }
        public static void ObtenerPosiciones(string frase)
        {
            frase= frase.Replace(" ",""); 
            string primerasTresLetras = frase.Remove(4);
            frase = frase.Replace(primerasTresLetras, "");
            string ultimasDiezLetras= frase.Remove(5);
            WriteLine($"La frase sin las primeras 3 letras es: {ultimasDiezLetras}.");

        }
        public static string InvertirPalabra(string frase) {
            string fraseInvertida = "";
            for (int i = frase.Length-1; i >= 0; i--) { 
                fraseInvertida += frase[i]; 
            }
            return fraseInvertida;  
        }
        public static int NumeroDePalabra(string frase)
        {
            string[] palabras = frase.Split(' ');
            int n = palabras.Length;
            return n;
        }
        public static string ObtenerTerceraPalabra(string frase) {
            
                string[] palabras = frase.Split(' ');
            return palabras[2];
            
        }

    }
}