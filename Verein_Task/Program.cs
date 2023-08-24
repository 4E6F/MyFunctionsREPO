namespace Verein_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vereine");

            Praesident Hans = new Praesident("Hans");
            Praesident Peter = new Praesident("Peter");
            Praesident Eve = new Praesident("Eve");
            PhysioTherapeutin Anna = new PhysioTherapeutin("Anna");


            Verein fcBasel = new Verein("FCBasel",Hans, Anna); 
            Verein fcZuerich = new Verein("FCZuerich",Peter);
            Verein fcBerneck = new Verein("FCBerneck",Eve);

            Hans.ErhaeltVereinName(fcBasel);
            Peter.ErhaeltVereinName(fcZuerich);
            Eve.ErhaeltVereinName(fcBerneck);


            
            

            // Erstellen einer Mannschaft im FC Basel Verein

            Mannschaft mannschaftBS = new Mannschaft("Happy Year");

            // Spieler der Mannschaft hinzufügen 
            mannschaftBS.FeldSpielers = new List<FeldSpieler> { new FeldSpieler("Gustav"), new FeldSpieler("Peter"), new FeldSpieler("John") };
            mannschaftBS.Torwarts = new List<Torwart> { new Torwart("Claude"), new Torwart("Bernhardt") };

            // jeder Spieler wird Offiziel vom Präsidenten unter Vertrag genommen

            foreach(FeldSpieler spieler in mannschaftBS.FeldSpielers)
            {
                Hans.UnterzeichenFeldSpieler(spieler);
            }

            foreach(Torwart spieler in mannschaftBS.Torwarts)
            {
                Hans.UnterzeichnenTorwart(spieler);
            }


            // hier könnten wir weitere Spieler hinzufügen wenn Präsident unterzeichnet
            //...


            //Mannschaft hinzufügen in den Verein Basel
            fcBasel.AddMannschaft(mannschaftBS);

            // Gustav schiesst ein Tor
            mannschaftBS.FeldSpielers.ElementAt(0).schiesseTor();
            // Claude hält den Ball
            mannschaftBS.Torwarts.ElementAt(0).BaelleHalten();
            //Physiotherapeutin massiert Peter
            fcBasel.PhysioTherapeutin.Massieren(mannschaftBS.FeldSpielers.ElementAt(1).Name);
            
        }
    }
}