// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Menu();

    }
    //Menu principal
    static async Task Menu()
    {
        try { 
        Console.WriteLine("Bienvenido");
        Console.WriteLine("----------");
        Console.WriteLine();
        Console.WriteLine("1. Crear Chiste.");
        Console.WriteLine("2. Buscar Chiste.");
        Console.WriteLine("3. Salir");
        Console.WriteLine("Escoge una opcion: "); 
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion) {
            case 1:
                await CrearConexion();
                await Menu();
                break;
            case 2:
                Console.WriteLine("");
                Console.WriteLine("Ingrese una palabra para buscar: ");
                string  palabra = Console.ReadLine();
                busquedaJoke(palabra);
                break;
            case 3:
                Environment.Exit(0);
                break;

        }
        }catch (Exception ex) { 
            Console.WriteLine($"Elige una opcion correcta");
            await Menu();
            
        }
    }
    static async Task CrearConexion()
    {
        // Crear una instancia del cliente HTTP
        using (HttpClient client = new HttpClient())
        {
            try
            {
                
                // Realizar una solicitud GET a la API de Chuck Norris
                HttpResponseMessage response = await client.GetAsync("https://api.chucknorris.io/jokes/random");
                response.EnsureSuccessStatusCode();

                // Leer la respuesta como una cadena JSON
                string json = await response.Content.ReadAsStringAsync();

                // Extraer el chiste de la respuesta JSON
                Joke joke = ExtractJoke(json);
                if (!ValidacionJoke(joke)) // Valida si el chiste no esta duplicado por ID
                {
                    // Guardar el chiste en un archivo de texto
                    SaveJokeToFile(joke);
                    Console.WriteLine("Chiste guardado exitosamente.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al procesar la solicitud: " + ex.Message + ex.StackTrace);

            }
        }
    }

    static Joke ExtractJoke(string json)
    {
        // Deserializar la respuesta JSON y extraer el chiste
        dynamic jsonObject = JsonConvert.DeserializeObject(json);
        string valor = jsonObject["value"];
        string id = jsonObject["id"];
        Joke joke = new(id,valor);
       

        return joke;
    }
    // Guarda el chiste en un archivo de texto
    static async void SaveJokeToFile(Joke joke)
    {
        try {                
        string data = $"{joke.Id};{joke.Value}\n";
        FileStream file = new FileStream("ChistesID.txt", FileMode.Append);
        file.Write(ASCIIEncoding.ASCII.GetBytes(joke.Id+";"), 0, joke.Id.Length+1);
        file.Close();
        // Escribir el chiste en un archivo de texto
        FileStream file1 = new FileStream("Chistes.txt", FileMode.Append);
        file1.Write(ASCIIEncoding.ASCII.GetBytes(data), 0, data.Length);
        file1.Close();
        } catch (Exception ex) { 
            
            Console.WriteLine("Error al guardar el achivo");
            await Menu();
        }
    }
    // Valida si el chiste existe en el archivo de Id
    static bool ValidacionJoke(Joke joke)
    {
        try
        {
            byte[] infoArchivo = new byte[5000];
            FileStream file = new FileStream("ChistesID.txt", FileMode.Open);
            file.Read(infoArchivo, 0, (int)file.Length);
            file.Close();
            string contenido = ASCIIEncoding.ASCII.GetString(infoArchivo); 
            string[] idChistes= contenido.Split(';');
            foreach (string id in idChistes)
            {
                if (id.Equals(joke.Id))
                {
                    return true;
                }
            }
            return false;

        }catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return false;
        }

    }
    //Busqueda de Chiste por palabra
    static async void busquedaJoke(string palabra)
    {
        try
        {
            List<string> posiblesOpciones = new List<string>();
            byte[] infoArchivo = new byte[500000];
            FileStream file = new FileStream("Chistes.txt", FileMode.Open);
            file.Read(infoArchivo, 0, (int)file.Length);
            file.Close();
            string contenido = ASCIIEncoding.ASCII.GetString(infoArchivo);
            string[] chistes = contenido.Split('\n');
            for (int i = 0; i <= chistes.Length - 2; i++)
            {
                string[] chiste = chistes[i].Split(";");
               
                    if (chiste[1].Contains(palabra))
                    {
                        posiblesOpciones.Add(chiste[1]);

                    }

                


            }
           
            if (infoArchivo.Length > 0) {
                int contador = 1;
                Console.WriteLine("Chistes Posibles.");
                foreach (string opcion in posiblesOpciones)
                {
                    Console.WriteLine(contador);
                    Console.WriteLine(opcion);
                    contador++;

                }
                await Menu();
            }
            else
            {
                Console.WriteLine("Sin Opciones");
                await Menu();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo.");
        }
        


    }
    //Clase Objeto Chiste
    public class Joke { 
        public string Id { get; set; }
        public string Value { get; set; }

        public Joke(string id, string value)
        {
            this.Id = id;
            this.Value = value;
            
        }



    } 
}