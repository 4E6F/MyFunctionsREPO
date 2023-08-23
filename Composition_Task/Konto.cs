using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Task
{
    internal class Konto
    {
        public int KontoNumber { get; set; }


        public Konto(int kontoNumber)
        {
            KontoNumber = kontoNumber;
        }

        public Customer[] GetCustomers()
        {
            return new Customer[] { new Customer("Eve"), new Customer("Ueli"), new Customer("Gabi"), new Customer("Jürg"), new Customer("Peter") };
        }
    }
}
