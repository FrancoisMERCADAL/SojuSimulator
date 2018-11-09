﻿using System;
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
            InitializeComponent();
            this.turn = turn;
            this.numberOfPlayer = numberOfPlayer;
            this.listPlayer = listPlayer;
            this.market = market;
            string test = listPlayer[numberOfPlayer - 1].NumberOfSalary.ToString();
            nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);//Show the actual number of salary you have
            nombreMachin.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count);//Show the actual number of machines you have
            this.numberOfTurn = numberOfTurn;
            priceHireWorkers.Content = priceHireWorkers.Content + " " + market.HireWorker;//Permit to show to the player the price of the market
            priceIngNormalSoju.Content = priceIngNormalSoju.Content + " " + market.PriceIngredientsSojuNormal;
            priceIngPremiumSoju.Content = priceIngPremiumSoju.Content + " " + market.PriceIngredientsSojuPremium;
            priceMachines.Content = priceMachines.Content + " " + market.ValueMachin;
            AfficherMoney();
        }
        /// <summary>
        /// Print the amount of money of the player who is playing
        /// </summary>
        private void AfficherMoney()
        {
            money.Content = "Money : " + listPlayer[numberOfPlayer - 1].Money;
        }
        /// <summary>
        /// Permit to add a salary when you click on the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterSalarie_Click(object sender, RoutedEventArgs e)
        {
            if(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count*5> listPlayer[numberOfPlayer - 1].NumberOfSalary)
            {
                listPlayer[numberOfPlayer - 1].HireNewSalary();
                nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);
            }
            AfficherMoney();
        }
        /// <summary>
        /// Permit to add a machin when you click on the button associate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterMachine_Click(object sender, RoutedEventArgs e)
        {
            listPlayer[numberOfPlayer - 1].BuyANewMachinClassic();
            nombreMachin.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfMachin.Count);
            AfficherMoney();
        }
        /// <summary>
        /// Permit to fire a salary when you click on the button associate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSalarie_Click(object sender, RoutedEventArgs e)
        {
            listPlayer[numberOfPlayer - 1].FireSalary();
            nombreSalarie.Text = Convert.ToString(listPlayer[numberOfPlayer - 1].NumberOfSalary);
            AfficherMoney();
        }
        /// <summary>
        /// Function that is called to finish your turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next(object sender, RoutedEventArgs e)
        {
            listPlayer[numberOfPlayer - 1].ProductSoju(EssayerConvertirInt(productNormalSoju.Text), EssayerConvertirInt(productionPremiumSoju.Text));//Save in your class the production that you decided to of normal...  
            listPlayer[numberOfPlayer - 1].SpendMarketing = EssayerConvertirInt(marketingSell.Text);//And premium soju
            if (numberOfPlayer==listPlayer.Count)//Check if everyone play
            {//if yes 
                MainPage page = new MainPage(listPlayer, market, numberOfTurn, turn);//Return to the mainPage to know the ranking
                page.Show();
                this.Close();
            }
            else
            {//else call the same page but for the next player
                DecisionPlayerPage pageBis = new DecisionPlayerPage(turn, numberOfPlayer + 1, listPlayer, market, numberOfTurn);
                pageBis.Show();
                this.Close();
            }
        }
        /// <summary>
        /// Class that it's called when everyone finished to calculate how many bottle of soju everyone sell
        /// </summary>
        private void CalculateIncomeOfEachPlayerNormalSoju()
        {
            Random rnd = new Random();
            int luckyCompany = rnd.Next(1, numberOfPlayer);

            for(int i=0;i<numberOfPlayer;i++)
            {
                listPlayer[i].ProportionSellOfThisTurnNormalSoju = 0;
            }
            listPlayer[luckyCompany].ProportionSellOfThisTurnNormalSoju = 0.05f;//5% of the sell is given to a company randomly just to create a part of luck
            listPlayer.Sort(Joueur.TriSellNormalSoju);
            //To continue, we need to find an algorithm to divide the sell of normal soju and premium soju


        }
        /// <summary>
        /// Method to check if the string that you try to convert to an int is actually an int
        /// </summary>
        /// <param name="aConvertir"></param>
        /// <returns></returns>
        private int EssayerConvertirInt(string aConvertir)
        {
            int aRetourner;
            try
            {
                aRetourner = Convert.ToInt32(aConvertir);
            }
            catch//if not we return 0
            {
                aRetourner = 0;
            }
            return aRetourner;
        }
    }
}
