using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(10);
            Square b = new Square(30);
            Rectangle c = new Rectangle(15, 25);

            a.Print();
            b.Print();
            c.Print();

            while (true) ;
        }
    }
}
