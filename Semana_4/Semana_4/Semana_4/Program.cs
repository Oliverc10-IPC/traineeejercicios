using static System.Console;

namespace Biblioteca // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Material libro1 = new Libro("Pinoccio", "Carlo Collodi");
            Material revista1 = new Revista("Time", "2da");

            biblioteca.AgregarMaterial(libro1);
            biblioteca.AgregarMaterial(revista1);
            biblioteca.PrestarMaterial(libro1);
            biblioteca.DevolverMaterial(libro1);
            List<Material> opciones = biblioteca.BuscarPorTitulos("Pino");
            foreach (Material mat in opciones)
            {
                WriteLine(mat.nombre);
            }


        }
    }
    //Clase Abstrata Material
    public abstract class Material
    {
        public String nombre { set; get; }
        public bool disponible { set; get; }

    }
    //Clase Libro heredando de Material
    public class Libro : Material
    {

        String Autor { set; get; }


        public Libro(String nombre, String Autor)
        {
            this.nombre = nombre;
            this.Autor = Autor;
            this.disponible = true;
        }

        public void Prestar()
        {
            this.disponible = false;

        }
        public void Devolver()
        {
            this.disponible = true;

        }
    }
    //Clase Revista heredando de Material
    public class Revista : Material
    {

        String Edicion { set; get; }

        public Revista(String nombre, String Edicion)
        {
            this.nombre = nombre;
            this.Edicion = Edicion;
            this.disponible = true;
        }

        public void Prestar()
        {
            this.disponible = false;

        }

    }
    //Interfaz Biblioteca
    interface IBiblioteca
    {

        public void AgregarMaterial(Material material);
        public List<Material> BuscarPorTitulos(string titulo);
        public void PrestarMaterial(Material material);
        public void DevolverMaterial(Material material);


    }
    //Clase Biblioteca implementando la interfaz biblioteca
    public class Biblioteca : IBiblioteca
    {
        List<Material> lbiblioteca { set; get; }

        public Biblioteca()
        {
            lbiblioteca = new List<Material>();

        }
        public void AgregarMaterial(Material material)
        {

            lbiblioteca.Add(material);

        }

        public List<Material> BuscarPorTitulos(string titulo)
        {
            List<Material> opcionesPosibles = new List<Material>();
            foreach (Material mat in lbiblioteca)
            {
                if (mat.nombre.Contains(titulo))
                {
                    opcionesPosibles.Add(mat);
                }
            }
            return opcionesPosibles;

        }

        public void DevolverMaterial(Material material)
        {
            if (material.GetType() == typeof(Libro))
            {
                material = (Libro)material;
                WriteLine("Se devuelve el libro");
                material.disponible = true;


            }
            else if (material.GetType() == typeof(Revista))
            {
                WriteLine("Se devuelve la revista");
                material.disponible = true;
            }

        }

        public void PrestarMaterial(Material material)
        {
            if (material.disponible)
            {
                WriteLine("Libro disponible se puede prestar");
                material.disponible = false;
            }
            else
            {
                WriteLine("El libro no se encuentra disponible");

            }
        }
    }
}