namespace ProgramacionPOO
{
    public class EmpleadoAsalariado : Empleados

    {
        public decimal Salario { get; set; }
        public override decimal ObtenerValorPagar()
        {
            return Salario;
        }
        public override string ToString()
        {
            return $"{ base.ToString()} \n\t===> Valor a pagar .......: {$"{ObtenerValorPagar():C2}",18} \n ";
        }
    }
}
