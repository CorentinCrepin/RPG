using System;

namespace WindowsFormsjeuOP
{
    public class CoupPorter
    {
        public EtreVivant Attaquant { get; set; }
        public EtreVivant Defenceur { get; set; }
        public int Attaque { get; set; }
        public int Defence { get; set; }
        public int Degat { get; set; }
        public CoupPorter(EtreVivant attaquant,EtreVivant defenceur)
        {
            Attaquant = attaquant;
            Defenceur = defenceur;
            De de = new De();

            Attaque = de.lancerDe() + Attaquant.Attaque;
            Defence = de.lancerDe() + Defenceur.Defence;
            Degat = (Attaque - Defence)/10;

            executer();
        }
        public void executer()
        {
            if (Degat>0)
            {
                Defenceur.priseDeDegat(Degat);
            }
        }
        public string affichage()
        {
            string text;
            if (Degat> 0)
            {
                text = $"L'attaque du {Attaquant} a réussit ({Attaque }/{Defence})";
                text += Environment.NewLine;
                text += $"{Defenceur} a subit {Degat} dégats. ";
                if (Defenceur.EnVie )
                {
                    text += $"Il lui reste {Defenceur.PV} PV.";
                }
                else
                {
                    text += $"{Defenceur} est mort.";
                }
            }
            else
            {
                text = $"L'attaque du {Attaquant} a echoué ({Attaque }/{Defence})";
            }

            text += Environment.NewLine;
            return text;
        }
    }
}