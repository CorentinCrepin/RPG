using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsjeuOP
{
    class Monstre :EtreVivant
    {
        public string TypeMonstre { get; set; }
        static public int NombreDeMonstreFaible { get; set; } = 0;
        static public int NombreDeMonstreFort { get; set; } = 0;

        public Monstre(string typeMonstre)
        {
            TypeMonstre = typeMonstre;
            initialise();
        }
        public void initialise()
        {
            if (TypeMonstre=="faible")
            {
                PV = 50;
                Attaque = 80;
                Defence = 10;
                Esquive = 80;
                Precision = 80;
                NombreDeMonstreFaible++;
            }
            else
            {
                PV = 75;
                Attaque = 100;
                Defence = 20;
                Esquive = 90;
                Precision = 90;
                NombreDeMonstreFort++;
            }
        }
        public override string ToString()
        {
            if (TypeMonstre=="faible")
            {
                return "Monstre Faible";
            }
            else
            {
                return "Monstre Fort";
            }
            
        }
    }
}
