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
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        int money;
        Market market;
        public HomePage()
        {
            InitializeComponent();
            for (int i = 2; i < 7; i++)
                NumberOfPlayer.Items.Add(Convert.ToString(i));
            money = 1000000;
            market = new Market(100000, 10000, 10000, 5000, 1000, 0.4f, 0.6f);
            for (int i = 0; i < 15; i++)
            {
                market.EstimationSojuNormalSell.Add(10000 + i * 5000);
                market.EstimationSojuPremiumSell.Add(2000 + i * 2500);
            }
        }
        private void NumberOfPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Convert.ToInt32(NumberOfPlayer.SelectedValue)>=3)
            {
                Player3.Visibility = Visibility.Visible;
                if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 4)
                {
                    Player4.Visibility = Visibility.Visible;
                    if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 5)
                    {
                        Player5.Visibility = Visibility.Visible;
                        if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 6)
                        {
                            Player6.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            Player6.Visibility = Visibility.Collapsed;
                        }
                    }
                    else
                    {
                        Player5.Visibility = Visibility.Collapsed;
                        Player6.Visibility = Visibility.Collapsed;
                    }
                }
                else
                {
                    Player4.Visibility = Visibility.Collapsed;
                    Player5.Visibility = Visibility.Collapsed;
                    Player6.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                Player3.Visibility = Visibility.Collapsed;
                Player4.Visibility = Visibility.Collapsed;
                Player5.Visibility = Visibility.Collapsed;
                Player6.Visibility = Visibility.Collapsed;
            }
        }


        private void StartGames(object sender, RoutedEventArgs e)
        {
            List<Joueur> listPlayer = new List<Joueur>();
            listPlayer.Add(new Joueur(namePlayer1.Text, money, market));
            listPlayer.Add(new Joueur(namePlayer2.Text, money, market));
            if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 3)
            {
                listPlayer.Add(new Joueur(namePlayer3.Text, money, market));
                if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 4)
                {
                    listPlayer.Add(new Joueur(namePlayer4.Text, money, market));
                    if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 5)
                    {
                        listPlayer.Add(new Joueur(namePlayer5.Text, money, market));
                        if (Convert.ToInt32(NumberOfPlayer.SelectedValue) >= 3)
                        {
                            listPlayer.Add(new Joueur(namePlayer6.Text, money, market));
                        }
                    }
                }
            }
            ReportTurn page = new ReportTurn(listPlayer, market, 15);//15 is the number of turn to modificate after
            page.Show();
            this.Close();
        }
    }
}
