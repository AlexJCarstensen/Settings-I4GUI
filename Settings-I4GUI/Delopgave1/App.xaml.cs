using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Delopgave1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Delopgave1.Properties.Settings.Default.Save();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (Delopgave1.Properties.Settings.Default.CallUpgrade)
            {
                Delopgave1.Properties.Settings.Default.Upgrade();
                Delopgave1.Properties.Settings.Default.CallUpgrade = false;
            }
        }
    }
}
