// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Bienvenido");
int resultado = 0;
for (int i = 0; i < 10; i++) {
    Console.WriteLine("Por favor ingresa un numero: ");
    int numero = ToInt32(Console.ReadLine());
    if (numero % 2 == 0)
    {
        resultado = resultado + numero;

    } else { 
        resultado= resultado - numero;
    }

}
Console.WriteLine("Resultado");
Console.WriteLine(resultado);
Console.WriteLine();