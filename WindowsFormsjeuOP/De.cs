using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsjeuOP
{
    class De
    {
        Random random = new Random();
        public int lancerDe()
        {
            return random.Next(1,101);
        }
        public int lancerDe(int max)
        {
            return random.Next(1, max);
        }
    }
}
