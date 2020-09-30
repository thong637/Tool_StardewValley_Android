using System;
using Xamarin.Forms;
namespace DTNGamer.Views
{
	public partial class HomePage
	{
		internal TabBar Bar;
		internal Tab FeedBack;
		internal ShellContent ShellFeedBack;
		internal Tab MainPage;
		internal Tab Library;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(HomePage));
				Bar = (TabBar)this.FindByName("Bar");
				FeedBack = (Tab)this.FindByName("FeedBack");
				ShellFeedBack = (ShellContent)this.FindByName("ShellFeedBack");
				MainPage = (Tab)this.FindByName("MainPage");
				Library = (Tab)this.FindByName("Library");
		}
	}
}
