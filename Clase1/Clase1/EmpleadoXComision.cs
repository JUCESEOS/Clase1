using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionPOO
{
    public class EmpleadoXComision : Empleados
    {
        public float Comision { get; set; }
        public decimal Ventas { get; set; }

        public override decimal ObtenerValorPagar()
        {
            return (Ventas * (decimal)Comision);
        }
        public override string ToString()
        {
            return $"{ base.ToString()} \n\t" +
                $"% De Comisión....: {Comision:P2}\n\t" +
                $"Total de Ventas...........: {$"{Ventas:C2}",18} \n\t" +
                $"===> Valor a pagar .......: {$"{ObtenerValorPagar():C2}",18}";
        }
    }
}
