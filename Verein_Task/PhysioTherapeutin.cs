using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class PhysioTherapeutin
    {
        public string Name { get; set; }

        public PhysioTherapeutin(string name)
        {
            Name = name;
        }

        public void Massieren(string name) {
        
            Console.WriteLine($"Therapeutin massiert {name}");
        }
    }
}
