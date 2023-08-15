namespace TwoPaneApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.TwoPane_Vista();
        }
    }
}