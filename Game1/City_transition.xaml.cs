using System.Windows;


namespace AdventureGame
{
    
    public partial class City_transition : Window
    {
        private PlayerData playerData = new PlayerData();
        private bool hasDecoration;

        public City_transition(bool hasDecoration)
        {
            InitializeComponent();
            InitializeComponent();
            this.hasDecoration = hasDecoration;
        }
                
        private void Ask_for_help_Click(object sender, RoutedEventArgs e)
        {
            
            City city = new City(playerData);
            city.Show();
            Close();
        }
                
        private void Independent_search_Click(object sender, RoutedEventArgs e)
        {
            City_independence city = new City_independence();
            city.Show();
            Close();
        }
    }
}
