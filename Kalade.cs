using System;
using System.Collections.Generic;

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
            for (int i = 2; i < 15; i++)
            {
                Kortos.Add(new Korta(KortosTipas.Pikai, i));
                Kortos.Add(new Korta(KortosTipas.Kryziai, i));
                Kortos.Add(new Korta(KortosTipas.Bugnai, i));
                Kortos.Add(new Korta(KortosTipas.Sirdys, i));
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

