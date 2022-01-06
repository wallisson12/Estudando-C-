namespace Exercicio_Static
{
    public class ConversorDolarReal
    {
        public static double IOF = 0.06f;

        public static double Conversor(double Cotacao,double valor){

            double valorReais = Cotacao * valor;

            return valorReais + (valorReais * IOF);

        }
        
    }
}