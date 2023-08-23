using System.Windows;

namespace AdventureGame
{
    
    public partial class City : Window
    {
        private PlayerData playerData;

        public City(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
        }

        private void Ask_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы выглядите слишком подозрительно - пропыленный путешественник, в очень потрепанной одежде... Вам никто ничего не сказал, Вы потерпели неудачу.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Buy_information_Click(object sender, RoutedEventArgs e)
        {
            
            if (playerData.HasDecoration)
            {
                MessageBox.Show("У вас есть украшение. Житель города дает вам информацию.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("У вас нет украшения. Житель города отказывается давать информацию.", "Информация", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        private void Atack_civilian_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это оказалась плохая идея... Житель оказался не промах, он Вас победил и сдал страже. Вас казнили.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
            AdventureWindow startWindow = new AdventureWindow();
            startWindow.Show();
            Close();
        }
    }
}
