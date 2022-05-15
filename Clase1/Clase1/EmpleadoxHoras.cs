namespace ProgramacionPOO
{
    public class EmpleadoxHoras : Empleados
    {
        public float Horas { get; set; }
        public decimal Valor_Hora { get; set; }

        public override decimal ObtenerValorPagar()
        {
            return ((decimal)Horas * Valor_Hora);
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t" +
                $"Numero de Horas...........: {$"{Horas:N2}",18}\n\t" +
                $"Valor x Hora..............: {$"{Valor_Hora:C2}",18} \n\t" +
                $"===> Valor a pagar .......: {$"{ObtenerValorPagar():C2}",18}";
        }
    }
}
