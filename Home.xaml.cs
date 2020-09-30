using System;
using System.IO;
using Xamarin.Forms;

namespace DTNGamer.Views
{
	public partial class Home : TabbedPage
	{
		public Home()
		{
			InitializeComponent();
			this.BarBackgroundColor = Color.WhiteSmoke;
			
			this.SelectedTabColor = Color.DarkRed;
			this.UnselectedTabColor = Color.WhiteSmoke;
		}
	}
}