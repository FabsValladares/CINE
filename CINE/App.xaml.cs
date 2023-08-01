using Xamarin.Forms;

namespace CINE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DatosPersonales();
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
