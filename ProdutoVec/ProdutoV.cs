using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoVec
{
    class ProdutoV
    {
        public string Nome { get; set; }
        private double _preco;

        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
    }
}
