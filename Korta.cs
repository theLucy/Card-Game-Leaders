using System;

namespace cardgame
{
	public class Korta
	{

		public Korta ( KortosTipas tipas, int verte )
		{
			this.tipas = tipas;
			this.verte = verte;
		}

		public KortosTipas tipas { get; private set; }
		public int verte { get; private set; }
	}

	public enum KortosTipas
	{
		Pikai,
		Sirdys,
		Bugnai,
		Kryziai
	}
}

