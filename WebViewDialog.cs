using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Android.Views;
using Android.Webkit;
using Android.App;
using XamarinFormsUiLib;
namespace DTNGamer.Views
{

    public static class WebViewDialog 
    {
           public static void ShowDTNGamerWeb()
           {
           	Dialog dialog = new Dialog(Ui.Activity);
           	WebView webView = new WebView(dialog.Context);
           	
           	webView.Settings.JavaScriptEnabled = true;
           	webView.SetWebViewClient(new WebViewClient());
           	webView.LoadUrl("http://www.dtngamer.com");
           	dialog.SetContentView(webView);
           	dialog.Show();
           }
           public static void LoadUrl(string url)
           {
           	WebView webView = new WebView(Ui.Activity);
           	webView.LoadUrl(url);
           }
           public static void ShowAds()
           {
           	ShowDTNGamerWeb();
           }
    }
}