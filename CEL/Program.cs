using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEL02;

namespace CEL
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Book book1 = new Book("Harry Potter", "J K Rowling", 350); // An object of Book Class
            Console.WriteLine("First Book is " + book1.title + ". Author name is " + book1.author); //Output from the object of Book class
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("Implementing string return method result: "+book1.AddString());
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("Implementing int type return method result: " + book1.DoublePages());
            Console.WriteLine("__________________________________________________________");

            Emp employee1 = new Emp(); // An object of Emp class
            employee1.Details();

            ChildEmp employee2 = new ChildEmp();
            employee2.ChildDetails(); //Age was comment out in the Emp.cs class due to private modifier

            NonChildEmp employee3 = new NonChildEmp();
            employee3.NonEmpDetails(); //Age,Salary, AccountNo was comment out in the Emp.cs class due to private modifier
            
            
            

            string sum = add("Fardin", "Kaho"); // Overloaded method
            int sum2 = add(2, 3, 4); // overloaded method
            Console.WriteLine("Method overloading example: "+sum);
            Console.WriteLine("Method overloading example: " + sum2);
            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("__________Overriding output____________");
            horror dark = new horror(); //Object of horror class that inherits story class
            dark.sound(); //return the value after overriding methods
            funny bean = new funny(); //object of funny class which is also inherited from story class
            bean.sound(); //return the value after overriding methods. 
            Console.WriteLine("__________________________________________________________");


            Console.WriteLine("______________Interface Output________________");
            //interface implementation
            Hero hero = new Hero(); // object of hero class that inherits Actors
            Heroine heroine = new Heroine(); //object of heroine class that inherits Actors
            Villain villain = new Villain(); //object of villain class that inherits Actors and CoActors

            hero.Activity();  //calling the overriden method 
            heroine.Activity();
            villain.Activity();
            villain.work();


            Console.ReadLine();
        }
        //Method Overloading methods
        // two method with same name but, different parameters. 
        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        static string add(string a, string b)
        {
            return a + b;
        }
    }
}
