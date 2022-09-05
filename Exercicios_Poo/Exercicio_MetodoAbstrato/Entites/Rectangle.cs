using System;
using Exercicio_MetodoAbstrato.Enums;


namespace Exercicio_MetodoAbstrato.Entites
{
    class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(Color color,double width,double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        //Implementacao do metodo abstrato da superClasse
        public override double Area()
        {
            return Width * Height;
        }
    }
}
