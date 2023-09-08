using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Kreis
    {
        private Linie kreislinie;
        private double radius;
        private const double PI = Math.PI;
        public Kreis(Linie kreislinie) 
        {
            this.kreislinie = kreislinie;
            radius = kreislinie.Laenge / (2 * PI);
        }
        /// <summary>
        /// Berechnet den Umfang des Kreises was logischerweise einfach die kreislinien Länge ist
        /// </summary>
        /// <returns>gibt den Umfang als double zurück</returns>
        public double BerechneUmfang() { return kreislinie.Laenge; } // die Länge der Linie für den Kreis ist ja schon der Umfang

        /// <summary>
        /// Berechnet die Fläche des Kreises mit der Formel r^2 * PI
        /// </summary>
        /// <returns>gibt die Fläche als double zurück</returns>
        public double BerechneFlaeche() { return Math.Pow(radius, 2) * PI; }
    }
}
