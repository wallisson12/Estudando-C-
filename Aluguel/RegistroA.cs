using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel
{
    class RegistroA
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int Room { get; set; }


        public override string ToString()
        {
            return Room + ": " + Nome + ", " + Email; 
        }
    }
}
