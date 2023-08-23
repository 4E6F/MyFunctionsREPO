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

        public List<Konto> kontos { get; set; }
    }
}
