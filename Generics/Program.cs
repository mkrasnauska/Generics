using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        public class Employee<T>
        {

            public List<T> Things { get; set; }



        }
        public static void Main(string[] args)
        {

            Employee<string> emp1 = new Employee<string>();
            Employee<int> emp2 = new Employee<int>();
            emp1.Things = new List<string>();
            emp1.Things.Add("Rita");
            emp1.Things.Add("Olivia");
            emp1.Things.Add("George");
            emp1.Things.Add("Sarah");
            emp1.Things.Add("Nina");

            emp2.Things = new List<int>();
            emp2.Things.Add(5);
            emp2.Things.Add(45234);
            emp2.Things.Add(213);
            emp2.Things.Add(42124);
            emp2.Things.Add(1332);

            for (int i = 0; i < emp1.Things.Count; i++)
            {
                Console.WriteLine("Employee Name :{0} ", emp1.Things[i]);

            }
            for (int i = 0; i < emp2.Things.Count; i++)
            {
                Console.WriteLine(" Employee ID :{0} ", emp2.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
