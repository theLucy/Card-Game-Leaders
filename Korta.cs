using System;
using Gtk;

namespace cardgame
{
	public class Korta
	{

		public Korta ( KortosTipas tipas, int verte, string sk )
		{
			this.pav = new Image();
			this.tipas = tipas;
			this.verte = verte;
			this.pav.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources."+sk+".bmp");

		}

		public KortosTipas tipas { get; private set; }
		public int verte { get; private set; }
		public Image pav { get; private set; }
	}

	public enum KortosTipas
	{
		Pikai,
		Sirdys,
		Bugnai,
		Kryziai
	}
}

