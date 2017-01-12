using System;
using Gtk;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class MainWindow: Gtk.Window
{
    
    Gtk.Fixed.FixedChild w1;

    cardgame.Kalade Kalade = new cardgame.Kalade();
    cardgame.Zaidejas pirmas = new cardgame.Zaidejas();
    cardgame.Zaidejas antras = new cardgame.Zaidejas();
    cardgame.Zaidejas trecias = new cardgame.Zaidejas();
    cardgame.Zaidejas ketvirtas = new cardgame.Zaidejas();
    cardgame.Zaidejas penktas = new cardgame.Zaidejas();
    cardgame.Zaidejas[] visi = new cardgame.Zaidejas[5];
    cardgame.Stalas ant_stalo = new cardgame.Stalas();
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
        //vietoj konteineriu uzmeciau fixed grida, kad butu galima su pixeliais dirbt;
		Build ();


        w1 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));

        
        label3.Text = "butono koordinates: " + w1.X.ToString() + " " + w1.Y.ToString();


        visi[0] = pirmas;
        visi[1] = antras;
        visi[2] = trecias;
        visi[3] = ketvirtas;
        visi[4] = penktas;

        ant_stalo.dalinimas(5, visi, Kalade);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
    protected void OnButton1Clicked(object sender, EventArgs e)
    {


        label4.Text = trecias.Ranka[0].tipas.ToString() + " " + trecias.Ranka[0].verte.ToString() + "|"+
             trecias.Ranka[1].tipas.ToString() + " " + trecias.Ranka[1].verte.ToString() + "|" +
              trecias.Ranka[2].tipas.ToString() + " " + trecias.Ranka[2].verte.ToString();
		/*MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,MessageType.Info,ButtonsType.Ok, "l");
        md.Run ();
        md.Destroy();*/



		//image2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.42.bmp");


		image2.Pixbuf = trecias.Ranka[2].pav.Pixbuf;
        w1.X = 400;
        w1.Y = 400;
        label3.Text = "butono location: " + w1.X.ToString() + " " + w1.Y.ToString();
        
    }
    
}
