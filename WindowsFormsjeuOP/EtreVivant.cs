using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsjeuOP
{

    public class EtreVivant
    {   /// <summary>
        /// point de vie
        /// </summary>
        public int PV { get; set; } 
        /// <summary>
        /// 
        /// </summary>
        public int Attaque { get; set; }
        public int Defence { get; set; }
        public int Esquive { get; set; }
        public int Precision { get; set; }
        public bool EnVie { get; set; } = true;

        De de = new De();

        public void priseDeDegat(int degat)
        { 
                PV = PV - degat;

            if (PV <= 0)
            {
                PV = 0;
                EnVie = false;
            }
        }
        public CoupPorter TetativeAttaque(EtreVivant enemie)
        {
            CoupPorter coupPorter = new CoupPorter(this, enemie);
            return coupPorter;
        }
    }
}
