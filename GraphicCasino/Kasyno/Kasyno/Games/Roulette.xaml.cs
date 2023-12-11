﻿using Kasyno.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Kasyno.Games
{
    /// <summary>
    /// Logika interakcji dla klasy Roulette.xaml
    /// </summary>
    public partial class Roulette : Window
    {
        private Random random = new Random();
        private Account account = new Account();
        private int rand;

        public Roulette()
        {
            InitializeComponent();
            accBalance.Text = "Balans: "+account.getBalance();
        }
        private void Won(int rouletteNumber)
        {
            if (rouletteNumber == Int32.Parse(number.Text))
            {
                account.addBalance(double.Parse(bet.Text, CultureInfo.InvariantCulture.NumberFormat) * 4);
                rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\money.mp4");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            account.removeBalance(double.Parse(bet.Text, CultureInfo.InvariantCulture.NumberFormat));
            accBalance.Text = "Balans: " + account.getBalance();
            rand = random.Next()%6;
            switch(rand)
            {
                case 0:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette0.mp4");
                    Thread.Sleep(8000);
                    Won(0);
                    break;
                case 1:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette7.mp4");
                    Thread.Sleep(8000);
                    Won(7);
                    break;
                case 2:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette11.mp4");
                    Thread.Sleep(8000);
                    Won(11);
                    break;
                case 3:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette17.mp4");
                    Thread.Sleep(8000);
                    Won(17);
                    break;
                case 4:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette23.mp4");
                    Thread.Sleep(8000);
                    Won(23);
                    break;
                case 5:
                    rouletteAnimation.Source = new Uri("C:\\Users\\user\\Desktop\\Kasyno\\Kasyno\\bin\\Debug\\net8.0-windows\\roulette32.mp4");
                    Thread.Sleep(8000);
                    Won(32);
                    break;
            }
        }
    }
}
