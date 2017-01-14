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
	int kuri = 0, kieno_eile = 1, kur_detix = 200, kur_detiy = 200, einama; //einama - tai ta kuri pasirinkta, bet nepadeta
    cardgame.Kalade Kalade = new cardgame.Kalade();
    cardgame.Zaidejas pirmas = new cardgame.Zaidejas();
    cardgame.Zaidejas antras = new cardgame.Zaidejas();
    cardgame.Zaidejas trecias = new cardgame.Zaidejas();
    cardgame.Zaidejas ketvirtas = new cardgame.Zaidejas();
    cardgame.Zaidejas penktas = new cardgame.Zaidejas();
    cardgame.Zaidejas[] visi = new cardgame.Zaidejas[5];
    cardgame.Stalas ant_stalo = new cardgame.Stalas();

	//Gtk.Fixed.FixedChild ws = ((Gtk.Fixed.FixedChild)(fixed1[image24]));
	Gtk.Image[] pir = new Gtk.Image[15];
	Gtk.Image[] antr = new Gtk.Image[7];
	Gtk.Image[] trec = new Gtk.Image[7];
	Gtk.Image[] ketv = new Gtk.Image[7];
	Gtk.Fixed.FixedChild[] imgsch = new Gtk.Fixed.FixedChild[56];

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
        //vietoj konteineriu uzmeciau fixed grida, kad butu galima su pixeliais dirbt;
		Build ();
		KeyPressEvent += KeyPress;

		priskiria_img();
		w1 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));

        
        label3.Text = "butono koordinates: " + w1.X.ToString() + " " + w1.Y.ToString();


        visi[0] = pirmas;
        visi[1] = antras;
        visi[2] = trecias;
        visi[3] = ketvirtas;
        visi[4] = penktas;

        ant_stalo.dalinimas(4, visi, Kalade);

	}
	void priskiria_img()
	{
		
		
		pir[0] = pir1;
		pir[1] = pir2;
		pir[2] = pir3;
		pir[3] = pir4;
		pir[4] = pir5;
		pir[5] = pir6;
		pir[6] = pir7;
		pir[7] = pir8;
		pir[8] = pir9;
		pir[9] = pir10;
		pir[10] = pir11;
		pir[11] = pir12;
		pir[12] = pir13;
		pir[13] = pir14;
		pir[14] = pir15;

		antr[0] = antr1;
		antr[1] = antr2;
		antr[2] = antr3;
		antr[3] = antr4;
		antr[4] = antr5;
		antr[5] = antr6;
		antr[6] = antr7;

		trec[0] = trec1;
		trec[1] = trec2;
		trec[2] = trec3;
		trec[3] = trec4;
		trec[4] = trec5;
		trec[5] = trec6;
		trec[6] = trec7;

		ketv[0] = ketv1;
		ketv[1] = ketv2;
		ketv[2] = ketv3;
		ketv[3] = ketv4;
		ketv[4] = ketv5;
		ketv[5] = ketv6;
		ketv[6] = ketv7;

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		KeyPressEvent -= KeyPress;
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

		//image2.Pixbuf = trecias.Ranka[2].pav.Pixbuf;
        w1.X = 400;
        w1.Y = 400;


        label3.Text = "butono location: " + w1.X.ToString() + " " + w1.Y.ToString();
        
    }

	protected void OnButton2Clicked(object sender, EventArgs e)
	{
		pirmas_dalinimas();
	}

	void pirmas_dalinimas()
	{
		GUIkalade.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");

		pirmouzv1.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		pirmouzv2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		pirmouzv3.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		pirmoatv1.Pixbuf = pirmas.atverstos[0].pav.Pixbuf;
		pirmoatv2.Pixbuf = pirmas.atverstos[1].pav.Pixbuf;
		pirmoatv3.Pixbuf = pirmas.atverstos[2].pav.Pixbuf;

		antrouzv1.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		antrouzv2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		antrouzv3.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		antroatv1.Pixbuf = antras.atverstos[0].pav.Pixbuf;
		antroatv2.Pixbuf = antras.atverstos[1].pav.Pixbuf;
		antroatv3.Pixbuf = antras.atverstos[2].pav.Pixbuf;

		treciouzv1.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		treciouzv2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		treciouzv3.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		trecioatv1.Pixbuf = trecias.atverstos[0].pav.Pixbuf;
		trecioatv2.Pixbuf = trecias.atverstos[1].pav.Pixbuf;
		trecioatv3.Pixbuf = trecias.atverstos[2].pav.Pixbuf;

		ketvirtouzv1.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		ketvirtouzv2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		ketvirtouzv3.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		ketvirtoatv1.Pixbuf = ketvirtas.atverstos[0].pav.Pixbuf;
		ketvirtoatv2.Pixbuf = ketvirtas.atverstos[1].pav.Pixbuf;
		ketvirtoatv3.Pixbuf = ketvirtas.atverstos[2].pav.Pixbuf;
		for (int i = 0; i < 6; i++)
		{
			pir[i].Pixbuf = pirmas.Ranka[i].pav.Pixbuf;
			antr[i].Pixbuf = antras.Ranka[i].pav.Pixbuf;
			trec[i].Pixbuf = trecias.Ranka[i].pav.Pixbuf;
			ketv[i].Pixbuf = ketvirtas.Ranka[i].pav.Pixbuf;
		}
	}
	void sulygina(int kurio)
	{
		if (kurio == 1)
		{
			for (int i = 0; i < 6; i++)
			{
				if (((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y != 515)
				{
					((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y += 20;
				}
			}
					
		}
	}
	void refresh(int kurio)
	{
		if (Kalade.Kortos.Count != 0) { GUIkalade.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png"); }
		else { GUIkalade.Pixbuf = null;}
		if (ant_stalo.Zaidziamos.Count != 0) { zaidziamos.Pixbuf = ant_stalo.Zaidziamos.Last().pav.Pixbuf; }
		else { zaidziamos.Pixbuf = null; }


		if (kurio == 1)
		{
			for (int i = 0; i < pirmas.Ranka.Count; i++)
			{
				pir[i].Pixbuf = pirmas.Ranka[i].pav.Pixbuf; 

			}
			for (int i = pirmas.Ranka.Count+1; i < 15; i++)
			{
				pir[i].Pixbuf = null;
			}
		}

	}
	[GLib.ConnectBefore]
	protected void KeyPress(object sender, KeyPressEventArgs args)
	{
		
		//Console.WriteLine(args.Event.Key);
		if (kieno_eile == 1)
		{
			
			if (args.Event.Key == Gdk.Key.Right)
			{
				sulygina(1);
				if (kuri <= pirmas.Ranka.Count)
				{
					kuri++;
					((Gtk.Fixed.FixedChild)(fixed1[pir[kuri]])).Y -= 20;
					einama=kuri;

				}
			}
			else if (args.Event.Key == Gdk.Key.Left)
			{
				sulygina(1);
				if (kuri > 0)
				{
					kuri--;
					((Gtk.Fixed.FixedChild)(fixed1[pir[kuri]])).Y -= 20;
					einama = kuri;
				}
			}
			else if (args.Event.Key == Gdk.Key.Up)
			{
				pirmas.Deti_viena_korta(pirmas.Ranka[einama],ant_stalo,Kalade);

				refresh(kieno_eile);
			}
		}
	}

	protected void OnImti3Clicked(object sender, EventArgs e)
	{
		if (kieno_eile == 1)
		{
			
			pirmas.Imti_3(ant_stalo);
			refresh(kieno_eile);
		}
	}

	protected void OnImtiViskaClicked(object sender, EventArgs e)
	{
		if (kieno_eile == 1)
		{

			pirmas.imti_viska(ant_stalo);
			refresh(kieno_eile);
		}
	}
}
