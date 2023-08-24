using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class Praesident
    {
        public string VereinName { get; set; }
        public string Name { get; set; }


        public Praesident(string name)
        {
            Name = name;

        }

        public void UnterzeichenFeldSpieler(FeldSpieler feldSpieler)
        {
            if (feldSpieler != null && feldSpieler.IstUnterzeichnet == false)
            {
                feldSpieler.IstUnterzeichnet = true;
            }
            
        }

        public void UnterzeichnenTorwart(Torwart torwart)
        {
            if (torwart != null && torwart.IstUnterzeichnet == false)
            {
                torwart.IstUnterzeichnet = true;
            }
        }

        public void ErhaeltVereinName(Verein verein)
        {
            VereinName = verein.VereinName;
        } 
    }
}
