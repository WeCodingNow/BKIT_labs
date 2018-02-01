using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Worker
    {
        public int id;
        public string last_name;
        public int id_department;
        public Worker(int i, string l, int d)
        {
            id = i;
            last_name = l;
            id_department = d;
        }
        public override string ToString()
        {
            return id + " Фамилия: " + last_name + "\n    ID отдела: " + id_department;
        }
    }

    class Department
    {
        public int id;
        public string name;
        public Department(int i, string n)
        {
            id = i;
            name = n;
        }
        public override string ToString()
        {
            return id + " " + name;
        }
    }

    class Department_workers
    {
        public int worker_id;
        public int dep_id;
        public Department_workers(int a, int b)
        {
            worker_id = a;
            dep_id = b;
        }
    }
}
