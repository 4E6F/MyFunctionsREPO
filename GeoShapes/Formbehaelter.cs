using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Formbehaelter
    {
        public List<Dreieck> Dreiecke { get;} = new List<Dreieck>();
        public List<Rechteck> Rechtecke { get;} = new List<Rechteck>();
        public List<Kreis> Kreise { get;} = new List<Kreis>();

        public Formbehaelter(Rechteck rechteck1, Rechteck rechteck2, Kreis kreis1)
        {

            Rechtecke.Add(rechteck1);
            Rechtecke.Add(rechteck2);
            Kreise.Add(kreis1);
        }

        public void HinzufuegeDreieck(Dreieck dreieck)
        {
            if (Dreiecke.Count < 4)
            {
                Dreiecke.Add(dreieck);
            }
            else { throw new IndexOutOfRangeException("DreieckException: Zu viele Dreiecke es dürfen nur 4 sein"); }
            
        }

        // hier braucht es kein HinzufuegeRechteck Methode da eh nur 2 Rechtecke initialisiert werden dürfen
        //die ersetze-Methode des Rechteckes erledigt das Ersetzen für uns
        public void HinzufuegeKreis(Kreis kreis)
        {
            if (Kreise.Count < 3)
            {
                Kreise.Add(kreis);
            }
            else { throw new IndexOutOfRangeException("KreisException: Zu viele Kreise, es dürfen nur 3 sein"); }
        }

        public void LoescheDreieck()
        {
            try
            {
                Dreiecke.RemoveAt(0);
            } catch (ArgumentOutOfRangeException e) 
            { 
                Console.WriteLine("DreieckException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            };
                
        }

        public void LoescheKreis()
        {
            if(Kreise.Count > 1) 
            { 
               Kreise.RemoveAt(1);
            }
            else { throw new ArgumentOutOfRangeException("KreisException: Man kann nicht weniger als 1 Kreis haben"); }

        }
        public void ErsetzeKreis(int index, Kreis kreis)
        {
            try
            {
                Kreise[index] = kreis;

            }
            catch (ArgumentOutOfRangeException e) 
            {
              Console.WriteLine("KreisException");
              Console.WriteLine(e.Message);
              Console.WriteLine(e.StackTrace);
            }

        }
        public void ErsetzeRechteck(int index, Rechteck rechteck)
        {
             try
             {
                Rechtecke[index] = rechteck;

             } 
                catch(ArgumentOutOfRangeException e)
                {
                Console.WriteLine("RechteckException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                };
            
        }

        public void ErsetzeDreieck(int index, Dreieck dreieck)
        {
            try
            {
                Dreiecke[index] = dreieck;

            }
            catch (ArgumentOutOfRangeException e) 
            {
                Console.WriteLine("DreieckException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
            }

        }

    }
}
