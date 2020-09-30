using System;
using System.IO;
using Xamarin.Forms;
using static DTNGamer.Manager.ContentManager;
using DTNGamer.Interface;
namespace DTNGamer.Views
{
	public partial class MainPageApp : ContentPage
	{
		public static Action NullLibrary {get;set;}
		public MainPageApp()
		{
			InitializeComponent();
			this.Title = LoadString("main");
			StackLayout stackLayout = new StackLayout();
			stackLayout.Orientation = StackOrientation.Vertical;
			MainLayout layout = new MainLayout();
			layout.ButtonClick += ()=>{
				if(LibraryPage.ID.Count > 0)
				{
					stackLayout.Children.Clear();
					
					
				}
				else
				{
					NullLibrary?.Invoke();
				}
			};
			stackLayout.Children.Add(layout);
			stackLayout.Children.Add(new MainLayoutTool());
			
			Content = new ScrollView()
			{
				Content = stackLayout
			};
			
		}
	}
	public class MainLayout : StackLayout
	{
		public event Action ButtonClick ;
		public MainLayout()
		{
			this.Orientation = StackOrientation.Vertical;
			Button b = DTNGamer.Views.CustomButton.CreateRoundButton(new Button());
			b.Text = LoadString("in");
			
			b = DTNGamer.Views.CustomButton.EditBorderColor(b,Color.Aqua,3);
			
			b.BackgroundColor = Color.CadetBlue;
		    var stackLayout = new Grid();
		    Label l = new Label();
		    l.FontSize = l.FontSize + 5;
		    l.VerticalOptions = LayoutOptions.Center;
		    l.HorizontalOptions = LayoutOptions.Start;
		    l.TextColor = Color.Black;
		    l.Text = LoadString("premodcreate");
		    stackLayout.Children.Add(l);
		    stackLayout.VerticalOptions = LayoutOptions.End;
		    stackLayout.BackgroundColor = Color.GreenYellow;
		    b.VerticalOptions = LayoutOptions.Center;
		    b.HorizontalOptions = LayoutOptions.End;
		    
		    Image i = new Image();
		    i.Source = Load("Screenshot_20200923-182110.jpg");
		    Grid grid = new Grid();
		    grid.Children.Add(i);
		    grid.Children.Add(stackLayout);
		    stackLayout.Children.Add(b);
		    b.Clicked += (o,e)=>{
		       ButtonClick?.Invoke();
		    };
		    this.Children.Add(grid);
		    
		}
	}
	public class CreateProject : StackLayout
	{
		public Action<DTNGamer.Interface.SaveCreateMod> Created {get;set;}
		public Action CreateError {get;set;}
		public CreateProject(DTNGamer.Interface.ContentPackFor contentPackFor)
		{
			this.Orientation = StackOrientation.Vertical;
			this.BackgroundColor = Color.Brown;
			Editor editor_name = new Editor();
			Editor editor_author = new Editor();
			Editor editor_ver = new Editor();
			editor_ver.Keyboard = Keyboard.Telephone;
			Editor editor_Description = new Editor();
			Editor editor_id = new Editor();
			editor_id.Placeholder = LoadString("editor_id");
			editor_name.Placeholder = LoadString("editor_name");
			editor_author.Placeholder = LoadString("editor_author");
			editor_ver.Placeholder = LoadString("editor_ver");
			editor_Description.Placeholder = LoadString("editor_Description");
			this.Children.Add(editor_name);
			this.Children.Add(editor_author);
			this.Children.Add(editor_Description);
			this.Children.Add(editor_id);
			this.Children.Add(editor_ver);
			var b = CustomButton.CreateRoundButton(CustomButton.EditBorderColor(new Button(){BackgroundColor = Color.WhiteSmoke,TextColor = Color.Black , Text = LoadString("Create")},Color.SkyBlue,3));
			b.Clicked += (o,e)=>{
				if(!Check(editor_name) && !Check(editor_author) && !Check(editor_Description) && !Check(editor_ver) && !Check(editor_id))
				{
					DTNGamer.Interface.SaveCreateMod mod = new DTNGamer.Interface.SaveCreateMod()
					{
						Name = editor_name.Text,
						Author = editor_author.Text,
						Description = editor_Description.Text,
						Version = editor_ver.Text,
						UniqueID = editor_id.Text,
						ContentPackFor = contentPackFor
					};
					
					Created?.Invoke(mod);
				}
				else
				{
					CreateError?.Invoke();
				}
			};
			this.Children.Add(b);
			
		}
		public bool Check(Editor editor)
		{
			return string.IsNullOrEmpty(editor.Text);
		}
		
	}
	
	public class MainLayoutTool : StackLayout
	{
		public event Action ButtonClick ;
		public MainLayoutTool()
		{
			this.Orientation = StackOrientation.Vertical;
			Button b = DTNGamer.Views.CustomButton.CreateRoundButton(new Button());
			b.Text = LoadString("in");
			
			b = DTNGamer.Views.CustomButton.EditBorderColor(b,Color.Aqua,3);
			
			b.BackgroundColor = Color.CadetBlue;
		    var stackLayout = new Grid();
		    Label l = new Label();
		    l.FontSize = l.FontSize + 5;
		    l.VerticalOptions = LayoutOptions.Center;
		    l.HorizontalOptions = LayoutOptions.Start;
		     
		    l.TextColor = Color.Black;
		    l.Text = LoadString("pretool");
		    stackLayout.Children.Add(l);
		    stackLayout.VerticalOptions = LayoutOptions.End;
		    stackLayout.BackgroundColor = Color.GreenYellow;
		    b.VerticalOptions = LayoutOptions.Center;
		    b.HorizontalOptions = LayoutOptions.End;
		    
		    Image i = new Image();
		    i.Source = Load("Screenshot_20200923-182756.jpg");
		    Grid grid = new Grid();
		    grid.Children.Add(i);
		    grid.Children.Add(stackLayout);
		    stackLayout.Children.Add(b);
		    b.Clicked += (o,e) =>{
		    	ButtonClick?.Invoke();
		    };
		    this.Children.Add(grid);
		    
		}
	}
}