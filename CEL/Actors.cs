using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEL
{   //implementing interface. 
    interface Actors
    {
        void Activity();
    }

    interface CoActors
    {
        void work();
    }
    class Hero : Actors //Hero class inherits from interface Actors
    {
        public void Activity()
        {
            Console.WriteLine("Fights with the villain!!");
        }
    }
    class Heroine : Actors  // Heroine class inherits from interface Actors
    {
        public void Activity()
        {
            Console.WriteLine("Runs from the villain!! ");
        }
    }
    class Villain : Actors, CoActors  //Villain class inherits from two interfaces, Actors and CoActors
    {   //Implementation of interface. A child class can inherit from multiple parent class, which is the most important 
        //feature of interface.
        public void Activity()
        {
            Console.WriteLine("Fights with Hero");
        }

        public void work()
        {
            Console.WriteLine("Too much work for co workers");
        }
    }
}
