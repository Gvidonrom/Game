using System.Windows;

namespace AdventureGame
{

    public partial class Desert : Window
    {
        private PlayerData playerData;
        public Desert(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
        }

        private void To_town_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы пошли в сторону города, вы шли, шли, шли... и в итоге погибли от обезвоживания.", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            Lose lose = new Lose();
            lose.Show();
            Close();
        }

        private void To_Oasis_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы пошли в сторону Оазиса, к счастью он был не сильно далеко и это оказался не мираж. Вы пришли туда и обнаружили там караван, который шел в Таинственный город и караванщик любезно согласился Вас взять с собой", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            }
        }

        private void Water_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы добыли воду и дальше что? Будем считать, что добыв воду Вы пошли сторону города и с водой смогли туда дойти", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData);
                city_transition.Show();
                Close();
            }
        }
    }
}
