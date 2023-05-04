// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

WriteLine("Bienvenido");
WriteLine("Sistema de evaluacion de numeros");
WriteLine("Este sistema de ayuda a evaluar un numero si: ");
WriteLine("- Es mayor a 100.");
WriteLine("- Es par.");
WriteLine("- Es primo");
WriteLine();
WriteLine("Por favor ingresa un numero: ");
try
{
    int numero = Int32.Parse(ReadLine());
    if (numero > 100)
    {
        WriteLine("El numero " + numero + " es mayor a 100");
    }
    else
    {
        WriteLine("El numero " + numero + " no es mayor a 100");
    }
    if (numero % 2 == 0)
    {
        WriteLine("El numero " + numero + " es par");
    }
    else
    {
        WriteLine("El numero " + numero + " es impar");
    }
    int contador = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }

    }
    if (contador == 2)
    {
        WriteLine("El numero "+numero+" es primo");
    }
    else
    {
        WriteLine("El numero "+numero+" no es primo");
    }

}




catch (FormatException)
{
    WriteLine("Por favor ingresa un numero valido.");

}

