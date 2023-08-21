using System.Windows;

namespace AdventureGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            AdventureWindow adventureWindow = new AdventureWindow();
            adventureWindow.Show();
            Close(); // Закрываем текущее окно (MainWindow)
        }
    }
}
