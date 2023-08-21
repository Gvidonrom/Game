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
            MessageBox.Show("Вы выглядите слишком подозрительно - пропыленный путешественник, в поношенной одежде... Вам никтоничего не сказал, Вы потерпели неудачу.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Buy_information_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы решили купить информацию, но что у Вас есть?", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

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
        }
    }
}
