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
using System.Windows.Shapes;

namespace stockExample
{
    /// <summary>
    /// Interaction logic for DashBoardWindow.xaml
    /// </summary>
    public partial class DashBoardWindow : Window
    {
        public DashBoardWindow()
        {
            InitializeComponent();
        }
        private void enterIntegrationOrderWindow(object sender, RoutedEventArgs e)
        {
            IntegrationOrderWindow integrationOrderWindow = new IntegrationOrderWindow();
            integrationOrderWindow.Show();
            this.Close();
        }
        private void enterDepositAndWithdrawalWindow(object sender, RoutedEventArgs e)
        {
            stockExample.DashBoardWindow dashBoardWindow = new stockExample.DashBoardWindow();
            dashBoardWindow.Show();
            this.Close();
        }
        private void enterTransactionHistoryWindow(object sender, RoutedEventArgs e)
        {
            stockExample.DashBoardWindow dashBoardWindow = new stockExample.DashBoardWindow();
            dashBoardWindow.Show();
            this.Close();
        }
        private void enterProfitAndLossWindow(object sender, RoutedEventArgs e)
        {
            stockExample.DashBoardWindow dashBoardWindow = new stockExample.DashBoardWindow();
            dashBoardWindow.Show();
            this.Close();
        }
        
    }
}
