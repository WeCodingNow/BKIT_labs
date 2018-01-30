using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(10);
            Rectangle b = new Rectangle(2, 5);
            Square c = new Square(7);

            ArrayList list1 = new ArrayList();
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);

            list1.Sort();

            foreach (Geometric_figures i in list1)
            {
                System.Console.WriteLine(i.ToString());
            }

            List<Geometric_figures> list2 = new List<Geometric_figures>();
            list2.Add(a);
            list2.Add(b);
            list2.Add(c);

            list2.Sort();

            System.Console.WriteLine();

            foreach (Geometric_figures i in list2)
            {
                System.Console.WriteLine(i.ToString());
            }

            System.Console.WriteLine();

            SparseMatrix.Matrix<Geometric_figures> matrix1 = new SparseMatrix.Matrix<Geometric_figures>(2, 2, 1, new Circle(0));
            matrix1[0, 0, 0] = new Circle(1);
            matrix1[1, 0, 0] = new Square(2);
            matrix1[1, 1, 0] = new Rectangle(1, 2);
            System.Console.WriteLine(matrix1.ToString());

            SimpleStack<Geometric_figures> SStack = new SimpleStack<Geometric_figures>();
            SStack.Add(a); SStack.Add(b); SStack.Add(c);
            SStack.Sort();

            for (int i = SStack.Count; i > 0; i--)
            {
                System.Console.WriteLine(SStack.Pop());
            }

            System.Console.ReadLine();
        }
    }
}
