using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            WriteLine("Bienvenido");    
            for (int i = 0; i <= 4; i++) { 
                WriteLine("Por favor ingresa el nombre: ");
                string nombre=ReadLine();
                WriteLine("Por favor ingresa la edad:");  
                int edad=int.Parse(ReadLine());
                Persona persona = new Persona(nombre,edad);
                personas.Add(persona);
            }

            foreach (Persona persona in personas) {
                if (persona.edad>=18)
                {
                    WriteLine($"Nombre: {persona.nombre}\n Edad: {persona.edad}");   
                }
            }
            
        }


    }


    public class Persona {
        public string nombre { get; set; }
        public int edad { get; set; }


        public Persona(string nombre, int edad) { 
                
            this.nombre = nombre;
            this.edad = edad;
                    
        }
          
    
    }
}