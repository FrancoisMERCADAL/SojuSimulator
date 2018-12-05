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
    /// Logique d'interaction pour EndGame.xaml
    /// </summary>
    public partial class EndGame : Window
    {
        Market market;
        List<Joueur> listPlayer;
        string textRanking;
        public EndGame(List<Joueur> listPlayer, Market market)
        {
            
            InitializeComponent();
            this.listPlayer = listPlayer;
            this.market = market;
            TexteClassement();
        }
        public void TexteClassement()
        {
            listPlayer.Sort();
            textRanking = "The ranking is : \n";
            for (int i = 0; i < listPlayer.Count; i++)
            {
                textRanking += (i + 1) + ") " + listPlayer[i].Name + " with " + listPlayer[i].Money + "€.\n";
            }
            labelRanking.Content = textRanking;
        }
        private void Finish(object sender, RoutedEventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Close();
        }
    }
}
