

namespace Lands
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using Views;

    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new LoginPage());
        }
        #endregion


        #region Mehods
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #endregion
    }
}
