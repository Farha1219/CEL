using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEL02
{    // It's a reference project added to the library. Here, I will show the use of access modifier.
     // Such as public, private, internal, protected etc.
    public class Emp
    {
        public string name = "Fardin";
        private int age = 24;
        protected int salary = 35000;
        internal string address = "Rampura";
        protected internal string spouse = "FJZ";
        private protected int AccountNo = 121;

        public void Details()
        {
            Console.WriteLine("Access Modifier check in same class");
            Console.WriteLine(name);
            Console.WriteLine(age); 
            Console.WriteLine(salary); 
            Console.WriteLine(address);
            Console.WriteLine(spouse);
            Console.WriteLine(AccountNo);
            Console.WriteLine("__________________________________________________________");
        }

    }
    public class ChildEmp : Emp
    {
        public void ChildDetails()
        {
            Console.WriteLine("Access Modifier check in CHILD class");
            Console.WriteLine(name);
            // Console.WriteLine(age); Inaccessible due to PRIVATE access modifier
            Console.WriteLine(salary);
            Console.WriteLine(address);
            Console.WriteLine(spouse);
            Console.WriteLine(AccountNo);
            Console.WriteLine("__________________________________________________________");
        }
    }

    public class NonChildEmp
    {
        public void NonEmpDetails()
        {
            Console.WriteLine("Access Modifier check in object of the class");
            Emp kaho = new Emp();
            Console.WriteLine(kaho.name);
            // Console.WriteLine(kaho.age); Not accessible due to PRIVATE access modifier.
            // Console.WriteLine(kaho.salary); Not accessible due PROTECTED access modifier.
            Console.WriteLine(kaho.address);
            Console.WriteLine(kaho.spouse);
            // Console.WriteLine(kaho.AccountNo); Not accessible due to PRIVATE PROTECTED access modifier.

            Console.WriteLine("__________________________________________________________");
        }
    }


    
}
