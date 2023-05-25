using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            WriteLine("Bienvenido");
            for (int i = 0; i <= 4; i++) {
                WriteLine("Por favor ingresa un nombre: ");
                nombres.Add(ReadLine());
            }
            WriteLine("Por favor ingresa un nombre para buscarlo en la lista: ");
            string nombre= ReadLine();
            foreach (string n in nombres) {
                if (n == nombre)
                {
                    WriteLine($"El nombre {nombre} si se encuentra en la lista");
                    break;
                }
                          
            }

        }
    }
}