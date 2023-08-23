using System.Windows;

namespace AdventureGame
{
    public partial class Store : Window
    {
        private PlayerData playerData;

        public Store(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
        }
                
        private void Buy_jewelry_Click(object sender, RoutedEventArgs e)
        {
            playerData.HasDecoration = true;
            MessageBoxResult result = MessageBox.Show("Вы купили красивое старое украшение, что с ним делать, пока неизвестно, положим его в карман и продолжим путешествие", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            
          
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            
        }

        private void Buy_map_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы купили страую древнюю карту с частью какой-то территории в неизвестной части планеты. Продолжим путешествие", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            }
        }
                
        private void Nothing_toDo_Clic_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ничего не делая, Вы погибли от истощения. Игра окончена.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }

    }
}
