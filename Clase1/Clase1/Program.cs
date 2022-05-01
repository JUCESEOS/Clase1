// See https://aka.ms/new-console-template for more information
using ProgramacionPOO;

Console.WriteLine("Esto es una prueba de mi primera Aplicación");
Console.WriteLine("--------------------------------------------");

try
{
    Console.WriteLine(new Fecha(2022, 1, 20));
    Console.WriteLine(new Fecha(2020, 10, 30));
    Console.WriteLine(new Fecha(2024, 2, 29));
}
catch (Exception Error)
{
    Console.WriteLine(Error.Message);
}