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

namespace SojuSimulator3000
{
    /// <summary>
    /// Logique d'interaction pour ReportTurn.xaml
    /// </summary>
    public partial class ReportTurn : Window
    {
        List<Joueur> listPlayer;
        Market market;
        int numberOfTurn;
        public ReportTurn(List<Joueur> listPlayer, Market market, int numberOfTurn)
        {
            InitializeComponent();
            this.listPlayer = listPlayer;
            this.market = market;
            this.numberOfTurn = numberOfTurn;
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            MainPage page = new MainPage(listPlayer, market, numberOfTurn);
            page.Show();
            this.Close();
        }
    }
}
