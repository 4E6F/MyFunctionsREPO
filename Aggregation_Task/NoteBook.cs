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

        public List<HardDisk> HardDiskNames { get; set; }
        

        public void work() { }
    }
}
