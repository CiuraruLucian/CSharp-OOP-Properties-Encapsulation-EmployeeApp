using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.NetProperties
{
    class Employee
    {
        //Field Data or the state of the class
        private string empName;
        private int empId;
        private float currPay;
        private string empSSN;
        // New field and property : Properties (as opposed to accessor and mutator methods) also make your types easier to
        // manipulate, in that properties are able to respond to the intrinsic operators of C#.
        private int empAge;
   
        //Properties

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }

        // The ’int’ represents the type of data this property
        // encapsulates.

        public int ID // Note lack of parentheses.

        {
            get { return empId; }
            set { empId = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }


        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        // Updated constructors

        public Employee(){}

        public Employee( string name, int id, float pay)
        :this (name, id, pay, 0, "") { } // Constructor chaining removes this duplication. Provides Default Values. The constructor that doesn't receive age automatically sets age to 0.

        public Employee(string name, int id, float pay, int age, string ssn)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            empSSN = ssn;
        }


        // Methods

        public void GiveBonus (float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empId);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Age: {0}", empAge);
        }
        
    }
}
