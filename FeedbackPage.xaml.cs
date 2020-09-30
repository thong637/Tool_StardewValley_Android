using System;
using System.IO;
using Xamarin.Forms;
using static DTNGamer.Manager.ContentManager;
namespace DTNGamer.Views
{
	public partial class FeedbackPage : ContentPage
	{
		public FeedbackPage()
		{
			InitializeComponent();
			
			this.Title = LoadString("feedback");
			
		}
	}
}