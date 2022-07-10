using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfLearn
{
   class Person
    {
        public string name;
        public int age;
        private int height;
        private int weight;
        private double salary;

        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public double Salary { get => salary; set => salary = value; }

        public void PrintPersonInfor()
        {
            Console.WriteLine("Person Name " + name);
            Console.WriteLine("Person Age " + age);
            Console.WriteLine("Person Height " + height);
            Console.WriteLine("Person Weight " + weight);
        }

        public void Eating()
        {

        }
        public void Sleeping()
        {

        }
    }
}
