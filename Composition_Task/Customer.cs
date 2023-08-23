using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Task
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public Konto CustomerKonto { get; set; }
        public Customer() { }

        public Customer(string customerName)
        {
            Customer customer = new Customer();
            CustomerName = customerName;
            CustomerKonto = customer.GetKonto();

        }

        public Konto GetKonto()
        {
            return new Konto(0);
        }
    }
}
