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
using System.Threading;

public partial class MainWindow: Gtk.Window
{
    
   
	int kuri = 0, kieno_eile = 1, einama = 0,pries,po; //einama - tai ta kuri pasirinkta, bet nepadeta
	bool[] zaidzia_uzverstom;
	bool[] kas_laimejo; 
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
		kas_laimejo = new bool[] { false, false, false, false };
		pir = new Gtk.Image[] { pir1, pir2, pir3, pir4, pir5, pir6, pir7, pir8, pir9, pir10, pir11, pir12, pir13, pir14, pir15, pir16, pir17, pir8, pir19, pir20 };
		antr = new Gtk.Image[] { antr1, antr2, antr3, antr4, antr5, antr6, antr7, antr8, antr9, antr10, antr11, antr12, antr13, antr14, antr15, antr16, antr17, antr18, antr19, antr20, antr21, antr22, antr23, antr24, antr25, antr26, antr27, antr28, antr29, antr30};
		trec = new Gtk.Image[] { trec1, trec2, trec3, trec4, trec5, trec6, trec7, trec8, trec9, trec10, trec11, trec12, trec13, trec14, trec15, trec16, trec17, trec18, trec19, trec20, trec21, trec22, trec23, trec24, trec25, trec26, trec27, trec28, trec29, trec30 };
		ketv = new Gtk.Image[] { ketv1, ketv2, ketv3, ketv4, ketv5, ketv6, ketv7, ketv8, ketv9, ketv10, ketv11, ketv12, ketv13, ketv14, ketv15, ketv16, ketv17, ketv18, ketv19, ketv20, ketv21, ketv22, ketv23, ketv24, ketv25, ketv26, ketv27, ketv28, ketv29, ketv30 };
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
			if (zaidzia_uzverstom[0]==true)
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
		else { GUIkalade.Pixbuf = null; }
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
		else if (kurio == 2)
		{
			if (antras.atverstos == null)
			{
				antroatv1.Pixbuf = null;
				antroatv2.Pixbuf = null;
				antroatv3.Pixbuf = null;
			}
			if (antras.uzverstos[0] == null) { antrouzv1.Pixbuf = null; }
			if (antras.uzverstos[1] == null) { antrouzv2.Pixbuf = null; }
			if (antras.uzverstos[2] == null) { antrouzv3.Pixbuf = null; }
			for (int i = 0; i < 6; i++)
			{
				antr[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");

			}
			for (int i = antras.Ranka.Count; i < 15; i++)
			{
				antr[i].Pixbuf = null;
			}
		}
		else if (kurio == 3)
		{
			if (trecias.atverstos == null)
			{
				trecioatv1.Pixbuf = null;
				trecioatv2.Pixbuf = null;
				trecioatv3.Pixbuf = null;
			}
			if (trecias.uzverstos[0] == null) { treciouzv1.Pixbuf = null; }
			if (trecias.uzverstos[1] == null) { treciouzv2.Pixbuf = null; }
			if (trecias.uzverstos[2] == null) { treciouzv3.Pixbuf = null; }
			for (int i = 0; i < trecias.Ranka.Count; i++)
			{
				trec[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");

			}
			for (int i = trecias.Ranka.Count; i < 15; i++)
			{
				trec[i].Pixbuf = null;
			}
		}
		else if (kurio == 4)
		{
			if (ketvirtas.atverstos == null)
			{
				ketvirtoatv1.Pixbuf = null;
				ketvirtoatv2.Pixbuf = null;
				ketvirtoatv3.Pixbuf = null;
			}
			if (ketvirtas.uzverstos[0] == null) { ketvirtouzv1.Pixbuf = null; }
			if (ketvirtas.uzverstos[1] == null) { ketvirtouzv2.Pixbuf = null; }
			if (ketvirtas.uzverstos[2] == null) { ketvirtouzv3.Pixbuf = null; }
			for (int i = 0; i < ketvirtas.Ranka.Count; i++)
			{
				ketv[i].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");

			}
			for (int i = ketvirtas.Ranka.Count; i < 15; i++)
			{
				ketv[i].Pixbuf = null;
			}
		}


	}
	[GLib.ConnectBefore]
	protected void KeyPress(object sender, KeyPressEventArgs args)
	{
		//Console.WriteLine(args.Event.Key);
		if ((kieno_eile == 1)&&(kas_laimejo[kieno_eile-1]==false))
		{

			if (args.Event.Key == Gdk.Key.Right)
			{

				if ((kuri < pirmas.Ranka.Count - 1) || (zaidzia_uzverstom[kieno_eile-1] == true))
				{
					sulygina(1);
					kuri++;
					if (zaidzia_uzverstom[kieno_eile-1] == true)
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


				if ((kuri > 0) || (zaidzia_uzverstom[kieno_eile-1] == true))
				{
					sulygina(1);
					kuri--;
					if (zaidzia_uzverstom[kieno_eile-1] == true)
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
				
				if (zaidzia_uzverstom[kieno_eile-1] == true)
				{
					pirmas.paimti_uzversta(einama); //viduje tikrina ar turi rankoje kortu, jei taip, nieko nedaro
					zaidzia_uzverstom[kieno_eile-1] = false;
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
					zaidzia_uzverstom[kieno_eile-1] = true;
				}
				refresh(kieno_eile);
				if (pirmas.uzverstos.Count() == 0)
				{
					kas_laimejo[0] = true;
				}
				if (pries != po) { kuri = 1; kieno_eile++; AI();}

			}
		}

	}
	void AI()
	{
		
		if ((kieno_eile == 2)&& (kas_laimejo[kieno_eile - 1]==false))
		{
			bool padejo = false;
			if (zaidzia_uzverstom[kieno_eile-1] == true)
			{
				antras.paimti_uzversta(0);
				if ((antras.Ranka[0].verte >= ant_stalo.Zaidziamos.Last().verte)|| (antras.Ranka[0].verte == 10) || (antras.Ranka[0].verte == 2))
				{
					antras.Deti_viena_korta(antras.Ranka[0], ant_stalo, Kalade);
					padejo = true;

				}
			}
			else
			{
				for (int i = 0; i < antras.Ranka.Count; i++)
				{
					if (ant_stalo.Zaidziamos.Count == 0)
					{
						antras.Deti_viena_korta(antras.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}
					else if ((antras.Ranka[i].verte >= ant_stalo.Zaidziamos.Last().verte)||(antras.Ranka[i].verte==10)||(antras.Ranka[i].verte==2))
					{
						antras.Deti_viena_korta(antras.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}

				}
			}
			if ((ant_stalo.Zaidziamos.Count > 3)&&(padejo==false))
			{ 
				antras.Imti_3(ant_stalo); 
			}
			else if (padejo==false)
			{
				antras.imti_viska(ant_stalo);
			}
			antras.paimti_atverstas(Kalade);
			if ((antras.atverstos == null) && (antras.Ranka.Count == 0))
			{
				zaidzia_uzverstom[kieno_eile-1] = true;
			}
			refresh(2);
			kieno_eile = 3;
			if (antras.uzverstos.Count() == 0)
			{
				kas_laimejo[1]=true;
			}
			AI();
		} 
		else if ((kieno_eile == 3)&& (kas_laimejo[kieno_eile - 1]==false))
		{
			bool padejo = false;
			if (zaidzia_uzverstom[kieno_eile-1] == true)
			{
				trecias.paimti_uzversta(0);
				if ((trecias.Ranka[0].verte >= ant_stalo.Zaidziamos.Last().verte) || (trecias.Ranka[0].verte == 10) || (trecias.Ranka[0].verte == 2))
				{
					trecias.Deti_viena_korta(trecias.Ranka[0], ant_stalo, Kalade);
					padejo = true;

				}
			}
			else
			{
				for (int i = 0; i < trecias.Ranka.Count; i++)
				{
					if (ant_stalo.Zaidziamos.Count == 0)
					{
						trecias.Deti_viena_korta(trecias.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}
					else if ((trecias.Ranka[i].verte >= ant_stalo.Zaidziamos.Last().verte) || (trecias.Ranka[i].verte == 10) || (trecias.Ranka[i].verte == 2))
					{
						trecias.Deti_viena_korta(trecias.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}

				}
			}
			if ((ant_stalo.Zaidziamos.Count > 3) && (padejo == false))
			{
				trecias.Imti_3(ant_stalo);
			}
			else if (padejo == false)
			{
				trecias.imti_viska(ant_stalo);
			}
			trecias.paimti_atverstas(Kalade);
			if ((trecias.atverstos == null) && (trecias.Ranka.Count == 0))
			{
				zaidzia_uzverstom[kieno_eile-1] = true;
			}
			refresh(3);
			kieno_eile =4;
			if (trecias.uzverstos.Count() == 0)
			{
				kas_laimejo[2] = true;
			}
			AI();
		}
		else if ((kieno_eile == 4)&&(kas_laimejo[kieno_eile-1]==false))
		{
			bool padejo = false;
			if (zaidzia_uzverstom[kieno_eile-1] == true)
			{
				ketvirtas.paimti_uzversta(0);
				if ((ketvirtas.Ranka[0].verte >= ant_stalo.Zaidziamos.Last().verte) || (ketvirtas.Ranka[0].verte == 10) || (ketvirtas.Ranka[0].verte == 2))
				{
					ketvirtas.Deti_viena_korta(ketvirtas.Ranka[0], ant_stalo, Kalade);
					padejo = true;

				}
			}
			else
			{
				for (int i = 0; i < ketvirtas.Ranka.Count; i++)
				{
					if (ant_stalo.Zaidziamos.Count == 0)
					{
						ketvirtas.Deti_viena_korta(ketvirtas.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}
					else if ((ketvirtas.Ranka[i].verte >= ant_stalo.Zaidziamos.Last().verte) || (ketvirtas.Ranka[i].verte == 10) || (ketvirtas.Ranka[i].verte == 2))
					{
						ketvirtas.Deti_viena_korta(ketvirtas.Ranka[i], ant_stalo, Kalade);
						padejo = true;
						Garsas.PlaySound(new FileStream("korta.wav", FileMode.Open, FileAccess.Read, FileShare.Read), SoundFlags.SND_ASYNC);
						break;
					}

				}
			}
			if ((ant_stalo.Zaidziamos.Count > 3) && (padejo == false))
			{
				ketvirtas.Imti_3(ant_stalo);
			}
			else if (padejo == false)
			{
				ketvirtas.imti_viska(ant_stalo);
			}
			ketvirtas.paimti_atverstas(Kalade);
			if ((ketvirtas.atverstos == null) && (ketvirtas.Ranka.Count == 0))
			{
				zaidzia_uzverstom[kieno_eile-1] = true;
			}
			refresh(4);
			kieno_eile = 1;
			if (ketvirtas.uzverstos.Count() == 0)
			{
				kas_laimejo[3] = true;
			}
		}

	}

	protected void OnImti3Clicked(object sender, EventArgs e)
	{
		if (kieno_eile == 1)
		{
			if (pirmas.Imti_3(ant_stalo))
			{
				refresh(kieno_eile);
				kieno_eile++;
				AI();
			}
		}
	}

	protected void OnImtiViskaClicked(object sender, EventArgs e)
	{
		pirmas.Imti_3(ant_stalo);
		refresh(kieno_eile);

		if (kieno_eile == 1)
		{
			pirmas.imti_viska(ant_stalo);
			refresh(kieno_eile);
			kieno_eile++;
			AI();
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
