using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class Torwart
    {
        public string Name { get; set; }

        public bool IstUnterzeichnet { get; set; } = false;
        public Torwart(string name)
        {
            Name = name;
        }

        public void BaelleHalten() {
            Console.WriteLine("BALL GEHALTEN");
        }
    }
}
