/*
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

            if (false)//(!string.IsNullOrEmpty(Settings.SiteId))
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
*/

using TeslaX.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using TeslaRemote.Services;
using TeslaRemote.Views;

namespace TeslaRemote
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();

            /*
             if (false)//(!string.IsNullOrEmpty(Settings.SiteId))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
             */
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
