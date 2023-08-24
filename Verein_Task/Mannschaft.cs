using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein_Task
{
    internal class Mannschaft
    {
        public List<FeldSpieler> FeldSpielers { get; set; } = new List<FeldSpieler>();
        public List<Torwart> Torwarts { get; set; } = new List<Torwart>();
        public string Motto { get; set; }

        public Mannschaft(string motto)
        {
            Motto = motto;
        }

        public string SchreibeNameFeldSpieler(FeldSpieler feldSpieler) { 
            
            int indexVomFSpieler = FeldSpielers.IndexOf(feldSpieler);

            return FeldSpielers.ElementAt(indexVomFSpieler).Name;
        }

        public string SchreibeNameTorwart(Torwart torwart)
        {
            int indexVomTorwart = Torwarts.IndexOf(torwart);

            return FeldSpielers.ElementAt(indexVomTorwart).Name;
        }

        public void AddFeldSpieler(FeldSpieler spieler)
        {
            if (spieler.IstUnterzeichnet) { FeldSpielers.Add(spieler); }
            
        }
        public void RemoveFeldSpieler(FeldSpieler spieler)
        {
            FeldSpielers.Remove(spieler);
            spieler.IstUnterzeichnet = false;
        }

        public void AddTorwart(Torwart spieler)
        {
            if(spieler.IstUnterzeichnet) { Torwarts.Add(spieler); }
            
        }
        public void RemoveTorwart(Torwart spieler)
        {
            Torwarts.Remove(spieler);
            spieler.IstUnterzeichnet = false;
        }
    }
}
