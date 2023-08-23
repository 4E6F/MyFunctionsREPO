using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Task
{
    internal class Book
    {

        public string Bookname { get; set; }

        public Book(string bookname)
        {
            Bookname = bookname;
        }
    }
}
