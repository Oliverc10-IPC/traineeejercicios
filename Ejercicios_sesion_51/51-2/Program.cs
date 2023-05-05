// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Convert;
try
{
    WriteLine("Bienvenido");
    WriteLine("Sistema de evaluacion de numeros");
    WriteLine();
    WriteLine("Por favor ingresa el primer numero: ");
    int numero1 = ToInt32(ReadLine());
    WriteLine("Por favor ingresa el segundo numero: ");
    int numero2 = ToInt32(ReadLine());

    if (numero1 > numero2)
    {
        WriteLine("El numero mayor es " + numero1);
    }
    else if (numero2 > numero1)
    {
        WriteLine("El numero mayor es " + numero2);

    }
    else
    {
        WriteLine("Los numeros son iguales");
    }
}
catch (FormatException) {
    WriteLine("La entrada ha sido incorrecta");
}
