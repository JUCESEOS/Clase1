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
Empleados Empleado3 = new EmpleadoxHoras()
{
    Id = "28130970",
    Nombres = "Lucia Osma",
    Apellidos = "de Serrano",
    FechaNacimiento = new Fecha(1958, 4, 1),
    FechaIngreso = new Fecha(2021, 4, 1),
    Activo = true,
    Valor_Hora = 12356.65M,
    Horas = 140.3F
};
Empleados Empleado4 = new EmpleadoxComisionyBase()
{
    Id = "37722117",
    Nombres = "Monica Lizette",
    Apellidos = "Villamizar Vega",
    FechaNacimiento = new Fecha(1978, 11, 11),
    FechaIngreso = new Fecha(2021, 4, 1),
    Activo = true,
    Comision = 0.01F,
    Ventas = 50000000M,
    Base = 160000M
};
/*Console.WriteLine(Empleado1.ToString());
Console.WriteLine(Empleado2.ToString());
Console.WriteLine(Empleado3.ToString());
Console.WriteLine(Empleado4.ToString());*/
ICollection<Empleados> EMPELADOS = new List<Empleados>()
{     Empleado1, Empleado2, Empleado3, Empleado4 };

decimal TotalNomina = 0;
foreach (Empleados Empleado in EMPELADOS)
{
    Console.WriteLine(Empleado);
    TotalNomina += Empleado.ObtenerValorPagar();

}

Console.WriteLine($"\n\t                           ============================");
Console.WriteLine($"\n\t  TOTAL A PAGAR.............:{$"{TotalNomina:C2}",18} ");

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