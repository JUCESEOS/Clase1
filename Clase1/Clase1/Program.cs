// See https://aka.ms/new-console-template for more information
using ProgramacionPOO;


Console.WriteLine("Esto es una prueba de 2 da  Aplicación");
Console.WriteLine("--------------------------------------------");

Empleados Empleado1 = new EmpleadoAsalariado()
{
    Id = "13541294",
    Nombres = "Julio Cesar",
    Apellidos = "Serrano Osma",
    FechaNacimiento = new Fecha(1978, 06, 12),
    FechaIngreso = new Fecha(2021, 4, 1),
    Activo = true,
    Salario = 4000000M
};

Empleados Empleado2 = new EmpleadoXComision()
{
    Id = "13828769",
    Nombres = "Efrain",
    Apellidos = "Serrano Garzon",
    FechaNacimiento = new Fecha(1953, 10, 17),
    FechaIngreso = new Fecha(2021, 4, 1),
    Activo = true,
    Comision = 0.03F,
    Ventas = 320000000M
};

Console.WriteLine(Empleado1.ToString());
Console.WriteLine(Empleado2.ToString());
/*try

Console.WriteLine("Esto es una prueba de mi primera Aplicación");
Console.WriteLine("--------------------------------------------");

{
    Console.WriteLine(new Fecha(2022, 1, 20));
    Console.WriteLine(new Fecha(2020, 10, 30));
    Console.WriteLine(new Fecha(2024, 2, 29));
}
catch (Exception Error)
{
    Console.WriteLine(Error.Message);
}
*/