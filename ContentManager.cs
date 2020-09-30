using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using TImage = Xamarin.Forms.ImageSource;
using Newtonsoft.Json;
using XamarinFormsUiLib;

namespace DTNGamer.Manager
{

	public static class ContentManager
	{

		public static TImage Load(string assets)
		{
			return TImage.FromStream(() => Ui.GetAsset(assets));
		}
		public static T Load<T>(string assets) where T : new()
		{

			return JsonConvert.DeserializeObject<T>(Ui.GetAssetAsString(assets));
		}
		public static string LoadString(string key)
		{
			var k = Load<Dictionary<string, string>>("i18n.json");

			return k[key];
			
		}
		

	}
}