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
        public void dalinimas(int kiek_zaideju, Zaidejas[] visi, Kalade k)
        {
            for (int i = 0; i < kiek_zaideju; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    visi[i].uzverstos[j] = k.Kortos.First();
                    k.Kortos.RemoveAt(0);
                }

            }
            for (int i = 0; i < kiek_zaideju; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    visi[i].atverstos[j] = k.Kortos.First();
                    k.Kortos.RemoveAt(0);
                }

            }
            for (int i = 0; i < kiek_zaideju; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    visi[i].Ranka.Add(k.Kortos.First());
                    k.Kortos.RemoveAt(0);
                }

            }

        }
    }
}
