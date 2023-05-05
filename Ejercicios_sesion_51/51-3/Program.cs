// See https://aka.ms/new-console-template for more information
using static System.Console;


WriteLine("Bienvenido");
WriteLine();
WriteLine("Dectector de dias.");
WriteLine();
WriteLine("Ingrese el dia de la semana que quiere evaluar: ");
string dia= ReadLine();
dia = dia.ToLower();
if (dia.Equals("lunes") || dia.Equals("martes") || dia.Equals("miercoles") || dia.Equals("jueves") || dia.Equals("viernes"))
{
    WriteLine("Aun no es fin de semana");
}
else if (dia.Equals("sabado") || dia.Equals("domingo"))
{
    WriteLine("Ya es fin de semana");
}
else {
    WriteLine("No es un dia de la semana");
}
