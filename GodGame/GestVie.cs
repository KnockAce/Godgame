using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class GestVie<T>
    {
        private List<T> m_listEtreVivant;

        /// <summary>
        /// Constructeur prenant en entrée une liste d'être vivant à animer
        /// </summary>
        /// <param name="p_listEtreVivant">La liste d'êtres vivants à animer</param>
        public GestVie(List<T> p_listEtreVivant)
        {
            m_listEtreVivant = p_listEtreVivant;
        }
    }
}
