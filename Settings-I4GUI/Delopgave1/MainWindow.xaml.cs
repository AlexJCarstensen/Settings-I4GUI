using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Delopgave1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRollBack_OnClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void BtnReset_OnClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void BtnPath_OnClick(object sender, RoutedEventArgs e)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            MessageBox.Show(config.FilePath, "Local user config path:");
            
        }
    }
}
