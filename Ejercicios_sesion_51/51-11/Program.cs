// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Bienvenido");
Console.WriteLine();
Console.WriteLine("Por favor ingresa un numero entre 1 y 7");
int dia = ToInt32(Console.ReadLine());
switch (dia)
{
	case 1:
		Console.WriteLine("1- Lunes");
		break;
    case 2:
        Console.WriteLine("2- Martes");
        break;
    case 3:
        Console.WriteLine("3- Miercoles");
        break;
    case 4:
        Console.WriteLine("4- Jueves");
        break;
    case 5:
        Console.WriteLine("5- Viernes");
        break;
    case 6:
        Console.WriteLine("6- Sabado");
        break;
    case 7:
        Console.WriteLine("7- Domingo");
        break;


    default:
        Console.WriteLine("El dia no existe...");
		break;
}