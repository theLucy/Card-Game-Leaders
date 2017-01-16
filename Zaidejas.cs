using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;

namespace cardgame
{
    public class Zaidejas : Taisykles
    {
        public Korta[] uzverstos = new Korta[3];
        public Korta[] atverstos = new Korta[3];
        public List<Korta> Ranka = new List<Korta>();
        public Zaidejas()
        {

        }
        public bool Deti_viena_korta(Korta ka,Stalas stalas,Kalade kalade)
        {
			if (stalas.Zaidziamos.Count != 0)
			{
				if (Tikrina(ka, stalas.Zaidziamos.Last()))
				{
					stalas.Padejo(ka);
					Ranka.Remove(ka);
					imti_po_dejimo(kalade);
				}
				else { return false; }

            }
            else { stalas.Padejo(ka); Ranka.Remove(ka); imti_po_dejimo(kalade);}

			return true;
        }

        public void imti_po_dejimo(Kalade kalade)
        {
			if (kalade.Kortos.Count > 0)
			{
				while (Ranka.Count < 6)
				{
					Ranka.Add(kalade.Kortos.First());
					kalade.Kortos.RemoveAt(0);
				}
			}
        }

        public bool paimti_atverstas(Kalade kalade)
        {
			if ((atverstos!=null) &&(Ranka.Count() == 0) && (kalade.Kortos.Count() == 0))
            {
                Ranka.AddRange(atverstos);
                atverstos = null;
				return true;
            }
			return false;
        }

        public void paimti_uzversta(int einama)
        {

			for (int i = 0; i < 3; i++)
			{ 
				if (uzverstos[i] != null  && (atverstos == null) && (Ranka.Count() == 0))
				{
					Ranka.Add(uzverstos[i]);
					uzverstos[i] = null;
				}
			}
        }

        public bool Imti_3(Stalas stalas)
        {
			if (stalas.Zaidziamos.Count > 2)
			{
				for (int i = 0; i < 3; i++)
				{
					Ranka.Add(stalas.Zaidziamos.Last());
					stalas.Zaidziamos.RemoveAt(stalas.Zaidziamos.Count - 1);

				}
				return true;
			}
			return false;  
        }
        public void imti_viska(Stalas stalas)
        {
            Ranka.AddRange(stalas.Zaidziamos);
            stalas.Zaidziamos.Clear();
        }

    }
}
