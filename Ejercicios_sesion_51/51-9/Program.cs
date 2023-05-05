// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido");
Console.WriteLine();
Console.WriteLine("Numeros pares del 1-100 dentro de un array");
int[] numeros = new int[50];
int contador = 0;
for (int i = 1; i < 101; i++)
{
    if (i % 2 == 0)
    {
        numeros[contador] = i;
        contador++;
    }
}
for (int i = 0; i < numeros.Length; i++) {
    Console.WriteLine(numeros[i]);
} 
