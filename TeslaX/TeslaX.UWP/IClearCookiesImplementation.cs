using Xamarin.Forms;
using System.Net;
//using Android.Webkit;
using TeslaX;
using System;

[assembly: Dependency(typeof(TeslaX.UWP.IClearCookiesImplementation))]
namespace TeslaX.UWP
{
    public class IClearCookiesImplementation : IClearCookies
    {
        public void Clear()
        {
            CookieManager cookieManager = CookieManager.Instance;
            
            //TODO
            //cookieManager.RemoveAllCookie();
        }
    }

    public class CookieManager
    {
        public static CookieManager Instance { get; internal set; }

        public void RemoveAllCookie()
        {            
            //TODO
        }
    }
}