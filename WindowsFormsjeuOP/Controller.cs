using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsjeuOP
{
    public class Controller
    {
        Form1 form;
        Joueur joueur = new Joueur();
        Monstre monstre = new Monstre("faible");
        CoupPorter coupPorter;

        public bool TourJoueur { get; set; } = true;

        public Controller(Form1 form)
        {
            this.form = form;
        }


        public string AfficheresultatTour()
        {
            return coupPorter.affichage();
        }
        public void PhaseDeJeu()
        {
            if (TourJoueur)
            {
                if (joueur.EnVie)
                {
                    coupPorter = joueur.TetativeAttaque(monstre);
                    TourJoueur = false;
                }
                else
                {
                    FinDeParitie();
                }
            }
            else
            {
                TourJoueur = true;
                if (monstre.EnVie)
                {
                    coupPorter = monstre.TetativeAttaque(joueur);
                }
                else
                {
                    monstre = new Monstre("faible");
                    OnCreationDeMonstre();
                }
                
            }
            ////this.TxtCenter.AppendText(controller.AfficheresultatTour());
            //form.TxtCenter.AppendText(""); // TxtCenter est en private... je sais pas si je doit faire comme ca... peut etre avec le binding ?
        }
        private void OnCreationDeMonstre()
        {
            string text = $"Nouveau monstre {monstre.TypeMonstre}";
            text += Environment.NewLine;
            form.AffichageCentrale(text);
            PhaseDeJeu();
        }
        private void FinDeParitie()
        {
            string text = $"Vous avez perdu";
            text += Environment.NewLine;
            form.AffichageCentrale("Vous avez perdu");
        }
    }
}
