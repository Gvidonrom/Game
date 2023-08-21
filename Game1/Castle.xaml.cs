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
    /// Логика взаимодействия для Castle.xaml
    /// </summary>
    public partial class Castle : Window
    {
        private PlayerData playerData = new PlayerData();
        public Castle()
        {
            InitializeComponent();
        }

        private void Get_in_a_room_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы пойманы и убиты. Игра окончена!", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Talk_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Пообщавшись с вельможей, он вывел Вас за территорию замка в город", "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                City_transition city_transition = new City_transition(playerData.HasDecoration);
                city_transition.Show();
                Close();
            }
        }

        private void Nothing_toDo_Click_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ничего не делая, Вы погибли от истощения. Игра окончена.", "Конец игры", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
