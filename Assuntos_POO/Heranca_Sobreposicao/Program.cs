using System;
using Heranca_Sobreposicao.Entites;

namespace Heranca_Sobreposicao
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o Upcasting para que futuramente possa fazer um dowcasting para outro tipo de account
            //Upcasting e DownCasting sao formas de polimorfismo
            Account_2 acc1 = new Account_2(1001,"Wallisson",500.0);
            Account_2 acc2 = new SavingsAccount_2(1002,"Anna",500.0,0.01);

            //Polimorfismo,sao variaves do mesmo tipo, mais apontadas para objetos diferentes que agem de maneira diferente
            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            


        }
    }
}
