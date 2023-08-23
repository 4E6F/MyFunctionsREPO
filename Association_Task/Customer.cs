using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Task
{
    internal class Customer
    {
        public string Name { get; set; }

        public List<Book> GetBooks() {
            return new List<Book> { new Book("Hans Im Wald"), new Book("Eragon") };
        }
    }
}
