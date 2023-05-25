using static System.Console;

namespace Abecedario // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String abecedario = "abcdefghijklmnopqrstuvwxyz";
            abecedario=abecedario.ToUpper();   
            for (int i= abecedario.Length-1; i>=0;i--) {
                WriteLine(abecedario[i]);   

            }
        }
    }
}