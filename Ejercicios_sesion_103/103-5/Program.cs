using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto.sumar(43,2);
        }
    }

    public static class Producto {

        public static int sumar(int valor1, int valor2) { 
            return valor1 + valor2;
        }
    
     }
}
