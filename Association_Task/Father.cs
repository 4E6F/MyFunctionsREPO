using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Task
{

    internal class Father
    {

        private string FatherName { get; set; }
        
        public List<Child> Children { get; set; }
    }
}
