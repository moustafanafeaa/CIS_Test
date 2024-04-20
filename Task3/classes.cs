using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Shape
    {
        public abstract double CalculatorArea();
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculatorArea()
        {
            return Length*Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double CalculatorArea()
        {
            return Radius*Radius*Math.PI;
        }
    }

}
