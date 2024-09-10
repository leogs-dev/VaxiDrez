namespace LibreriaVaxi
{
    public class Operacion
    {
        public int SumarNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool IsValorPar(int num) 
        { 
            return num % 2 == 0;
        }

        public double SumarDecimal(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }
    }
}
