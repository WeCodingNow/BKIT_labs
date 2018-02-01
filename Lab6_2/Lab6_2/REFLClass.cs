using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class REFLClass
    {
        [Attr("Property, type: double")]
        public double DoubleProperty1
        { get; set; }
        public int IntProperty1
        { get; set; }

        public REFLClass(double a, int b)
        {
            DoubleProperty1 = a;
            IntProperty1 = b;
        }

        public REFLClass(double a)
        {
            DoubleProperty1 = a;
            IntProperty1 = Convert.ToInt32(a);
        }

        public void PrintProperties()
        {
            System.Console.WriteLine("DoubleProperty1 = " + DoubleProperty1.ToString() + "\nIntProperty1 = " + IntProperty1.ToString());
        }

        public void PrintDoublePropertyMultiplied(double mul)
        {
            System.Console.WriteLine("DoubleProperty1 * " + mul.ToString() + " = " + (DoubleProperty1 * mul).ToString());
        }

    }
}
