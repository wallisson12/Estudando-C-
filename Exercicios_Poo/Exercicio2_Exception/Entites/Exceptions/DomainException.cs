using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Exception.Entites.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string mensage) : base(mensage)
        {
            
        } 
    }
}
