namespace ProgramacionPOO
{
    public class Invoice : Ipay
    {

        public int Id { get; set; }
        public string Desripsion { get; set; }

        public float Cantidad { get; set; }
        public decimal Precio { get; set; }

        public decimal ObtenerValorPagar()
        {
            return (decimal)Cantidad * Precio;
        }
        public override string ToString()
        {
            return $"{Id} - {Desripsion} " +
                $"\n\t  Cantidad...........: {$"{Cantidad:N2}",20}" +
                $"\n\t  Valor..............: {$"{Precio:C2}",20}" +
                $"\n\t  Valor Total pagado : {$"{ObtenerValorPagar():C2}",20}";
        }
    }
}
