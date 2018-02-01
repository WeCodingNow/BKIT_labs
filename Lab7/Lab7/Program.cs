using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker(1, "Аксёнов", 1),
                new Worker(2, "Курочкин", 1),
                new Worker(3, "Шатунов", 1),
                new Worker(4, "Бутусов", 2),
                new Worker(5, "Андреев", 3),
                new Worker(6, "Гробовой", 2),
                new Worker(7, "Летов", 3)
            };

            List<Department> departments = new List<Department>()
            {
                new Department(1, "Отдел найма"),
                new Department(2, "Отдел обслуживания"),
                new Department(3, "Отдел снабжения")
            };

            List<Department_workers> department_workers = new List<Department_workers>()
            {
                new Department_workers(1, 1),
                new Department_workers(1, 2),
                new Department_workers(2, 1),
                new Department_workers(3, 1),
                new Department_workers(4, 2),
                new Department_workers(4, 3),
                new Department_workers(5, 3),
                new Department_workers(6, 2),
                new Department_workers(7, 3)
            };

            Console.WriteLine("Список всех сотрудников: ");
            var q1 = from x in departments
                     join y in workers on x.id equals y.id_department into t
                     select new { dep = x, dep_workers = t };
            foreach (var x in q1)
            {
                Console.WriteLine(x.dep);
                foreach (var y in x.dep_workers)
                {
                    Console.WriteLine("  " + y);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сотрудники с фамилией, начинающейся на А");
            var q2 = from x in workers
                     where x.last_name[0] == 'А'
                     select x;
            foreach (var x in q2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n" + "Отделы и количество сотрудников");
            var q3 = from x in departments select x;
            foreach (var x in q3)
            {
                Console.WriteLine(x);
                var q4 = from y in workers
                         where y.id_department == x.id
                         select y;
                Console.WriteLine("Количество сотрудников: " + q4.Count());
            }

            Console.WriteLine("\nОтделы, в которых у всех сотрудников фамилия начинается с буквы А");
            var q5 = from x in workers
                     group x by x.id_department into g
                     where g.All(x => x.last_name[0] == 'А')
                     select g.Key;

            foreach (var x in q5)
            {
                var q6 = from y in departments
                         where y.id == x
                         select y;
                Console.WriteLine(q6.ElementAt(0));
            }

            Console.WriteLine("\nОтделы, в которых хотя бы у одного сотрудника фамилия на А");
            var q7 = from x in workers
                     group x by x.id_department into g
                     where g.Any(x => x.last_name[0] == 'А')
                     select g.Key;

            foreach (var x in q7)
            {
                var q8 = from y in departments
                         where y.id == x
                         select y;
                Console.WriteLine(q8.ElementAt(0));
            }

            Console.WriteLine("\nМногие-ко-многим");

            var q9 = from x in departments
                     join l in department_workers on x.id equals l.dep_id into temp
                     from t in temp
                     group t by t.dep_id into g
                     select new { dep = g.Key, work = g };


            foreach (var x in q9)
            {
                Console.WriteLine(x.dep + " отдел");
                foreach (var y in x.work)
                {
                    Console.WriteLine("    " + y.worker_id + " сотрудник");
                }
            }

            Console.WriteLine("\nКоличество сотрудников");
            foreach (var x in q9)
            {
                Console.WriteLine(x.dep + " отдел, количество сотрудников - " + x.work.Count());
            }

            Console.ReadKey();
        }
    }
}
