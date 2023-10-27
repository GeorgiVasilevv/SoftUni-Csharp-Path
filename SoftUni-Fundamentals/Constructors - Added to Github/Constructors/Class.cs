using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            title = Console.ReadLine();
            author = Console.ReadLine();
            pages = int.Parse(Console.ReadLine());

        }

    }
}
