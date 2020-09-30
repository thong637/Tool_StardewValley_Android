using System;
using System.IO;
using Xamarin.Forms;
using System.Collections.Generic;
using static DTNGamer.Manager.ContentManager;
using DTNGamer.Interface;
namespace DTNGamer.Views
{
	public partial class LibraryPage : ContentPage
	{
		public static List<string> ID
		{
			get;
			internal set;
		} = new List<string>();
		public static List<IDTNGamerAPI> DTNGamers => new List<IDTNGamerAPI>();
		
		public static List<DTNGamer.Interface.Manifest> Manifests {get;set;} = new List<DTNGamer.Interface.Manifest>();
		public static string DiretoryPath => Android.OS.Environment.ExternalStorageDirectory + "/DTNGamerAPI";
			
		
		public LibraryPage()
		{
			InitializeComponent();
			this.Title = LoadString("library");
			Content = new CreateProject(null);
			
		}
		
	    
	}
}