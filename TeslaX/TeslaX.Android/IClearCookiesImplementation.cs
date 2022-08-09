using Xamarin.Forms;
using System.Net;
using Android.Webkit;
using TeslaX;

[assembly: Dependency(typeof(TeslaX.Droid.IClearCookiesImplementation))]
namespace TeslaX.Droid
{
    public class IClearCookiesImplementation : IClearCookies
    {
        public void Clear()
        {
            CookieManager cookieManager = CookieManager.Instance;
            cookieManager.RemoveAllCookie();
        }
    }
}