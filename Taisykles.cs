using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    public class Taisykles
    {
        public Taisykles()
        {

        }
        public bool Tikrina(Korta dedu, Korta ant)
        {
            if ((dedu.verte == 2) || (dedu.verte == 10) || (dedu.verte >= ant.verte)) { return true; }
            else { return false; }

        }
       
    }
}
