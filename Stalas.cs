using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    
    public class Stalas : Taisykles
    {
        public List<Korta> Zaidziamos = new List<Korta>();
        public Stalas()
        {
            
        }
        public void Padejo(Korta ka)
        {
            if (ka.verte == 10) { Zaidziamos.Clear(); }
           // else if (/*4 vienodos*/){Zaidziamos.Clear();}
            else { Zaidziamos.Add(ka); }
        }
    }
}
