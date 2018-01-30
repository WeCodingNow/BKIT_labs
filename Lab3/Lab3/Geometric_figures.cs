using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Geometric_figures : IComparable
    {
        public abstract double FindSurface();

        public int CompareTo(Object rhs)
        {
            Geometric_figures objR = rhs as Geometric_figures;

            if (FindSurface() - objR.FindSurface() > 0.0001)
            {
                if (FindSurface() < objR.FindSurface())
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }

        }
    }

    class Rectangle : Geometric_figures, IPrint
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

    class Circle : Geometric_figures, IPrint
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
