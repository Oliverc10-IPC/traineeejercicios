// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido");
Console.WriteLine();
Console.WriteLine("Numeros pares del 1-100 y divisibles entre 3");

for (int i = 1; i < 101; i++)
{
    if (i % 2 == 0 && i%3==0)
    {
        Console.WriteLine(i);
    }
}
