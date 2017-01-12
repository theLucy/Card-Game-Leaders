using System;
using System.Collections.Generic;
using Gtk;

namespace cardgame
{
    public class Kalade
    {
        public List<Korta> Kortos = new List<Korta>();
        public Kalade()
        {
            kurti_kortas();
            maisyti();

        }
        void kurti_kortas()
        {
			Image p = new Image();
			Image k = new Image();
			Image b = new Image();
			Image s = new Image();
            for (int i = 2; i < 15; i++)
            {
				if (i < 10)
				{
					Kortos.Add(new Korta(KortosTipas.Pikai, i, "4"+i.ToString()));
					Kortos.Add(new Korta(KortosTipas.Kryziai, i, "3" + i.ToString()));
					Kortos.Add(new Korta(KortosTipas.Bugnai, i, "2" + i.ToString()));
					Kortos.Add(new Korta(KortosTipas.Sirdys, i, "1" + i.ToString()));

				}
				else if (i==10)
				{
					Kortos.Add(new Korta(KortosTipas.Pikai, i, "50"));
					Kortos.Add(new Korta(KortosTipas.Kryziai, i, "40"));
					Kortos.Add(new Korta(KortosTipas.Bugnai, i, "30"));
					Kortos.Add(new Korta(KortosTipas.Sirdys, i, "20"));
				}
				else
				{
					Kortos.Add(new Korta(KortosTipas.Pikai, i, "15" + (i-10).ToString()));
					Kortos.Add(new Korta(KortosTipas.Kryziai, i, "14" + (i - 10).ToString()));
					Kortos.Add(new Korta(KortosTipas.Bugnai, i, "13" + (i - 10).ToString()));
					Kortos.Add(new Korta(KortosTipas.Sirdys, i, "12" + (i - 10).ToString()));
				}
                //2-10 skaiciai, J-11, Q-12, K-13, A-14
            }
        }
        public void maisyti()
        {
            Random rnd = new Random();
            int n = Kortos.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Korta v = Kortos[k];
                Kortos[k] = Kortos[n];
                Kortos[n] = v;
            }
        }

    }
}

