using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Task
{
    internal class Child
    {
        private string ChildName { get; set; }

        public Father GetFather { get; set; }
    }
}
