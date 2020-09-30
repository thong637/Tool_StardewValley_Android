using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using Android.App;
using System.Runtime;
using System.Runtime.InteropServices;
using XamarinFormsUiLib;

namespace DTNGamer.Applications
{

	internal class Program
	{
		public static void Main()
		{
			Ui.RunOnUiThread(() =>
			{
				Ui.LoadApplication(new ApplicationDtn());
			});
		}
	}
	internal class ApplicationDtn : Xamarin.Forms.Application
	{
		public ApplicationDtn()
		{
			this.UserAppTheme = OSAppTheme.Dark;
			this.MainPage = new DTNGamer.Views.HomePage();
			DTNGamer.Views.WebViewDialog.ShowDTNGamerWeb();
		}

	}


	

}