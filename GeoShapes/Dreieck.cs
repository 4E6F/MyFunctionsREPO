using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Dreieck
    {
        private Linie linieA;
        private Linie linieB;
        private Linie linieC;

        public Dreieck(Linie linieA, Linie linieB, Linie linieC)  
        {
            this.linieA = linieA;
            this.linieB = linieB;
            this.linieC = linieC;
            
            if (!erzeugenLinienRealesDreieck())
            {
                throw new ArgumentException("DreieckException: Bitte ändern sie nochmals die Parameter so das die Bedinung gilt " +
                    "keiner der Parameter soll gleich 0.5 * Umfang des Dreiecks sein");
            }

            
            
        }
        
        
        /// <summary>
        /// Berechnet den Umfang des Dreieckes indem es alle Linien Längen A, B, C addiert
        /// </summary>
        /// <returns>gibt den Umfang als double zurück</returns>
        public double BerechneUmfang() 
        {
            return linieA.Laenge + linieB.Laenge + linieC.Laenge;
        }

        /// <summary>
        /// Berechnet die Fläche des Dreiecks mit der Heron Formel sqrt(s* (s-a) * (s-b) * (s-c))
        /// und s = 0.5 * Umfang 
        /// </summary>
        /// <returns>gibt die Fläche als double zurück </returns>
        public double BerechneFlaeche() 
        {
            double a = linieA.Laenge;
            double b = linieB.Laenge;
            double c = linieC.Laenge;

            double s= 0.5 * BerechneUmfang(); // s:= halber Umfang 
            return Math.Sqrt(s*(s-a)* (s-b) * (s-c)); // Satz von Heron 
        }
        
        /// <summary>
        /// Mithilfe der Heron Formel kann man auch bestimmen, ob die Parametereingabe für das Dreieck
        /// wirklich ein Dreieck erzeugen
        /// </summary>
        /// <returns>gibt true zurück wenn Heron erfüllt wenn nicht dann false </returns>
        private bool erzeugenLinienRealesDreieck()
        {
            double s = 0.5* BerechneUmfang();
            
            if((s-linieA.Laenge) *(s - linieB.Laenge) * (s - linieC.Laenge) <= 0)
            {
                return false;
            }
            else { return true; }
        }
    }
}
