using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEL
{   //A class in the CEL namespace named book. Object of this class is created in program.cs
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //building a constructor of this class        
        public Book(string aTitle, string aAuthor, int aPages)
            {
                title = aTitle;
                author = aAuthor;
                pages = aPages;
            }
        public string AddString()
        {
            return title + author;
        }
        public int DoublePages()
        {
            return pages * 2;
        }
    }
    abstract class Movies
    {
        // An abstract class that helps to create it's instance and there will be no object of this class.
        public abstract void Fight();
        
    }
    class Drama : Movies
    {
        public override void Fight()
        {
            //Overriding the method of abstract class
            Console.WriteLine("No fight in dramas!");
        }
    }
}
