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
    /// Logique d'interaction pour MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        List<Joueur> listPlayer;
        string textRanking;
        string textNextTurn;
        Market market;
        int turn;
        int numberOfTurn;
        public MainPage(List<Joueur> listPlayer, Market market, int numberOfTurn)
        {
            this.listPlayer = listPlayer;
            InitializeComponent();
            this.market = market;
            this.numberOfTurn = numberOfTurn;
            this.turn = 1;
            TexteClassement();
            TexteInformationTurn();
        }
        public MainPage(List<Joueur> listPlayer, Market market, int numberOfTurn, int turn)
        {
            this.listPlayer = listPlayer;
            InitializeComponent();
            this.market = market;
            this.numberOfTurn = numberOfTurn;
            this.turn = turn;
            TexteClassement();
            TexteInformationTurn();
        }
        public void TexteClassement()
        {
            listPlayer.Sort();
            textRanking = "The actual ranking is : \n";
            for(int i = 0;i<listPlayer.Count;i++)
            {
                textRanking += (i+1) + ") " + listPlayer[i].Name + " with " + listPlayer[i].Money + "€.\n";
            }
            labelRanking.Content = textRanking;
        }
        public void TexteInformationTurn()
        {
            textNextTurn = "Here the estimation of this year : \n";
            //textNextTurn += "Sell of Normal Soju :" + market.EstimationSojuNormalSell[turn-1];
            //textNextTurn += "\nSell of Premium Soju : " + market.EstimationSojuPremiumSell[turn-1];
            informationTurn.Content = textNextTurn;
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            DecisionPlayerPage page = new DecisionPlayerPage(turn, 1, listPlayer, market, numberOfTurn);
            page.Show();
            this.Close();
        }
    }
}
