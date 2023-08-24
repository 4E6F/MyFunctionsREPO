using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class Verein
    {
        public List<Mannschaft> Mannschaften { get; set; } = new List<Mannschaft>();

        public PhysioTherapeutin PhysioTherapeutin { get; set; }
        public string PraesidentNamen { get; set; }

        public string TherapeutinName { get; set; }
        public string VereinName { get; set; }

         
        public Verein(string vereinName,Praesident name)
        {
            PraesidentNamen = name.Name;
            VereinName = vereinName;
        }

        public Verein(string vereinName, Praesident praesidentname, PhysioTherapeutin therapeutinname)
        {
            PhysioTherapeutin = therapeutinname;
            PraesidentNamen = praesidentname.Name;
            TherapeutinName = therapeutinname.Name;
            VereinName = vereinName;
        }


        public void AddMannschaft(Mannschaft mannschaft)
        {
            Mannschaften.Add(mannschaft);
        }

        public void RemoveMannschaft(Mannschaft mannschaft)
        {
            Mannschaften.Remove(mannschaft);
        }
    }
}
