using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Lab6_2
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    class Attr : Attribute
    {
        public string description { get; set; }
        public Attr(string str_description)
        {
            description = str_description;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(REFLClass);
            Console.WriteLine("Конструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nАтрибуты свойств:");
            foreach (var x in t.GetProperties())
            {
                var isAttr = x.GetCustomAttributes(typeof(Attr), false);
                if (isAttr.Length > 0)
                {
                    Console.WriteLine(isAttr[0]);
                }
            }
            Console.WriteLine();

            REFLClass class1 = new REFLClass(13, 2);
            object[] param = new object[] { 4 };
            t.InvokeMember("PrintDoublePropertyMultiplied", System.Reflection.BindingFlags.InvokeMethod, null, class1, param);



            System.Console.ReadLine();
        }
    }
}
