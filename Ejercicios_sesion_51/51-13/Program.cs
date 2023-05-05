// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Bienvenido");
Console.WriteLine("Comprobacion de numero primo");
Console.WriteLine();
Console.WriteLine("Por favor ingresa el numero a evaluar: ");
int numero = ToInt32(Console.ReadLine());
int contador = 0;
for (int i = 1; i <=numero; i++) {
    if (numero%i==0) { 
        contador++;
    }

}
if (contador == 2)
{
    Console.WriteLine("El numero es primo");
}
else {
    Console.WriteLine("El numero no es primo");
}
