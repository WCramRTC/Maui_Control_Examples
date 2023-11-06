namespace Maui_Control_Examples
{
    public partial class MainPage : ContentPage
    {
        List<Player> names = new List<Player>();

        public MainPage()
        {
            InitializeComponent();
            Preload();
            lvItems.ItemsSource = names;
            pikNames.ItemsSource = names;
        } // MainPage()

        public void Preload()
        {
            names.AddRange(new Player[] { 
            new Player("Will", 40),
            new Player("Hannah", 25),
            new Player("Kristyn", 25),
            new Player("Dylan", 25),
            new Player("Josh", 40),
            });
        }

        private void btnClicked_Clicked(object sender, EventArgs e)
        {
            names.Add(new Player("Desmond", 24));

            lvItems.ItemsSource = null;
            lvItems.ItemsSource = names;
        }
    }
}