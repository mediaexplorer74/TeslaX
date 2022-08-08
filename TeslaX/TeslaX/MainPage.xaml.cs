using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;
using static TeslaX.MainPage;
using TeslaAPI;
using System.Net.Http;
using TeslaAPI.Models;

//
namespace TeslaX
{

    //
    public partial class MainPage : ContentPage
    {

        public ITeslaAPI _teslaAPI;// = new ITeslaAPI();
        public HttpClient _client = new HttpClient();
        TeslaAPI.TeslaAPI OTeslaAPI = new TeslaAPI.TeslaAPI();


        //
        public MainPage()
        {
            InitializeComponent();

            //var OTeslaAPI = new TeslaAPI.TeslaAPI();

            // Interface Init  
            //megaClient = DependencyService.Get<IMegaClient>();


            //BindingContext = DataFactory.DataItems;//DataFactory.Classes;
            _client.BaseAddress = new Uri("https://owner-api.teslamotors.com");
            _client.DefaultRequestHeaders.Add("User-Agent", "TeslaX");


        }//MainPage

        public MainPage(ITeslaAPI teslaAPI)
        {
            _teslaAPI = teslaAPI;
            _client.DefaultRequestHeaders.Add("User-Agent", "TeslaX");
        }


        /// <summary>
        /// Get all Vehicles in the user's account.
        /// </summary>
        /// <returns>Returns a list of all Vehicles.</returns>
        public async Task<List<Vehicle>> GetVehiclesAsync(string clientID, string clientSecret, string bearerToken)
        {
            TeslaAccessToken accessToken = new TeslaAccessToken() { };

            accessToken.AccessToken = bearerToken;//await _teslaAPI.GetAccesTokenAsync(_client, clientID, clientSecret, bearerToken);
            
            _client.DefaultRequestHeaders.Add(
                "Authorization", 
                $"Bearer {accessToken.AccessToken}");

            List<Vehicle> Vehicles = await OTeslaAPI.GetAllVehiclesAsync(_client);
            //return await _teslaAPI.GetAllVehiclesAsync(_client);

            return Vehicles;

        }

        // OnButton1Clicked
        private void OnButton1Clicked(object sender, EventArgs e)
        {
            Task<List<Vehicle>> A = GetVehiclesAsync(
                "clientId",      // ignore it (?) 
                "clientSecret",  // ignore it too (?)
                "refreshToken"); // paste here your refreshToken

            Debug.WriteLine(">> A=" + A.ToString());
        }


        // loginEntry_TextChanged
        private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string SearchBoxText = "";

            if (e.NewTextValue != null)
                SearchBoxText = e.NewTextValue.ToString();


            //DataFactory.FilterMegaItemsAsync(SearchBoxText);

        }//loginEntry_TextChanged


        

        // !!! ItemSelected handling
        private async void timelineList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            // starting...
            int idx = -1;
            //string StRes2 = "";

            if (e.SelectedItem == null)
            {
                return;
            }

            var SI = e.SelectedItem;

            idx = 1;//(SI as MegaBox.Model.DataItem).Id;

            if ((idx < 0) || (idx > 10000))
                return;

            //StRes2 = (SI as MegaBox.Model.DataItem).Headline;

            // Make Dialog Popup
            bool choosedresult = await DisplayAlert
            (
                "Testname" + " [11.11.2011-modified]",
                "Are you ready? Choose any answer, this is test.=)",
                "Yes",
                "No"
             );
            

            // finishing...
            ((ListView)sender).SelectedItem = null;

        }// Item_Selected

    }
}

