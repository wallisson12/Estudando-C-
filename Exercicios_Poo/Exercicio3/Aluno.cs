using System;
using System.Globalization;

namespace Exercicio3
{
    public class Aluno
    {
        public string Name;
        public double N1,N2,N3;

        public double NotaFinal()
        {
            return (N1+N2+N3);
        }

        public string Verifica()
        {
            if(NotaFinal() >= 60.00)
            {
                return "Aprovado";
            }
            else 
            { 
                return "Reprovado";
            }
        }

        public double PontosFalta()
        {
            if(Verifica() == "Reprovado")
            {
                return  Math.Abs(NotaFinal() - 60.00);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Nota final = "
            + NotaFinal().ToString("F2",CultureInfo.InvariantCulture)
            + "   " + Verifica()
            + " Faltaram =  "
            + PontosFalta().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}