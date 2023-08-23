using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapusaltion_Project
{
    internal class Person
    {
        private int wutLevel;
        private int appetitLevel;



        public Person() {
            this.wutLevel = 0;
            this.appetitLevel = 0;
        }

        public Person(int wutLevel, int appetitLevel) {
            this.wutLevel = wutLevel;
            this.appetitLevel = appetitLevel;
        }

        public void Provozieren(int level) { }
        
        private void Ausrasten() { }

        public void EssenGeben() { }
        public void EssenVerweigern() { }
        public void ArbeitsauftragGeben(int level) { }
    }
}
