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
            money = 150000000;
            market = new Market(40000000, 4000000, 2600000, 5000000, 700);

        }
        
        private void StartGames(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            List<Joueur> listPlayer = new List<Joueur>();
            listPlayer.Add(new Joueur(namePlayer1.Text, money, market));
            listPlayer.Add(new Joueur(namePlayer2.Text, money, market));
            listPlayer.Add(new Joueur(namePlayer3.Text, money, market));
            listPlayer.Add(new Joueur(namePlayer4.Text, money, market));
            
            for (int i = 0; i < 10; i++)
            {
                int valueOfThisTurn = random.Next(-1, 3);
                
                market.EstimationSojuNormalSell.Add(listPlayer.Count* 90000 + i * 10000 +i*5000*valueOfThisTurn);
                MessageBox.Show(Convert.ToString(market.EstimationSojuNormalSell[i]));
            }
            ReportTurn page = new ReportTurn(listPlayer, market, 15);//15 is the number of turn to modificate after
            page.Show();
            this.Close();
        }
    }
}
