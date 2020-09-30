using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
namespace DTNGamer.Views
{


	public static class CustomButton 
	{
		public static void CreateRoundButtonV(Button button)
		{
			
			button.CornerRadius = 20;
			
		}
		public static void EditBorderColorV(Button button,Color color,int width)
		{
			button.BorderColor = color;
			button.BorderWidth = width;
			
		}
		public static Button CreateRoundButton(Button button)
		{
			
			button.CornerRadius = 20;
			return button;
			
		}
		public static Button EditBorderColor(Button button,Color color,int width)
		{
			button.BorderColor = color;
			button.BorderWidth = width;
			return button;
		}
		
	}
	
}