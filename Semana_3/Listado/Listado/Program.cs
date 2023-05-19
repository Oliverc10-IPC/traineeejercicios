// See https://aka.ms/new-console-template for more information

using static System.Console;
using Alumnos;

namespace MenuPrincipal // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> Alumnos = new List<Alumno>();
            Alumno alumno1 = new Alumno("Alina ", "Falcon", 1, "Ingenieria en Electrinica", generadorNotas());
            Alumno alumno2 = new Alumno("Oier ", "Llorens", 2, "Ingenieria en Electrinica", generadorNotas());
            Alumno alumno3 = new Alumno("Iago  ", "Arteaga", 3, "Ingenieria en Electrinica", generadorNotas());
            Alumno alumno4 = new Alumno("Francisco  ", "Paredes", 4, "Ingenieria en Electrinica", generadorNotas());
            Alumno alumno5 = new Alumno("Manel  ", "Manzano", 5, "Ingenieria en Electrinica", generadorNotas());
            Alumnos.Add(alumno1);
            Alumnos.Add(alumno2);
            Alumnos.Add(alumno3);
            Alumnos.Add(alumno4);
            Alumnos.Add(alumno5);
            MenuPrincipal(Alumnos);





        }
        public static void MenuPrincipal(List<Alumno> Alumnos)
        {
            WriteLine("Bienvenido");
            WriteLine();
            WriteLine("1. Ver listado completo");
            WriteLine("2. Ver alumnos aprobados.");
            WriteLine();
            WriteLine("Por favor escoge una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    impresionListadoCompleto(Alumnos);
                    WriteLine();
                    MenuPrincipal(Alumnos);
                    break;
                case 2:
                    impresionListadoAprobados(Alumnos);
                    WriteLine();
                    MenuPrincipal(Alumnos); 
                    break;
                default:

                    WriteLine("Por favor escoja una opcion correcta");
                    MenuPrincipal(Alumnos);
                    break;
            }
        }

            public static List<double> generadorNotas()
            {
                List<double> notas = new List<double>();
                Random rnd = new Random();
                int numeroNotas = rnd.Next(5, 10 + 1);
                for (int i = 0; i < numeroNotas; i++)
                {
                    notas.Add(rnd.Next(1, 10 + 1));

                }

                return notas;

            }
            public static void impresionListadoCompleto(List<Alumno> alumnos)
            {
                foreach (var alumno in alumnos)
                {
                    WriteLine("-------------------------------------------");
                    WriteLine($"Nombre del Alumno: {alumno.Nombre} {alumno.Apellido}\nID: {alumno.Id}\nCarrera: {alumno.Carrera}\nPromedio de Notas: {alumno.promedioNotas(alumno.Notas)}");
                }

            }
            public static void impresionListadoAprobados(List<Alumno> alumnos)
            {
                foreach (var alumno in alumnos)
                {
                    if (alumno.promedioNotas(alumno.Notas) >= 6)
                    {
                        WriteLine("-------------------------------------------");
                        WriteLine($"Nombre del Alumno: {alumno.Nombre} {alumno.Apellido}\nID: {alumno.Id}\nPromedio de Notas: {alumno.promedioNotas(alumno.Notas)}");
                    }

                }

            }
        }
    }
