using System;
using Gtk;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using cardgame;
using System.Runtime.Serialization.Formatters.Binary;

public partial class MainWindow: Gtk.Window
{
    
    Gtk.Fixed.FixedChild w1;
	int kuri = 0, kieno_eile = 1, einama = 0,pries,po; //einama - tai ta kuri pasirinkta, bet nepadeta
	bool[] zaidzia_uzverstom;
    cardgame.Kalade Kalade = new cardgame.Kalade();
    cardgame.Zaidejas pirmas = new cardgame.Zaidejas();
    cardgame.Zaidejas antras = new cardgame.Zaidejas();
    cardgame.Zaidejas trecias = new cardgame.Zaidejas();
    cardgame.Zaidejas ketvirtas = new cardgame.Zaidejas();
    cardgame.Zaidejas penktas = new cardgame.Zaidejas();
	cardgame.Zaidejas[] visi;
    cardgame.Stalas ant_stalo = new cardgame.Stalas();

	Gtk.Image[] pir;
	Gtk.Image[] antr;
	Gtk.Image[] trec;
	Gtk.Image[] ketv;
	Gtk.Fixed.FixedChild[] imgsch = new Gtk.Fixed.FixedChild[56];

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
        //vietoj konteineriu uzmeciau fixed grida, kad butu galima su pixeliais dirbt;
		Build ();
		Imti_viska.Hide();
		imti_3.Hide();
		KeyPressEvent += KeyPress;

		priskiria_img();


        
      

		visi = new cardgame.Zaidejas[] { pirmas, antras, trecias, ketvirtas, penktas };

        ant_stalo.dalinimas(4, visi, Kalade);

	}
	void priskiria_img()
	{
		zaidzia_uzverstom = new bool[] { false, false, false, false };

		pir = new Gtk.Image[] { pir1, pir2, pir3, pir4, pir5, pir6, pir7, pir8, pir9, pir10, pir11,pir12, pir13, pir14, pir15 };
		antr = new Gtk.Image[] { antr1, antr2, antr3, antr4, antr5, antr6, antr7, antr8, antr9, antr10, antr11, antr12, antr13, antr14, antr15 };
		trec = new Gtk.Image[] { trec1, trec2, trec3, trec4, trec5, trec6, trec7 };
		ketv = new Gtk.Image[] { ketv1, ketv2, ketv3, ketv4, ketv5, ketv6, ketv7 };
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		KeyPressEvent -= KeyPress;
		Application.Quit ();
		a.RetVal = true;
	}
    protected void OnButton1Clicked(object sender, EventArgs e)
    {


     
		/*MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,MessageType.Info,ButtonsType.Ok, "l");
        md.Run ();
        md.Destroy();*/



		//image2.Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.42.bmp");

		//image2.Pixbuf = trecias.Ranka[2].pav.Pixbuf;
        w1.X = 400;
        w1.Y = 400;


       
        
    }

	protected void OnButton2Clicked(object sender, EventArgs e)
	{
		button2.Hide();
		pirmas_dalinimas();
		imti_3.Show();
		Imti_viska.Show();
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
			/*pir[i].Pixbuf = pirmas.Ranka[i].pav.Pixbuf;
			antr[i].Pixbuf = antras.Ranka[i].pav.Pixbuf;
			trec[i].Pixbuf = trecias.Ranka[i].pav.Pixbuf;
			ketv[i].Pixbuf = ketvirtas.Ranka[i].pav.Pixbuf;*/
			pir[i].Pixbuf = pirmas.Ranka[i].pav.Pixbuf;
			antr[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
			trec[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
			ketv[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		}
	}
	void sulygina(int kurio)
	{
		if (kurio == 1)
		{
			for (int i = 0; i < pirmas.Ranka.Count; i++)
			{
				if ((((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y != 720)&&(i<8))
				{
					((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y += 20; 
				}
				else if ((((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y != 800) && (i >= 8))  //cia gryba pjaun
				{
					((Gtk.Fixed.FixedChild)(fixed1[pir[i]])).Y += 20;
				}
			}
			if (zaidzia_uzverstom[1]==true)
			{
				if (((Gtk.Fixed.FixedChild)(fixed1[pirmouzv1])).Y != 580){((Gtk.Fixed.FixedChild)(fixed1[pirmouzv1])).Y += 20;}
				if (((Gtk.Fixed.FixedChild)(fixed1[pirmouzv2])).Y != 580) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv2])).Y += 20; }
				if (((Gtk.Fixed.FixedChild)(fixed1[pirmouzv3])).Y != 580) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv3])).Y += 20; }

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
			if (pirmas.atverstos == null)
			{
				pirmoatv1.Pixbuf = null;
				pirmoatv2.Pixbuf = null;
				pirmoatv3.Pixbuf = null;
			}
			if (pirmas.uzverstos[0] == null) { pirmouzv1.Pixbuf = null; }
			if (pirmas.uzverstos[1] == null) { pirmouzv2.Pixbuf = null; }
			if (pirmas.uzverstos[2] == null) { pirmouzv3.Pixbuf = null; }
			for (int i = 0; i < pirmas.Ranka.Count; i++)
			{
				pir[i].Pixbuf = pirmas.Ranka[i].pav.Pixbuf; 

			}
			for (int i = pirmas.Ranka.Count; i < 15; i++)
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

				if ((kuri < pirmas.Ranka.Count - 1) || (zaidzia_uzverstom[kieno_eile] == true))
				{
					sulygina(1);
					kuri++;
					if (zaidzia_uzverstom[kieno_eile] == true)
					{
						if (kuri == 0) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv1])).Y -= 20; }
						else if (kuri == 1) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv2])).Y -= 20; }
						else { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv3])).Y -= 20; }

					}
					else 
					{ 
						((Gtk.Fixed.FixedChild)(fixed1[pir[kuri]])).Y -= 20; 
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
					}
					einama = kuri;

				}
			}
			else if (args.Event.Key == Gdk.Key.Left)
			{


				if ((kuri > 0) || (zaidzia_uzverstom[kieno_eile] == true))
				{
					sulygina(1);
					kuri--;
					if (zaidzia_uzverstom[kieno_eile] == true)
					{
						if (kuri == 0) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv1])).Y -= 20; }
						else if (kuri == 1) { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv2])).Y -= 20; }
						else { ((Gtk.Fixed.FixedChild)(fixed1[pirmouzv3])).Y -= 20; }

					}
					else 
					{ 
						((Gtk.Fixed.FixedChild)(fixed1[pir[kuri]])).Y -= 20; 
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
					}
					einama = kuri;
				}
			}
			else if (args.Event.Key == Gdk.Key.Down)
			{
				
				if (zaidzia_uzverstom[kieno_eile] == true)
				{
					pirmas.paimti_uzversta(einama); //viduje tikrina ar turi rankoje kortu, jei taip, nieko nedaro
					zaidzia_uzverstom[kieno_eile] = false;
				}
				refresh(kieno_eile);
			}
			else if (args.Event.Key == Gdk.Key.Up)
			{
				
				pries = ant_stalo.Zaidziamos.Count;

				if ( !((pirmas.Ranka.Count - 1) < einama) && pirmas.Deti_viena_korta(pirmas.Ranka[einama], ant_stalo, Kalade))
				{
					Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
				}

				po = ant_stalo.Zaidziamos.Count;

				pirmas.paimti_atverstas(Kalade); //viduje tikrina ar turi rankoje kortu, jei taip, nieko nedaro

				if ((pirmas.atverstos == null) && (pirmas.Ranka.Count== 0))
				{
					zaidzia_uzverstom[kieno_eile] = true;
				}
				refresh(kieno_eile);
				//if (pries != po) { kuri = 1; kieno_eile++;}

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




	/* Issaugojimo i faila metodai
	 * Pvz:
	 * 	int[] mas = new int[] { 1, 5, 4,3 ,2 , 1};
	 *  Serialize(mas, "mas.bin");
	 *  int[] mas2 = (int[])Deserialize("mas.bin");	 
	 */

	public void Serialize(object t, string path)
	{
		using (Stream stream = File.Open(path, FileMode.Create))
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(stream, t);
		}
	}

	public object Deserialize(string path)
	{
		object result;
		if (!File.Exists(path))
		{
			result = null;
		}
		else
		{
			using (Stream stream = File.Open(path, FileMode.Open))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				result = binaryFormatter.Deserialize(stream);
			}
		}
		return result;
	}
}
