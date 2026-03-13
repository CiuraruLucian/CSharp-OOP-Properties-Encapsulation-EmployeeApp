using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.NetProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Lucian",100, 42000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // On Joe's birthday, you want to increment the age by one.
            Employee joe = new Employee();
            joe.Age++;

            // On Joe's birthday, you want to increment the age by one. Using the traditional accessor and mutator methods.
            /*
             Employee joe = newEmployee();
             joe.SetAge(joe.GetAge() + 1);
            */


            Console.ReadLine();
        }
    }
}
