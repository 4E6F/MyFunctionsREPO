using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class FeldSpieler
    {
        public bool IstUnterzeichnet { get; set; } = false;
        public string Name { get; set; }

        public FeldSpieler(string name)
        {
            Name = name;
        }

        public void schiesseTor() {
            Console.WriteLine($"{Name} SCHIESST TOR!!!");
        }
        public void graetschen(FeldSpieler feldSpieler) {
            Console.WriteLine($"{Name} grätscht {feldSpieler.Name}");
        }
    }
}
