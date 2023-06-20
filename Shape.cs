using System;

namespace shakillar
{
    public abstract class Shape<T>
    {
        public abstract double GetArea();
    }

    public class Square<T> : Shape<T>
    {
        private T side;

        public Square(T side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            double value = Convert.ToDouble(side);
            return value * value;
        }
    }

    public class Rectangle<T> : Shape<T>
    {
        private T width;
        private T height;

        public Rectangle(T width, T height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            double w = Convert.ToDouble(width);
            double h = Convert.ToDouble(height);
            return w * h;
        }
    }

    public class Rhombus<T> : Shape<T>
    {
        private T diagonal1;
        private T diagonal2;

        public Rhombus(T diagonal1, T diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double GetArea()
        {
            double d1 = Convert.ToDouble(diagonal1);
            double d2 = Convert.ToDouble(diagonal2);
            return (d1 * d2) / 2;
        }
    }

    public class Circle<T> : Shape<T>
    {
        private T radius;

        public Circle(T radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            double r = Convert.ToDouble(radius);
            return Math.PI * r * r;
        }
    }
}
