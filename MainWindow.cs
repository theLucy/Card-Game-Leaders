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
	int kuri = 1;
    cardgame.Kalade Kalade = new cardgame.Kalade();
    cardgame.Zaidejas pirmas = new cardgame.Zaidejas();
    cardgame.Zaidejas antras = new cardgame.Zaidejas();
    cardgame.Zaidejas trecias = new cardgame.Zaidejas();
    cardgame.Zaidejas ketvirtas = new cardgame.Zaidejas();
    cardgame.Zaidejas penktas = new cardgame.Zaidejas();
    cardgame.Zaidejas[] visi = new cardgame.Zaidejas[5];
    cardgame.Stalas ant_stalo = new cardgame.Stalas();

	//Gtk.Fixed.FixedChild ws = ((Gtk.Fixed.FixedChild)(fixed1[image24]));
	Gtk.Image[] imgs = new Gtk.Image[56];
	Gtk.Fixed.FixedChild[] imgsch = new Gtk.Fixed.FixedChild[56];

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
        //vietoj konteineriu uzmeciau fixed grida, kad butu galima su pixeliais dirbt;
		Build ();
		priskiria_img();
		w1 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));

        
        label3.Text = "butono koordinates: " + w1.X.ToString() + " " + w1.Y.ToString();


        visi[0] = pirmas;
        visi[1] = antras;
        visi[2] = trecias;
        visi[3] = ketvirtas;
        visi[4] = penktas;

        ant_stalo.dalinimas(5, visi, Kalade);

	}
	void priskiria_img()
	{
		
		imgs[1] = image1;
		imgs[2] = image2;
		imgs[3] = image3;
		imgs[4] = image4;
		imgs[5] = image5;
		imgs[6] = image6;
		imgs[7] = image7;
		imgs[8] = image8;
		imgs[9] = image9;
		imgs[10] = image10;
		imgs[11] = image11;
		imgs[12] = image12;
		imgs[13] = image13;
		imgs[14] = image14;
		imgs[15] = image15;
		imgs[16] = image16;
		imgs[17] = image17;
		imgs[18] = image18;
		imgs[19] = image19;
		imgs[20] = image20;
		imgs[21] = image21;
		imgs[22] = image22;
		imgs[23] = image23;
		imgs[24] = image24;
		imgs[25] = image25;
		imgs[26] = image26;
		imgs[27] = image27;
		imgs[28] = image28;
		imgs[29] = image29;
		imgs[30] = image30;
		imgs[31] = image31;
		imgs[32] = image32;
		imgs[33] = image33;
		imgs[34] = image34;
		imgs[35] = image35;
		imgs[36] = image36;
		imgs[37] = image37;
		imgs[38] = image38;
		imgs[39] = image39;
		imgs[40] = image40;
		imgs[41] = image41;
		imgs[42] = image42;
		imgs[43] = image43;
		imgs[44] = image44;
		imgs[45] = image45;
		imgs[46] = image46;
		imgs[47] = image47;
		imgs[48] = image48;
		imgs[49] = image49;
		imgs[50] = image50;
		imgs[51] = image51;
		imgs[52] = image52;
		imgs[53] = image53;
		imgs[54] = image54;
		imgs[55] = image55;

		imgsch[1] = ((Gtk.Fixed.FixedChild)(fixed1[image1]));
		imgsch[2] = ((Gtk.Fixed.FixedChild)(fixed1[image2]));
		imgsch[3] = ((Gtk.Fixed.FixedChild)(fixed1[image3]));
		imgsch[4] = ((Gtk.Fixed.FixedChild)(fixed1[image4]));
		imgsch[5] = ((Gtk.Fixed.FixedChild)(fixed1[image5]));
		imgsch[6] = ((Gtk.Fixed.FixedChild)(fixed1[image6]));
		imgsch[7] = ((Gtk.Fixed.FixedChild)(fixed1[image7]));
		imgsch[8] = ((Gtk.Fixed.FixedChild)(fixed1[image8]));
		imgsch[9] = ((Gtk.Fixed.FixedChild)(fixed1[image9]));
		imgsch[10] = ((Gtk.Fixed.FixedChild)(fixed1[image10]));
		imgsch[11] = ((Gtk.Fixed.FixedChild)(fixed1[image11]));
		imgsch[12] = ((Gtk.Fixed.FixedChild)(fixed1[image12]));
		imgsch[13] = ((Gtk.Fixed.FixedChild)(fixed1[image13]));
		imgsch[14] = ((Gtk.Fixed.FixedChild)(fixed1[image14]));
		imgsch[15] = ((Gtk.Fixed.FixedChild)(fixed1[image15]));
		imgsch[16] = ((Gtk.Fixed.FixedChild)(fixed1[image16]));
		imgsch[17] = ((Gtk.Fixed.FixedChild)(fixed1[image17]));
		imgsch[18] = ((Gtk.Fixed.FixedChild)(fixed1[image18]));
		imgsch[19] = ((Gtk.Fixed.FixedChild)(fixed1[image19]));
		imgsch[20] = ((Gtk.Fixed.FixedChild)(fixed1[image20]));
		imgsch[21] = ((Gtk.Fixed.FixedChild)(fixed1[image21]));
		imgsch[22] = ((Gtk.Fixed.FixedChild)(fixed1[image22]));
		imgsch[23] = ((Gtk.Fixed.FixedChild)(fixed1[image23]));
		imgsch[24] = ((Gtk.Fixed.FixedChild)(fixed1[image24]));
		imgsch[25] = ((Gtk.Fixed.FixedChild)(fixed1[image25]));
		imgsch[26] = ((Gtk.Fixed.FixedChild)(fixed1[image26]));
		imgsch[27] = ((Gtk.Fixed.FixedChild)(fixed1[image27]));
		imgsch[28] = ((Gtk.Fixed.FixedChild)(fixed1[image28]));
		imgsch[29] = ((Gtk.Fixed.FixedChild)(fixed1[image29]));
		imgsch[30] = ((Gtk.Fixed.FixedChild)(fixed1[image30]));
		imgsch[31] = ((Gtk.Fixed.FixedChild)(fixed1[image31]));
		imgsch[32] = ((Gtk.Fixed.FixedChild)(fixed1[image32]));
		imgsch[33] = ((Gtk.Fixed.FixedChild)(fixed1[image33]));
		imgsch[34] = ((Gtk.Fixed.FixedChild)(fixed1[image34]));
		imgsch[35] = ((Gtk.Fixed.FixedChild)(fixed1[image35]));
		imgsch[36] = ((Gtk.Fixed.FixedChild)(fixed1[image36]));
		imgsch[37] = ((Gtk.Fixed.FixedChild)(fixed1[image37]));
		imgsch[38] = ((Gtk.Fixed.FixedChild)(fixed1[image38]));
		imgsch[39] = ((Gtk.Fixed.FixedChild)(fixed1[image39]));
		imgsch[40] = ((Gtk.Fixed.FixedChild)(fixed1[image40]));
		imgsch[41] = ((Gtk.Fixed.FixedChild)(fixed1[image41]));
		imgsch[42] = ((Gtk.Fixed.FixedChild)(fixed1[image42]));
		imgsch[43] = ((Gtk.Fixed.FixedChild)(fixed1[image43]));
		imgsch[44] = ((Gtk.Fixed.FixedChild)(fixed1[image44]));
		imgsch[45] = ((Gtk.Fixed.FixedChild)(fixed1[image45]));
		imgsch[46] = ((Gtk.Fixed.FixedChild)(fixed1[image46]));
		imgsch[47] = ((Gtk.Fixed.FixedChild)(fixed1[image47]));
		imgsch[48] = ((Gtk.Fixed.FixedChild)(fixed1[image48]));
		imgsch[49] = ((Gtk.Fixed.FixedChild)(fixed1[image49]));
		imgsch[50] = ((Gtk.Fixed.FixedChild)(fixed1[image50]));
		imgsch[51] =  ((Gtk.Fixed.FixedChild)(fixed1[image51]));
		imgsch[52] =  ((Gtk.Fixed.FixedChild)(fixed1[image52]));
		imgsch[53] =  ((Gtk.Fixed.FixedChild)(fixed1[image53]));
		imgsch[54] =  ((Gtk.Fixed.FixedChild)(fixed1[image54]));
		imgsch[55] =  ((Gtk.Fixed.FixedChild)(fixed1[image55]));
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

	protected void OnButton2Clicked(object sender, EventArgs e)
	{
		pirmas_dalinimas();
	}

	void pirmas_dalinimas()
	{

		//REIKIA SURASYTI I CIKLUS IR SU KINTAMAISIAIS O NE TAIP GAIDISKAI KAIP YRA DBR SI FUNKCIJA, CIA TIK PVZ

		imgs[1].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[1].X = 200;
		imgsch[1].Y = 300;
		imgs[2].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[2].X = 250;
		imgsch[2].Y = 300;
		imgs[3].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[3].X = 300;
		imgsch[3].Y = 300;

		imgs[4].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[4].X = 550;
		imgsch[4].Y = 130;
		imgs[5].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[5].X = 550;
		imgsch[5].Y = 180;
		imgs[6].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[6].X = 550;
		imgsch[6].Y = 230;

		imgs[7].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[7].X = 200;
		imgsch[7].Y = 125;
		imgs[8].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[8].X = 250;
		imgsch[8].Y = 125;
		imgs[9].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[9].X = 300;
		imgsch[9].Y = 125;

		imgs[10].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[10].X = 91;
		imgsch[10].Y = 114;
		imgs[11].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[11].X = 91;
		imgsch[11].Y = 164;
		imgs[12].Pixbuf = Gdk.Pixbuf.LoadFromResource("cardgame.Resources.nugara.png");
		imgsch[12].X = 91;
		imgsch[12].Y = 214;

		imgs[13].Pixbuf = pirmas.Ranka[0].pav.Pixbuf;
		imgsch[13].X = 200;
		imgsch[13].Y = 320;
		imgs[14].Pixbuf = pirmas.Ranka[1].pav.Pixbuf;
		imgsch[14].X = 250;
		imgsch[14].Y = 320;
		imgs[15].Pixbuf = pirmas.Ranka[2].pav.Pixbuf;
		imgsch[15].X = 300;
		imgsch[15].Y = 320;
	}
}
