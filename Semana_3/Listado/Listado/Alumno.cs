using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos

{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string Carrera { get; set; }
        public List<double> Notas { get; set; }
    
        public Alumno() { 
            Nombre = string.Empty;
            Apellido = string.Empty;
            Id = 0;
            Carrera = string.Empty;
            Notas = new List<double>();      
        
        }
        public Alumno(string nombre, string apellido, int id, string carrera, List<double> notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = id;
            Carrera = carrera;
            Notas = notas;
        }
        public double promedioNotas(List<double> notas) {
            double notasSumadas = 0;
            double contador = 0;
            foreach (double nota in notas) { 
                notasSumadas += nota;
                contador++;
            }
            return notasSumadas / contador; 
        
        }
      
    }

}
