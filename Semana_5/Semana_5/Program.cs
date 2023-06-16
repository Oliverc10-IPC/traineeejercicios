using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine();
            Console.WriteLine("1. Empezar Juego");
            Console.WriteLine("2. Cargar Juego");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Por favor escoge una opcion:");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    Console.WriteLine("Nueva Partida.");
                    Console.WriteLine("Jugador 1");
                    Console.WriteLine();
                    Console.WriteLine("Nombre Jugador 1:");
                    string nombreJ1 = Console.ReadLine();
                    Jugador jugador1 = new Jugador(nombreJ1);
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Jugador 2");
                    Console.WriteLine();
                    Console.WriteLine("Nombre Jugador 2:");
                    string nombreJ2 = Console.ReadLine();
                    Jugador jugador2 = new Jugador(nombreJ2);
                    Partida nuevaPartida = new Partida(jugador1, jugador2);
                    nuevaPartida.GuardarPartida("C:\\Users\\olive\\OneDrive\\Escritorio\\partida.txt");
                    

                                    
                    break;

                    case 2:
                    Console.WriteLine();
                    Partida nuevaPartida1 = new Partida();
                    nuevaPartida1= nuevaPartida1.CargarPartida("C:\\Users\\olive\\OneDrive\\Escritorio\\partida.txt");
                    Console.WriteLine($"Jugador 1: {nuevaPartida1.jugador1.Nombre}\nJugador 2: {nuevaPartida1.jugador2.Nombre}\n");
                    Console.WriteLine("Se cargo la partida");

                    break;
                    case 3:
                    Environment.Exit(0);
                    break;
            
            }



        }
        //Clase partida
        public class Partida
        {
            public Jugador jugador1 { get; set; }
            public Jugador jugador2 { get; set; }

            public Partida(){
                
            }
            public Partida(Jugador jugador1, Jugador jugador2)
            {
                this.jugador1 = jugador1;
                this.jugador2 = jugador2;

            }
            //Metodo GuardarPartida
            public void GuardarPartida(string ruta) {
                try
                {
                    FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate);
                    string datos = $"{this.jugador1.Nombre},{this.jugador1.Nivel},{this.jugador1.PuntosVida},{this.jugador1.NumeroReinicio};{this.jugador2.Nombre},{this.jugador2.Nivel},{this.jugador2.PuntosVida},{this.jugador2.NumeroReinicio}\n";
                    archivo.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    archivo.Close();
                    Console.WriteLine("Se guardo la partida.");

                }
                catch (Exception ex)
                {
                    string mensaje = ex.Message;
                    string dondePaso = ex.Source;
                    string strack = ex.StackTrace;
                    string fechaHora = DateTime.Now.ToString("MM-dd-yyyy");

                    FileStream errores = new FileStream($"Errores{fechaHora}.txt", FileMode.OpenOrCreate);
                    string datos = $"{mensaje}\n{dondePaso}\n{strack}\n";
                    errores.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    errores.Close();
                    Console.WriteLine("Se creo el archivo de errores");

                }





            }
            //Metodo para Cargar la Partida
            public Partida CargarPartida(string ruta) {

                Partida partida;    
                byte[] infoArchivo = new byte[200000];
                try
                {
                    FileStream archivoData = new FileStream(ruta, FileMode.Open);
                    archivoData.Read(infoArchivo, 0, (int)archivoData.Length);

                    string texto = ASCIIEncoding.ASCII.GetString(infoArchivo);


                    string[] jugadoresDatos = texto.Split(";");
                    string[] datosJugador1 = jugadoresDatos[0].Split(",");
                    string[] datosJugador2 = jugadoresDatos[1].Split(",");

                    jugador1 = new Jugador(datosJugador1[0], int.Parse(datosJugador1[1]), int.Parse(datosJugador1[2]), int.Parse(datosJugador1[3]));
                    jugador2 = new Jugador(datosJugador2[0], int.Parse(datosJugador2[1]), int.Parse(datosJugador2[2]), int.Parse(datosJugador2[3]));

                    partida = new Partida(jugador1, jugador2);
                    
                    return partida;

                }
                catch (Exception ex)
                {

                    string mensaje = ex.Message;
                    string dondePaso = ex.Source;
                    string strack = ex.StackTrace;
                    string fechaHora = DateTime.Now.ToString("MM-dd-yyyy");

                    FileStream errores = new FileStream($"Errores{fechaHora}.txt", FileMode.OpenOrCreate);
                    string datos = $"{mensaje}\n{dondePaso}\n{strack}\n";
                    errores.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    errores.Close();
                    Console.WriteLine("Se creo el archivo de errores");

                }


                return null;

            }
        }
        // Clase Jugador
        public class Jugador { 
        
            public string Nombre { get; set; }
            public int Nivel { get;set; }

            public int PuntosVida { get; set; }

            public int NumeroReinicio { get; set; } 
            
            public Jugador(string Nombre) { 
                this.Nombre = Nombre;
                this.Nivel = 1; 
                this.NumeroReinicio = 0;
                this.PuntosVida = 100;   

            
            }
            public Jugador(string Nombre, int Nivel, int PuntosVida, int NumeroReinicio )
            {
                this.Nombre = Nombre;
                this.Nivel = Nivel;
                this.NumeroReinicio=NumeroReinicio;
                this.PuntosVida=PuntosVida;

            }
           
            // Metodo para guardar datos del jugador
            public void GuardarDatosJugador(string ruta)
            {
                try
                {
                    FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate);
                    string datos = $"{this.Nombre},{this.Nivel},{this.NumeroReinicio},{this.PuntosVida}\n";
                    archivo.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    archivo.Close();
                    Console.WriteLine("Se creo el archivo");

                }catch (Exception ex)
                {
                    string mensaje = ex.Message;
                   string dondePaso = ex.Source;
                    string strack = ex.StackTrace;
                    string fechaHora = DateTime.Now.ToString("MM-dd-yyyy");
                        
                    FileStream errores = new FileStream($"Errores{fechaHora}.txt", FileMode.OpenOrCreate);
                    string datos = $"{mensaje}\n{dondePaso}\n{strack}\n";
                    errores.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    errores.Close();
                    Console.WriteLine("Se creo el archivo de errores");


                }
            }
            //Metodo para Cargar jugadores a una lista
            public List<Jugador> CargarDatosJugador(string ruta) {
                List<Jugador> JugadoresCargados = new List<Jugador>();
                byte[] infoArchivo = new byte[200000];
                try
                {
                    FileStream archivoData = new FileStream(ruta, FileMode.Open);
                    archivoData.Read(infoArchivo, 0, (int)archivoData.Length);
                    
                    string texto = ASCIIEncoding.ASCII.GetString(infoArchivo);
                    
                    
                    string[] jugadores_datos = texto.Split("\n");
                    
                    foreach (string n in jugadores_datos)
                    {
                        
                        string[] jugadoresCargadosLista = n.Split(",");
                        
                        JugadoresCargados.Add(new Jugador(jugadoresCargadosLista[0], int.Parse(jugadoresCargadosLista[1]), int.Parse(jugadoresCargadosLista[2]), int.Parse(jugadoresCargadosLista[3])));
                       
                    }
                    Console.WriteLine("Se cargaron todos los jugadores");
                    return JugadoresCargados;
                }
                catch (Exception ex) {

                    string mensaje = ex.Message;
                    string dondePaso = ex.Source;
                    string strack = ex.StackTrace;
                    string fechaHora = DateTime.Now.ToString("MM-dd-yyyy");

                    FileStream errores = new FileStream($"Errores{fechaHora}.txt", FileMode.OpenOrCreate);
                    string datos = $"{mensaje}\n{dondePaso}\n{strack}\n";
                    errores.Write(ASCIIEncoding.ASCII.GetBytes(datos), 0, datos.Length);
                    errores.Close();
                    Console.WriteLine("Se creo el archivo de errores");

                }

                

                return JugadoresCargados;
            }

            
              
        
        
        }
    }

}
