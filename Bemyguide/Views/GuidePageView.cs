﻿using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class GuidePageView : ContentPage
	{
		public GuidePageView ()
		{
			this.BackgroundColor = Color.Black;

			var layout = new StackLayout{ Padding = new Thickness (5, 10) };
			this.Title = "Help Page";
			layout.Children.Add (new Label {
				Text = "This will contain some helpful information.",
				FontSize = 30,
				TextColor = Color.White
			});

			var browser = new WebView ();
			var htmlSource = new HtmlWebViewSource ();
			htmlSource.Html = @"<iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/Y7bxlR-MxxM"" frameborder=""0"" allowfullscreen></iframe>";
			browser.Source = htmlSource;
			browser.HeightRequest = 215.0;
			browser.WidthRequest = 320.0;


			layout.Children.Add (browser);
			layout.Children.Add (
				new Button () {Text = "I'm ready to start",
					Command = new Command (() => this.Navigation.PushAsync (new MainListViews ()))
				});
			this.Content = layout;
		}
	}
}

