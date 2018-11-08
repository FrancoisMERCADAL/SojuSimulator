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
    /// Logique d'interaction pour DecisionPlayerPage.xaml
    /// </summary>
    public partial class DecisionPlayerPage : Window
    {
        int turn;
        int numberOfPlayer;
        List<Joueur> listPlayer;
        Market market;
        int numberOfTurn;
        public DecisionPlayerPage(int turn, int numberOfPlayer, List<Joueur> listPlayer, Market market,int numberOfTurn)
        {
            this.turn = turn;
            this.numberOfPlayer = numberOfPlayer;
            this.listPlayer = listPlayer;
            this.market = market;
            nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);
            nombreMachin.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count);
            this.numberOfTurn = numberOfTurn;
            InitializeComponent();
        }

        private void AjouterSalarie_Click(object sender, RoutedEventArgs e)
        {
            if(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count*5> listPlayer[numberOfPlayer - 1].NumberOfSalary)
            {
                listPlayer[numberOfPlayer - 1].HireNewSalary();
                nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);
            }
        }

        private void AjouterMachine_Click(object sender, RoutedEventArgs e)
        {
            listPlayer[numberOfPlayer - 1].BuyANewMachinClassic();
            nombreMachin.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count);
        }

        private void DeleteSalarie_Click(object sender, RoutedEventArgs e)
        {
            listPlayer[numberOfPlayer - 1].FireSalary();
            nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            if(numberOfPlayer==listPlayer.Count)
            {
                MainPage page = new MainPage(listPlayer, market, numberOfTurn, turn);
                page.Show();
                this.Close();
            }
            else
            {
                DecisionPlayerPage pageBis = new DecisionPlayerPage(turn, numberOfPlayer + 1, listPlayer, market, numberOfTurn);
                pageBis.Show();
                this.Close();
            }
        }
    }
}
