namespace ProgramacionPOO
{
    public class EmpleadoxComisionyBase : EmpleadoXComision
    {
        public decimal Base { get; set; }

        public override decimal ObtenerValorPagar()
        {
            return base.ObtenerValorPagar() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \n\t" +
                $"Total Base................: {$"{Base:C2}",18}";
        }
    }
}
