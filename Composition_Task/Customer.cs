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


        public Customer(string customerName)
        {
            CustomerName = customerName;
        }

        public Konto GetKonto(int kontoNumber)
        {
            return new Konto(1);
        }
    }
}
