// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Bienvenido");
Console.WriteLine("");
Console.WriteLine("Por favor ingresa un numero entre 1 y 1000");
int numero = ToInt32(Console.ReadLine());
if (numero < 1001 && numero > 0)
{
    Console.WriteLine("Numero valido");
    int resultadoSuma = 0;
    for (int i = 0; i < numero+1; i++)
    {
        resultadoSuma += i;
    }
    double media = resultadoSuma / numero;
    Console.WriteLine();
    Console.WriteLine("La suma de todos los numeros anteriores es: " + resultadoSuma);
    Console.WriteLine("La media de todos los numeros anteriores es: " + media);
}
else {
    Console.WriteLine("El numero no esta en el rango establecido");
}

