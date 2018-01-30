using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SolveNPrint();

            System.Console.Read();
        }

        static int GetCoef()
        {
            int coef = 0;
            bool errFlag = false;

            do
            {
                if (errFlag == true) System.Console.WriteLine("Incorrect input. Try again.");
                string userInput = "";
                userInput = System.Console.ReadLine();

                errFlag = !(Int32.TryParse(userInput, out coef));

            } while (errFlag == true);

            return coef;
        }

        static void SolveNPrint()
        {
            int A = 0;
            while(A == 0)
            {
                System.Console.WriteLine("Input A: ");
                A = GetCoef();
                if (A == 0) System.Console.WriteLine("A should not equal 0.");
            }
            System.Console.WriteLine("Input B: ");
            int B = GetCoef();
            System.Console.WriteLine("Input C: ");
            int C = GetCoef();

            double D = B * B - 4 * A * C;

            if (D < 0)
            {
                System.Console.WriteLine("No real roots.");
            }
            else if (D == 0)
            {
                double x = -B / (2 * A);
                System.Console.WriteLine("x = " + x.ToString());
            }
            else
            {
                double x1 = (-1 * B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-1 * B - Math.Sqrt(D)) / (2 * A);
                System.Console.WriteLine("x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            }
        }
    }
}
