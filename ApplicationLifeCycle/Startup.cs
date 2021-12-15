using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ApplicationLifeCycle
{
    public class Startup
    {       
        [STAThread]
        static void Main()
        { 

            //===========First Approach===============
            //Create application
            Application app = new Application();
            //Create a main window
            login win = new login();
            //Lauch the application and show the window
            app.Run(win);

            //===========Second Approach=============

            //// Create the application.
            //Application app = new Application();
            //// Create, assign, and show the main window.
            //Window1 win = new Window1();
            //app.MainWindow = win;
            //win.Show();
            //// Keep the application alive.
            //app.Run();
        }
    }
}
