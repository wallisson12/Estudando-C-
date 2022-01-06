using System.Globalization;
using System;

namespace Exercicio14
{
    public class Produto
    {
        private string _nome;
        public  double Preco { get; private set; }
        public  int Quantidade { get; private set; }

        //Iniciando o construtor

        //Padrao
        public Produto(){

        }

        //Customizado
        public Produto (string nome,double preco,int quantidade){

            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedade
        public string Nome{

            get{ return _nome; }

            set{

                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }          
        }

        //Retorna o valor no estoque do produto
        public double ValorTotalEstoque(){

            return Preco * Quantidade;

        }

        public void QuantidadeAdd(int qte){

            Quantidade += qte;
        }

        public void RemoverProdutos(int qte){
            
            Quantidade -= qte;
        }

        //Ele vai ser chamado intrinsecamente na hora que voce chama o obj
        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEstoque().ToString("F2",CultureInfo.InstalledUICulture); 
        }

    }
}