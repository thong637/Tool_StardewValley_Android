using System;
using System.IO;
using Xamarin.Forms;
using static DTNGamer.Manager.ContentManager;
namespace DTNGamer.Views
{
	public partial class HomePage : Shell
	{
		public HomePage()
		{
			InitializeComponent();
			
			
		    
			this.Bar.CurrentItem = this.MainPage;
			this.FeedBack.Title = LoadString("feedback");
			this.MainPage.Title = LoadString("main");
			this.Library.Title = LoadString("library");
			this.MainPage.Icon = Load("home-512.webp");
			this.FeedBack.Icon = Load("1213171-200.png");
			this.Library.Icon = Load("532.png");
	        MainPageApp.NullLibrary = ()=>{
	        	
	        	this.Bar.CurrentItem = this.Library;
	        	DisplayAlert(LoadString("title_error"),LoadString("body_download_library"),LoadString("end"));
	        };
		}
		
	}
}