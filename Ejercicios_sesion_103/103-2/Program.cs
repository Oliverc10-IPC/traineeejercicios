using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            WriteLine("Bienvenido");
            for (int i = 0; i <= 4; i++)
            {
                WriteLine("Por favor ingresa el nombre: ");
                string nombre = ReadLine();
                WriteLine("Por favor ingresa la edad:");
                int edad = int.Parse(ReadLine());
                WriteLine("1. Alumno\n2. Profesor\nEscoge una opcion:");
                int opcion = int.Parse(ReadLine());
                switch (opcion) {

                    case 1:
                        WriteLine("Por favor ingresa el numero de alumno");
                        int numero = int.Parse(ReadLine());
                        Persona persona1= new Alumno(nombre,edad,numero);
                        personas.Add(persona1);
                            break;
                    case 2:
                        WriteLine("Por favor ingresa la materia que impartira:");
                        string materia = ReadLine();
                        Persona persona2 = new Profesor(nombre, edad, materia);
                        personas.Add(persona2);
                        
                        break;
                
                
                }
                
                                
            }

            foreach (Persona persona in personas)
            {
                
                    WriteLine($"Nombre: {persona.nombre}\n Edad: {persona.edad}");
                
            }

        }


    }


    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }


        public Persona(string nombre, int edad)
        {

            this.nombre = nombre;
            this.edad = edad;

        }


    }

    public class Alumno : Persona
    {
        public int numero { get; set; }


        
        public Alumno(string nombre, int edad, int numero) : base(nombre, edad)
        {
            this.nombre=nombre;
            this.edad=edad;
            this.numero = numero;

        }
    }
    public class Profesor : Persona
    {
        public string materia { get; set; }
        public Profesor(string nombre, int edad, string materia) : base(nombre, edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.materia = materia;
        }
    }
}