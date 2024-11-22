using Xamarin.Forms;

namespace app_cv
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // La página principal puede ser MainPage.xaml o cualquier otra
            MainPage = new MainPage();
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
