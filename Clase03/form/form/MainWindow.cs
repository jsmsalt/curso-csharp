using System;
using Gtk;
using Unidades;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        float metros = float.Parse(txtBoxMetros1.Buffer.Text);
        Metro m = new Metro(metros);
        float centimetros = ((Centimetro)m).getValor();
        txtBoxCentimetros1.Buffer.Text =  centimetros.ToString();
    }

    protected void OnBtn2Clicked(object sender, EventArgs e)
    {
        float centimetros = float.Parse(txtBoxCentimetros2.Buffer.Text);
        Centimetro c = new Centimetro(centimetros);
        float metros = ((Metro)c).getValor();
        txtBoxMetros2.Buffer.Text = metros.ToString();
    }
}
