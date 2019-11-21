using System;

namespace GodGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création des êtres vivants initiaux
            Corail martinCorail = new Corail("Martin", 0, "male");
            Dauphin titiDauphin = new Dauphin("Titi", 0, "male");
            Dauphin cornelliaDauphin = new Dauphin("Cornellia", 0, "femelle");
            Corail pouletteCorail = new Corail("Poulette", 0, "femelle");
            Geochelone georgesGeochelone = new Geochelone("Georges", 0, "male");

            //Ajouts dans une liste pour le passer au constructeur de GestVie
            List<EtreVivant> listEtreVivant = new List<EtreVivant>();
            listEtreVivant.Add(martinCorail);
            listEtreVivant.Add(titiDauphin);
            listEtreVivant.Add(cornelliaDauphin);
            listEtreVivant.Add(pouletteCorail);
            listEtreVivant.Add(georgesGeochelone);

            foreach (EtreVivant etreVivant in listEtreVivant)
            {
                Console.Writeline(etreVivant);
            }
            
        }
    }
}
