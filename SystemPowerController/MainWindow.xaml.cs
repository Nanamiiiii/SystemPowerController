using System;
using System.Collections.Generic;
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

namespace SystemPowerController
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_mOff_Click(object sender, RoutedEventArgs e)
        {
            MainSystem.MonitorPowerOff();
        }

        private void btn_shutdown_Click(object sender, RoutedEventArgs e)
        {
            MainSystem.SystemShutdown();
        }

        private void btn_Reboot_Click(object sender, RoutedEventArgs e)
        {
            MainSystem.SystemReboot();
        }

        private void btn_Signout_Click(object sender, RoutedEventArgs e)
        {
            MainSystem.UserSigningOut();
        }

        private void btn_Sleep_Click(object sender, RoutedEventArgs e)
        {
            MainSystem.SystemSleep();
        }
    }
}
