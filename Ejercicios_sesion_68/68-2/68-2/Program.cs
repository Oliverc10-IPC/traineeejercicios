// See https://aka.ms/new-console-template for more information



namespace Invertor_Palabra // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Por favor ingresa una palabra para invertirla: ");
            var palabra= Console.ReadLine();
            Console.WriteLine("La palabra invertida es " + invertor_Palabra(palabra));
        }

        public static String invertor_Palabra(String palabra) {
            String palabraInvertida = "";
            
            for (int i = palabra.Length-1; i >=0; i--) {
                palabraInvertida += palabra[i];
            
            }
            return palabraInvertida;
        }
    }
}