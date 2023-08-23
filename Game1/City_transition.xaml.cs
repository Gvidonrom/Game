using System.Windows;


namespace AdventureGame
{
    
    public partial class City_transition : Window
    {
        private PlayerData playerData;
        

        public City_transition(PlayerData playerData)
        {
            
            InitializeComponent();
            this.playerData = playerData;
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
