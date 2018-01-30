using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Geometric_figure
    {
        public abstract double FindSurface();
    }

    class Rectangle : Geometric_figure, IPrint
    {
        public double height, width;

        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }

        public override double FindSurface()
        {
            return height * width;
        }

        public override string ToString()
        {
            return ("Rectangle : height(" + height.ToString() + "), width(" + width.ToString() + "), surface(" + FindSurface() + ")");
        }

        public void Print()
        {
            System.Console.WriteLine(this.ToString());
        }

    }

    class Square : Rectangle
    {
        public Square(double s) : base(s, s) { }

        public override string ToString()
        {
            return ("Square : side(" + height.ToString() + "), surface(" + FindSurface() + ")");
        }

    }

    class Circle : Geometric_figure, IPrint
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double FindSurface()
        {
            return (Math.PI * radius * radius);
        }

        public override string ToString()
        {
            return ("Circle : radius(" + radius.ToString() + "), surface(" + FindSurface() + ")");
        }

        public void Print()
        {
            System.Console.WriteLine(this.ToString());
        }
    }

}
