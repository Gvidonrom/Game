﻿using System.Windows;

namespace AdventureGame
{
    
    public partial class City_independence : Window
    {
        public City_independence()
        {
            InitializeComponent();
        }
        
        private void Use_item_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("К соажлению у вас ничего такого нет, что могло бы вам помочь", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Winer winer = new Winer();
            winer.Show();
            Close();
        }
    }
}
