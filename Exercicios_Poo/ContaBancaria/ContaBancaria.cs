using System;
using System.Globalization;

namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int Conta { get; private set;}
        private string _nome;
        public double _deposito { get; private set;}

        //Construtor
        public ContaBancaria(int conta,string nome)
        {
            Conta = conta;
            _nome = nome;
        }

        //Contrutor
        public ContaBancaria(int conta,string nome,double saldo) : this(conta,nome)
        {
           Deposito(saldo);
        }

        //Popriedades

        public string Nome
        {
            get{ return _nome; }
            set{ _nome = value; }
        }


        public void Deposito(double de)
        {
            _deposito += de;
        }

        public void Saque(double saque)
        {
            _deposito -= saque + 5.00; 
        }


        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + _nome + ", Saldo: $ " + _deposito.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}