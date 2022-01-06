using System;
using System.Collections.Generic;
using System.Text;

namespace Ref
{
    class Calculadora
    {
        public static void Triple( ref int x)
        {
            x = x * 3;
        }

        public static void Triplee(int x,out int referencia)
        {
            referencia = x * 3;
        }
    }
}
