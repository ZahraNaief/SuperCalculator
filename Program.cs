using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace Assignment_3
{
    internal static class Program
    {
        
        ///  The main entry point for the application.
       
        static void Main()
        {        
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        
    }
}