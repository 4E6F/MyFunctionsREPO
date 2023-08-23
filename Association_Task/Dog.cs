using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_Task
{
    internal class Dog
    {
        public static string Name { get; set; }

        public List<Louse> getLouses { get => new List<Louse>();}

    }
}
