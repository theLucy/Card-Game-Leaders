using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
    int x, y;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
        vietoj konteineriu uzmeciau fixed grida, kad butu galima su pixeliais dirbt;
		Build ();
        //GetPointer(out x, out y);
        global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
        global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
       
        w5.Y = 100;
        
        label3.Text = "butono koordinates: " + w1.X.ToString() + " " + w1.Y.ToString();
        

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        
        MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,MessageType.Info,ButtonsType.Ok, "Nein image is resources neskaityt");
        md.Run ();
        md.Destroy();
        //image1.Pixbuf = new Gdk.Pixbuf("C://Users//Rasa//Desktop//Resources//22.bmp");   
        
        //image2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("cardgame.12.bmp");//nein niekaip uzdet image is resurso
        global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));

        GetPointer(out x, out y); //kursoriaus pozicija
        
        w1.X = 400;
        w1.Y = 400;
        label3.Text = "butono location: " + w1.X.ToString() + " " + w1.Y.ToString();
        
    }
}
