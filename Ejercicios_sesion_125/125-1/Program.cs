using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Diccionario // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            LlenadoDiccionario(dic);



        }
        public static void LlenadoDiccionario(Dictionary<int,string> dic) {
            bool activo = true;
            
            while(activo) { 
                WriteLine("Por favor ingresa una clave:");
                int clave= int.Parse(ReadLine());
                WriteLine("Por favor ingresa un valor:");
                string valor= ReadLine();
                valor=valor.Trim();
                if( clave == 0 || valor.Equals("0") )
                {
                    WriteLine("Por favor introduce una cadena de 2 letras:");
                    string subCadena= ReadLine();
                    subCadena = subCadena.Trim();
                    if (subCadena.Length == 2)
                    {
                        foreach (KeyValuePair<int, string> par in dic)
                        {
                            if (par.Value.Contains(subCadena))
                            {

                                WriteLine($"Clave: {par.Key}.\nValor: {par.Value}");


                            }
                        }

                    }
                    else {

                        WriteLine("La cadena debe de ser de 2 letras:");
                        LlenadoDiccionario(dic);
                    }
                    activo = false;

                }
                else
                {
                    dic.Add(clave, valor);
                }
                
            }
                    
        
        }
    }
}