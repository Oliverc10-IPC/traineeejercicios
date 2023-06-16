using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Por favor ingresa un numero para poder crear el animal");
            var opcion= int.Parse(Console.ReadLine()); 
            foreach(int i in Enum.GetValues(typeof(Animales))) {
                if (i == opcion) { 
                     String nombreAnimal = Enum.GetName(typeof(Animales), opcion);
                     Animal animal= new Animal(nombreAnimal); 
                    Console.WriteLine($"Animal: {animal.tipoAnimal} Creado");
                    Console.WriteLine($"El valor {opcion} pertenece al animal {nombreAnimal}");
                }
            
            }
           

        }
    }
    public enum Animales:int 
    {
        perro = 5,
        gato = 8,
        canario = 2,
        caballo = 12


    }
    public class Animal
    {
        public string tipoAnimal { get;set; }
        
        public Animal(string tipoAnimal) {
           this.tipoAnimal = tipoAnimal;    
        

        }
    }



    }
