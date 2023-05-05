// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Bienvenido");
Console.WriteLine();
Console.WriteLine("Contador de cifras de un numero.");
Console.WriteLine("Ingrese el numero a evaluar: ");
int numero = ToInt32(Console.ReadLine());
int contadorCifras = 0;
while (numero > 0) {

    numero = numero / 10;
    contadorCifras++;

}
Console.WriteLine("El numero tiene " + contadorCifras + " cifras");
