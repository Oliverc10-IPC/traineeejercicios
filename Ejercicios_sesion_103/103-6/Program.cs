using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1= new Animal("blanco", true,5);
        }
    }
    public class Animal { 
        public string color { get; set; }
        public bool esDomestrico { get; set; }
        public int numeroPatas { get; set; }
        public Animal(string color,bool esDomestico, int numeroPatas)
        {
            this.color = color;
            this.esDomestrico= esDomestico;
            this.numeroPatas=numeroPatas;

        }
    
    
    }
}