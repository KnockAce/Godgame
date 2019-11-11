using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public class Corail : EtreVivant
    {
        public Corail(string p_nom, byte p_nombreParents, Regne p_regne, GenreVivant p_genreVivant, string p_sexe) :
            base(p_nom, p_nombreParents, Regne.Animal, GenreVivant.EucaryotesMulticellulaires, p_sexe)
        {
        }

        public override void Deplace()
        {
            Console.WriteLine($"{m_nom} ne se deplace pas");
        }

        public override string ToString()
        {
            return $"{m_nom} est un corail ayant {m_nombreParents} de regne Animal et est un eucaryote multicellulaires";
        }
    }
}
