using System.Runtime.CompilerServices;

namespace GeoShapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //-----------------------------------
            // Kreiere Linien
            Console.WriteLine("Start des Programmes");
            Linie linieA = new Linie(6);
            Linie linieB = new Linie(8);
            Linie linieC = new Linie(8);
            Linie linieD = new Linie(6);
            Console.WriteLine("LinieA "+ linieA.Laenge);
            Console.WriteLine("LinieB " + linieB.Laenge);
            Console.WriteLine("LinieC " + linieC.Laenge);
            Console.WriteLine("LinieD " + linieD.Laenge);
            Console.WriteLine("");

            //-----------------------------------
            // Kreiere Kreise

            Kreis kreis1 = new Kreis(linieA);
            Console.WriteLine("Umfang Kreis1: " + kreis1.BerechneUmfang());
            Console.WriteLine("Flaeche Kreis1: " + kreis1.BerechneFlaeche());
            Kreis kreis2 = new Kreis(linieB);
            Console.WriteLine("Umfang Kreis2: " + kreis2.BerechneUmfang());
            Console.WriteLine("Flaeche Kreis2: " + kreis2.BerechneFlaeche());

            Kreis kreis3 = new Kreis(linieC);
            Console.WriteLine("Umfang Kreis3: " + kreis3.BerechneUmfang());
            Console.WriteLine("Flaeche Kreis3: " + kreis3.BerechneFlaeche());
            Console.WriteLine("");

            try
            {
                //-----------------------------------
                // Kreiere Dreiecke

                Dreieck dreieck1 = new Dreieck(linieA, linieB, linieC);
                Console.WriteLine("Umfang dreieck1: " + dreieck1.BerechneUmfang());
                Console.WriteLine("Flaeche dreieck1: " + dreieck1.BerechneFlaeche());
                Console.WriteLine("");

                //-----------------------------------
                // Kreiere Rechteck

                Rechteck rechteck1 = new Rechteck(linieA, linieB, linieC, linieD);
                Console.WriteLine("Umfang rechteck1: " + rechteck1.BerechneUmfang());
                Console.WriteLine("Flaeche rechteck1: " + rechteck1.BerechneFlaeche());
                Console.WriteLine("");

                Rechteck rechteck2 = new Rechteck(new Linie(10), new Linie(6), new Linie(6), new Linie(10));
                Console.WriteLine("Umfang rechteck2: " + rechteck2.BerechneUmfang());
                Console.WriteLine("Flaeche rechteck2: " + rechteck2.BerechneFlaeche());
                Console.WriteLine("");

                //-----------------------------------
                // Kreiere Formbehälter
                // Aufgabe im Portfolio Formbehälter mit 2 Rechtecken, 1 Dreieck, 3 Kreise
                Formbehaelter formbehaelter1 = new Formbehaelter(rechteck1, rechteck2, kreis1);

                formbehaelter1.HinzufuegeDreieck(dreieck1);
                formbehaelter1.HinzufuegeKreis(kreis2);
                formbehaelter1.HinzufuegeKreis(kreis3);
                Console.WriteLine("");


                //-----------------------------------------------------------
                // PLAYGROUND (Die folgenden CodeZeilen sind zusätliche Methoden,welche sie  sich gerne  anschauen können)
                Console.WriteLine("PLAYGROUND");
                // Sonstige Formbehälter, die einfach nur darstellen sollen das es eine Aggregation ist da es mehrere Formbehälter haben kann
                Console.WriteLine("FormbehälterTest");
                Formbehaelter formbehaelterTest = new Formbehaelter(rechteck1, rechteck2, kreis1);
                formbehaelterTest.HinzufuegeDreieck(dreieck1);


                //throws eine Exception wenn zuviele Dreiecke
                /*formbehaelterTest.HinzufuegeDreieck(dreieck1);
                formbehaelterTest.HinzufuegeDreieck(dreieck1);
                formbehaelterTest.HinzufuegeDreieck(dreieck1);
                */

                /* // throws exception 
                formbehaelterTest.LoescheDreieck();
                formbehaelterTest.LoescheDreieck();
                */
                Console.WriteLine("");
                formbehaelterTest.HinzufuegeDreieck(new Dreieck(new Linie(9), new Linie(8), new Linie(5)));
                ListDreieckToString(formbehaelterTest);
                formbehaelterTest.LoescheDreieck();
                formbehaelterTest.LoescheDreieck();
                
                ListDreieckToString(formbehaelterTest); // nach der  Löschung

                Console.WriteLine("");
                // gleiche mit Kreisen

                formbehaelterTest.HinzufuegeKreis(kreis2);
                formbehaelterTest.HinzufuegeKreis(kreis3);

                // throws eine Exception wenn zu viele Kreise
                //formbehaelterTest.HinzufuegeKreis(kreis3);
                //formbehaelterTest.HinzufuegeKreis(kreis3);

                Console.WriteLine("Kreis2Flaeche: " + formbehaelterTest.Kreise[1].BerechneFlaeche());
                Console.WriteLine("Kreis3Flaeche: " + formbehaelterTest.Kreise[2].BerechneFlaeche());
                Console.WriteLine("");

                //Wenn Kreise gelöscht werden dann bleibt der erster Kreis, der vom Konstruktor am Anfang erstellt wurde, immer noch bestehen
                ListKreisToString(formbehaelterTest);
                formbehaelterTest.LoescheKreis();
                formbehaelterTest.LoescheKreis();
                //formbehaelterTest.LoescheKreis(); // hier kann es nicht weniger als 1 kreis geben erzeugt eine KreisException
                ListKreisToString(formbehaelterTest);
                Console.WriteLine("Kreis1Flaeche: " + formbehaelterTest.Kreise[0].BerechneFlaeche());
                Console.WriteLine("");

                // ich ersetze nun den Kreis an dem Index 0 mit einem Neuen Kreis mit Umfang 19 mit dem möchte ich zeigen das der Formbehälter 
                // immer noch mindestens 1 Kreis, nur mit einem anderen Wert  
                formbehaelterTest.ErsetzeKreis(0, new Kreis(new Linie(19)));
                Console.WriteLine("KreisMit19Flaeche: " + formbehaelterTest.Kreise[0].BerechneFlaeche());
                Console.WriteLine("");

                // ersetzeMethoden

                Formbehaelter formbehaelterTest2 = new Formbehaelter(rechteck1, rechteck2, kreis1);

                formbehaelterTest2.HinzufuegeDreieck(dreieck1);
                formbehaelterTest2.HinzufuegeDreieck(dreieck1);
                formbehaelterTest2.HinzufuegeDreieck(dreieck1);
                formbehaelterTest2.HinzufuegeDreieck(dreieck1);


                // vor Ersetzen Methode
                Console.WriteLine("vor Ersetze Methoden");
                Console.WriteLine(formbehaelterTest2.Dreiecke[0].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[1].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[2].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[3].BerechneFlaeche());
                Console.WriteLine("");

                // nach Ersetzen Methode
                Console.WriteLine("nach Ersetze Methoden");
                formbehaelterTest2.ErsetzeDreieck(0, new Dreieck(new Linie(3), new Linie(4), new Linie(5)));

                Console.WriteLine(formbehaelterTest2.Dreiecke[0].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[1].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[2].BerechneFlaeche());
                Console.WriteLine(formbehaelterTest2.Dreiecke[3].BerechneFlaeche());
                Console.WriteLine("");

                // gleiche kann auch mit Kreis und Rechteck gemacht werden

                // wenn ein zu kleiner index oder zu grosser Index eingeben dann throwed es eine Exception
                Console.WriteLine("Testline");
                
                    formbehaelterTest2.ErsetzeDreieck(9, dreieck1);
                
            }
            catch (ArgumentException ex) 
            { 
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
            
            

            


        }
        private static void ListDreieckToString(Formbehaelter formbehaelter)
        {
            Console.Write("Liste: ");
            Console.Write("[");
            foreach (Dreieck i in formbehaelter.Dreiecke)
            {
               
               Console.Write("[");
               Console.Write(i.ToString()) ;
               Console.Write("]");
               
            }
            Console.WriteLine("]");
        }
        private static void ListKreisToString(Formbehaelter formbehaelter)
        {
            Console.Write("Liste: ");
            Console.Write("[");
            foreach (Kreis i in formbehaelter.Kreise)
            {

                Console.Write("[");
                Console.Write(i.ToString());
                Console.Write("]");

            }
            Console.WriteLine("]");
        }
        private static void ListRechteckeToString(Formbehaelter formbehaelter)
        {
            Console.Write("Liste: ");
            Console.Write("[");
            foreach (Rechteck i in formbehaelter.Rechtecke)
            {

                Console.Write("[");
                Console.Write(i.ToString());
                Console.Write("]");

            }
            Console.WriteLine("]");
        }
    }
}