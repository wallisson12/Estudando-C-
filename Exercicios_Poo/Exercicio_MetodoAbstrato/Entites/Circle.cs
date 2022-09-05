using System;
using Exercicio_MetodoAbstrato.Enums;

namespace Exercicio_MetodoAbstrato.Entites
{
    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(Color color,double radius) : base(color)
        {
            Radius = radius;
        }

        //Implemetacao do metodo abstrato da superClasse
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
