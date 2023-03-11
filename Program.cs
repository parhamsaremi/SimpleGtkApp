using System;
using Gtk;

namespace sample_gtk_app
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            Window myWin = new Window("My first GTK# Application! ");
            myWin.Resize(200,200);

            Label myLabel = new Label();
            myLabel.Text = "Hello World!!!!";

            myWin.Add(myLabel);
            myWin.ShowAll();

            Application.Run();
        }
    }
}
