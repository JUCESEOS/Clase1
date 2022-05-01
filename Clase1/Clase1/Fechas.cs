using ProgramacionPOO;

namespace ProgramacionPOO
{
    public class Fecha
    {
        private int _year;
        private int _month;
        private int _day;

        public Fecha(int year, int mes, int dia)
        {
            _year = year;
            _month = ValidarMes(mes);
            _day = Validardia(year, mes, dia);
        }

        private int Validardia(int year, int mes, int dia)
        {
            int[] diasmes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (dia == 29 && mes == 2 && Isbiciestos(year)) { return dia; }
            if (dia >= 1 && dia <= diasmes[mes]) { return dia; }
            throw new DiaError("Dia NO válido para el mes");
        }


        private bool Isbiciestos(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int ValidarMes(int mes)
        {
            if (mes >= 1 && mes <= 12)
                return mes;
            throw new MesError($"Mes: {mes}, Invalido");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
