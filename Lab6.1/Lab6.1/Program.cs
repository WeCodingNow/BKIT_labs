using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        delegate int MathOperation(int x, string y);

        static int Power(int x, string y)
        {
            int tempInt = 1;
            for (int i = 0; i < Convert.ToInt32(y); i++)
            {
                tempInt *= x;
            }
            return tempInt;
        }

        static void TakeDelegateDoMathPrint(string mathOperation, int x, string y, MathOperation MO)
        {
            System.Console.WriteLine("Выполняется операция: \"" + mathOperation + "\" с аргументами (" + x.ToString() + "," + y + ")");
            System.Console.WriteLine("Результат: " + MO(x, y));
        }

        static void TakeGenericDelegateDoMathPrint(string mathOperation, int x, string y, Func<int, string, int> MO)
        {
            System.Console.WriteLine("Выполняется операция: \"" + mathOperation + "\" с аргументами (" + x.ToString() + "," + y + ")");
            System.Console.WriteLine("Результат: " + MO(x, y));
        }


        static void Main(string[] args)
        {
            TakeDelegateDoMathPrint("Возведение в степень", 10, "2", Power);
            System.Console.WriteLine();
            TakeDelegateDoMathPrint("Умножение(лямбда-функция)", 20, "15", (x, y) => (x * Convert.ToInt32(y)));
            System.Console.WriteLine();
            TakeGenericDelegateDoMathPrint("Сложение(обобщённый делегат)", 33, "16", (x, y) => (x + Convert.ToInt32(y)));
            System.Console.ReadLine();
        }
    }
}
