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

        public List<HardDisk> GetHardDisks() {
            return new List<HardDisk> { new HardDisk("HD1")};
        }
    }
}
