using System;
using Exercicio_MetodoAbstrato.Enums;

namespace Exercicio_MetodoAbstrato.Entites
{
    abstract class Shape
    {
        public Color Color { get; private set; }


        public Shape(Color color)
        {
            Color = color;
        }

        /*
         * Como a classe eh muito generica para a implementacao do metodo
         * entao ele vai ser abstrata
         */
        public abstract double Area();
        


    }
}
