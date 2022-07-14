using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfLearn
{
    class Student:Person
    {
        public int studentID;
        public string uniName;

        //constructor 
        public Student()
        {

        }
        public void Study()
        {
            Console.WriteLine("My Name is(From Parent):"+name);
            Console.WriteLine("My Age is(From Parent):" + age);
            Console.WriteLine("My Weight is(From Parent):" + Weight);
            Console.WriteLine("My Height is(From Parent):" + Height);
            Console.WriteLine("My Salary is(From Parent):" + Salary);
            Console.WriteLine("My University ID is:"+studentID);
            Console.WriteLine("My University Name is:" + uniName);
        }
    }
}
