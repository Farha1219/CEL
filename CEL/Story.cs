using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEL
{

    // OVERRIDING EXAMPLE GIVEN HERE
    class Story
    {
        public string name;
        public int pages;
        public string genre;


        public virtual void sound()
        {
            Console.WriteLine("Books are peaceful!!");
        }

    }

    class horror:Story  //horror class inherits from story
    {
        public override void sound()
        {
            Console.WriteLine("Books are scary!!");
        }
    }
    class funny : Story //funny class inherits from story
    {
    
        public override void sound() //overriding the method from parent class
        {
            Console.WriteLine("Books are funny!!");
        }
    }

}
