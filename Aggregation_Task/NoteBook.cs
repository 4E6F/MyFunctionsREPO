using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation_Task
{
    internal class NoteBook
    {

        public string Model { get; set; }

        public string Brand { get; set; }

        //Aggregation

        private HardDisk[] hardDisks = new HardDisk[3];

        public NoteBook(HardDisk hardDisks)
        {
            this.hardDisks[0] = hardDisks;
        }
        
        //....
        
    }
}
