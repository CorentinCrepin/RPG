using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsjeuOP
{
    public partial class Form1 : Form
    {
        //Joueur joueur = new Joueur();
        //Monstre monstre = new Monstre("faible");
        //CoupPorter coupPorter;
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            lancerPhaseDeJeux();

            // do the end of the game
            // do the stats
            // do the PV bar

        }
        private void lancerPhaseDeJeux()
        {
            controller.PhaseDeJeu();
            AffichageCentrale(controller.AfficheresultatTour());

        }
        public void AffichageCentrale(string text)
        {
            this.TxtCenter.AppendText(text);
        }
        public void FindePartie()
        {

        }
    }
}
