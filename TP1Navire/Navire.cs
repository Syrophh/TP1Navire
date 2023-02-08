using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Navire
    {
        private string imo;
        private string nom;
        private string libelleFret;
        private string qteFretMaxi;

        public Navire(string imo, string nom, string libelleFret, int qteFretMaxi)
        {
            this.imo = imo;
            this.nom = nom;
            this.libelleFret = libelleFret;
            this.qteFretMaxi = qteFretMaxi.ToString();
        }
        public Navire(string imo, string nom): this(imo, nom, "Indéfini", 0) { }

        public string Imo { get => imo; set => imo = value; }
        public string Nom { get => nom; set => nom = value; }
        public string LibelleFret { get => libelleFret; set => libelleFret = value; }
        public string QteFretMaxi { get => qteFretMaxi; set => qteFretMaxi = value; }
    }
}
