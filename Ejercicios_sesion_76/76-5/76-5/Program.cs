using System.Collections;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Numeros = new ArrayList();
            WriteLine("Bienvenido");
            WriteLine();
            WriteLine("Por favor ingresa el tamanio de la lista: ");
            int tamanioLista= int.Parse(ReadLine());

            for (int i = 0; i < tamanioLista; i++)
            {
                WriteLine("Por favor ingresa un numero: ");
                int numero = int.Parse(ReadLine());
                Numeros.Add(numero);
            }
            WriteLine();
            WriteLine("Lista ingresada");
            foreach (var item in Numeros)
            {
                WriteLine(item);
            }
            WriteLine();
            WriteLine("Por favor ingresa un nuevo numero: ");
            int nuevoNum= int.Parse(ReadLine());    
            WriteLine("Por favor ingresa la posicion para ingresar el nuevo elemento: ");
            int nuevaPosicion= int.Parse(ReadLine());  
            
            Numeros.Insert(nuevaPosicion, nuevoNum);
            WriteLine();
            WriteLine("Lista modificada");
            foreach (var item in Numeros)
            {
                WriteLine(item);
            }

        }
    }
}