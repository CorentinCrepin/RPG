using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsjeuOP
{
    class Joueur: EtreVivant
    {
        public Joueur()
        {
            PV = 100;
            Attaque = 200;
            Defence = 20;
            Esquive = 100;
            Precision = 100;
        }
        public override string ToString()
        {
            return "Joueur";
        }

    }
}
