using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shakillar
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class Rhombus : Shape
    {
        private double diagonal1;
        private double diagonal2;

        public Rhombus(double diagonal1, double diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double GetArea()
        {
            return (diagonal1 * diagonal2) / 2;
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
