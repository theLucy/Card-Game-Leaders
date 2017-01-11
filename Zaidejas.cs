using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Zaidejas : Taisykles
    {
        public Korta[] uzverstos = new Korta[3];
        public Korta[] atverstos = new Korta[3];
        public List<Korta> Ranka = new List<Korta>();
        public Zaidejas()
        {

        }
        public void Deti_viena_korta(Korta ka,Stalas stalas,Kalade kalade)
        {
            if (stalas.Zaidziamos.Count != 0)
            { 
                if (Tikrina(ka, stalas.Zaidziamos.First()) == true) { stalas.Padejo(ka);Ranka.Remove(ka); };
                
            }
            else { stalas.Padejo(ka); Ranka.Remove(ka); }
            imti_po_dejimo(kalade);
        }

        public void imti_po_dejimo(Kalade kalade)
        {
            while ((Ranka.Count <= 6) || (kalade.Kortos.Count > 0))
            {
                Ranka.Add(kalade.Kortos.First());
                kalade.Kortos.RemoveAt(0);
            }
        }

        public void paimti_atverstas(Kalade kalade)
        {
            if ((Ranka.Count() == 0) && (kalade.Kortos.Count() == 0))
            {
                Ranka.AddRange(uzverstos);
                uzverstos = null;
            }
            else
            {
                //MessageBox.Show("nesvaik blt");
            }

        }

        public void paimti_uzversta(int kuri)
        {
            if ((uzverstos == null) && (Ranka.Count() == 0))
            {
                Ranka.Add(uzverstos[kuri]);
                uzverstos[kuri] = null;
            }
            else
            {
                //MessageBox.Show("tu rimtai dx?");
            }
        }
        public void Deti_daugiau_kortu()
        {

        }
        public void Imti_3(Stalas stalas)
        {
            for (int i = 0; i < 3; i++)
            {
                Ranka.Add(stalas.Zaidziamos.First());
                stalas.Zaidziamos.RemoveAt(0);
            }
                
        }
        public void imti_viska(Stalas stalas)
        {
            Ranka.AddRange(stalas.Zaidziamos);
            stalas.Zaidziamos.Clear();
        }

    }
}
