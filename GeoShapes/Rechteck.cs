using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public  class Rechteck
    {
        private Linie linieA;
        private Linie linieB;
        private Linie linieC;
        private Linie linieD;


        public Rechteck(Linie linieA, Linie linieB, Linie linieC, Linie linieD)
        {
            this.linieA = linieA;
            this.linieB = linieB;
            this.linieC = linieC;
            this.linieD = linieD;

            if (!SindLinienGroesserNull() || !SindLinienPaarweiseGleich())
            {
                throw new ArgumentException(" RechteckException: Entweder ist einer der  Parameter 0 oder A (parameter1) != D (param1) oder B (param2) != C (param3) was nicht gelten darf");
                    
            }

        }


        
        public double BerechneUmfang() { return linieA.Laenge + linieB.Laenge + linieC.Laenge + linieD.Laenge; }

        
        public double BerechneFlaeche() { return linieA.Laenge * linieB.Laenge; }

        private bool SindLinienPaarweiseGleich()
        {

            return linieA.Laenge.CompareTo(linieD.Laenge) == 0 && linieB.Laenge.CompareTo(linieC.Laenge) == 0;
        }

        private bool SindLinienGroesserNull()
        {
            return linieA.Laenge > 0 && linieB.Laenge > 0 && linieC.Laenge > 0;
        }
    }
}
