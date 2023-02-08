using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Port
    {
        private string nom;
        private int nbNaviresMax;
        private List<Navire> navires;

        public Port(string nom)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
            this.navires = new List<Navire>();
        }

        public string Nom { get => nom; }
        public int NbNavireMax { get => nbNaviresMax; }

        public void EnregistrerArrivee(Navire navire)
        {
            if (navires.Count < nbNaviresMax)
            {
                navires.Add(navire);
            }
            else
            {
                throw new Exception("Ajout impossible, le port est complet");
            }
        }

        public void EnregistrerDepart(String imo)
        {
            if (navires.Exists(x => x.Imo == imo))
            {
                navires.RemoveAt(navires.FindIndex(x => x.Imo == imo));
            }
        }

        public bool EstPresent(String imo)
        {
            return navires.Exists(x => x.Imo == imo);
        }

        private int RecupPosition(String imo)
        {
            try
            {
                return navires.FindIndex(x => x.Imo == imo);
            }
            catch { return -1; }
        }

        private int RecupPosition(Navire navire)
        {
            try
            {
                
            }
        }
    }
}
