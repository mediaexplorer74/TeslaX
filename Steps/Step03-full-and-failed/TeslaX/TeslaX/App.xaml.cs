using TeslaX.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeslaX
{
    public partial class App : Application
    {
        public App()
        {
            
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SyncfusionLicence.licenceKey);
            
            InitializeComponent();

            // old: MainPage = new MainPage();

            if (!string.IsNullOrEmpty(Settings.SiteId))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
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
