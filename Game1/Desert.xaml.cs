using System;
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

namespace AdventureGame
{
    /// <summary>
    /// Логика взаимодействия для Desert.xaml
    /// </summary>
    public partial class Desert : Window
    {
        private PlayerData playerData = new PlayerData();
        public Desert()
        {
            InitializeComponent();
        }

        private void To_town_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы пошли в сторону города, вы шли, шли, шли... и в итоге погибли от обезвоживания. Игра проиграна.", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void To_Oasis_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы пошли в сторону Оазиса, к счастью он был не сильно далеко и это оказался не мираж. Вы пришли туда и обнаружили там караван, который шел в Таинственный город и караванщик любезно согласился Вас взять с собой", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData.HasDecoration);
                city_transition.Show();
                Close();
            }
        }

        private void Water_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы добыли воду и дальше что? Будем считать, что добыв воду Вы пошли сторону города и с водой смогли туда дойти", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData.HasDecoration);
                city_transition.Show();
                Close();
            }
        }
    }
}
