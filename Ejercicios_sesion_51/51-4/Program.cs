// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Convert;
WriteLine("Bienvenido");
WriteLine();
WriteLine("Cancelacion");
WriteLine("Ingrese la cantidad a ingresar: ");
int cantidad = ToInt32(ReadLine());
if (cantidad > 0) {
    WriteLine("Por favor escoja el metodo de pago:" +
        "" +"\n"+
        "1. Tarjeta." +"\n"+
        "2. Efectivo.");
    int opc= ToInt32(ReadLine());
    switch (opc)
    {
        case 1:
            WriteLine("Ingrese el numero de cuenta a guardar");
            try
            {
                int cuenta = ToInt32(ReadLine());
                WriteLine("Se ha realizado correctamente");
            }
            catch (FormatException) {
                WriteLine("Ah ocurrido un error");
            }
            break;
        case 2: 
            WriteLine("El deposito a sido realizado con exito");

            break;
        default:
            WriteLine("La opcion no existe");
            break;

    }
}
