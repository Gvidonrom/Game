﻿using System.Windows;


namespace AdventureGame
{
     public partial class Forest : Window
    {
        private PlayerData playerData = new PlayerData();
        public Forest()
        {
            InitializeComponent();
        }
                
        private void Hunting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы пойманы и съедены. Игра окончена!", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }

        private void Gather_wood_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы успешно собрали дрова! Развели костер и решили заночевать, позже на ваш костер вышел караван и после совместной ночевки, караванщик предложил Вам отправиться с ним в Таинственный город.", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            }
        }

        private void Nothing_toDo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ничего не делая, Вы погибли от истощения. Игра окончена.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }
    }
}
