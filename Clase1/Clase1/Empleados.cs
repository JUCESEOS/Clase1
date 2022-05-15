namespace ProgramacionPOO
{
    public abstract class Empleados
    {
        public String Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Fecha FechaNacimiento { get; set; }
        public Fecha FechaIngreso { get; set; }
        public bool Activo { get; set; }
        public abstract decimal ObtenerValorPagar();
        public override string ToString()
        {
            return $"{Id}, {Nombres} {Apellidos} " +
                $"Nacimiento: {FechaNacimiento}, " +
                $"Ingreso: {FechaIngreso} " +
                $"Estado Activo {Activo}";
        }
    }
}
