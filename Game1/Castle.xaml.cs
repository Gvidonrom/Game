using System.Windows;

namespace AdventureGame
{
    
    public partial class Castle : Window
    {
        private PlayerData playerData;
        public Castle(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
        }

        private void Get_in_a_room_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы пойманы и убиты. Игра окончена!", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }

        private void Talk_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Пообщавшись с вельможей, он вывел Вас за территорию замка в город", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            }
        }

        private void Nothing_toDo_Click_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ничего не делая, Вы погибли от истощения. Игра окончена.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }
    }
}
