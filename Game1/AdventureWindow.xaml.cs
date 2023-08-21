using System.Windows;

namespace AdventureGame
{
    public partial class AdventureWindow : Window
    {
        private PlayerData playerData = new PlayerData();

        public AdventureWindow()
        {
            InitializeComponent();
        }

        private void ForestButton_Click(object sender, RoutedEventArgs e)
        {
            Forest forest = new Forest();
            forest.Show();
            Close(); // Закрываем текущее окно (MainWindow)
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            Store store = new Store(playerData);
            store.Show();
            Close();
        }

        private void CastleButton_Click(object sender, RoutedEventArgs e)
        {
            Castle castle = new Castle();
            castle.Show();
            Close();
        }

        private void DesertButton_Click(object sender, RoutedEventArgs e)
        {
            Desert desert = new Desert();
            desert.Show();
            Close();
        }

        
    }

    
}
