using System;

namespace TP1Navire
{
    class Program
    {
        static void Main()
        {
            TesterInstanciations();

            Console.ReadKey();
        }

        public static void TesterInstanciations()
        {
            // déclaration de l'objet unNavire de la classe Navire
            Navire unNavire;
            // Instanciation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
            Affiche(unNavire);
            // Declaration ET instanciation d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);
            Affiche(unAutreNavire);
            // ??
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Affiche(unAutreNavire);
        }

        public static void Affiche(Navire navire)
        {
            Console.WriteLine($"Identification : {navire.Imo} ");
            Console.WriteLine($"Nom :   {navire.Nom}");
            Console.WriteLine($"Type de frêt :  {navire.LibelleFret}");
            Console.WriteLine($"Quantité de Frêt :      {navire.QteFretMaxi}");
            Console.WriteLine("-------------------------------");
        }
    }
}
