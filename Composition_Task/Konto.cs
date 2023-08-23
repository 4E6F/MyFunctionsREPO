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

        public Customer KontoOwner { get; set; }

        public Customer GetCustomer() { return new Customer(); }
        
    }
}
