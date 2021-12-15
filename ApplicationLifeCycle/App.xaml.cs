using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ApplicationLifeCycle
{

    //public partial class App : Application
    //{
    //    [STAThread()]
    //    public static void Main()
    //    {
    //        TestApplication.App app = new TestApplication.App();
    //        app.InitializeComponent();
    //        app.Run();
    //    }
    //    public void InitializeComponent()
    //    {
    //        this.StartupUri = new Uri("Window1.xaml", System.UriKind.Relative);
    //    }
    //} 
    public partial class App : Application
    {

        public App() { }
        private bool unsavedData = false;
        public bool UnsavedData
        {
            get { return unsavedData; }
            set { unsavedData = value; }
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            UnsavedData = true;
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled " + e.Exception.GetType().ToString() +
" exception was caught and ignored.");
            e.Handled = true;

        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }

        private void Application_Activated(object sender, EventArgs e)
        {

        }

        private void Application_Deactivated(object sender, EventArgs e)
        {

        }      

        private void Application_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            if (UnsavedData)
            {
                e.Cancel = true;
                MessageBox.Show(
                "The application attempted to be closed as a result of " +
                e.ReasonSessionEnding.ToString() +
                ". This is not allowed, as you have unsaved data.");
            }

        }
    }
}
