using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instanzvariablen
{
    internal class Rectangle
    {
        public double width;
        public PointD topLeftPoint;

        private PointD position; //1. Aufgabe

        private readonly double angle = 90; // 2.Aufgabe

        public string name = "Hans"; // 3. Aufgabe


        public string ReadName { get // 4.Aufgabe
            {
                return name;
            }
        }

        public string ReadSetName // 5.Aufgabe
        { 
            set
            {
                name = "bla2";
            }
            get
            {
                return name;
            }
        }
        public string SetName { set { name = "bla"; } } // 6. Aufgabe

        public string autoName { get; } // 8.Aufgabe
        public string autoNameGetSet { get; set; } // 9.Aufgabe

        //public string autoNameSet { set } // impossible because need get 

        public string rand { get => this.name;
            set { this.name = "bla3"; }
        }  

        public double Height { get; set; }


        public double Area
        {
            get
            {
                return width * Height;
            }
        }

        public double Area2 => width * Height;

        public PointD TopRightPoint
        {
            set => width = Math.Sqrt(Math.Pow(value.X - topLeftPoint.X, 2) + Math.Pow(value.Y - topLeftPoint.Y, 2));
        }

    }

}
}
