﻿using PanCardViewSample.Views;
using Xamarin.Forms;

namespace PanCardViewSample
{
	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new StartPage());
		}
	}

	public class StartPage : ContentPage
	{
		public StartPage()
		{
			var toCardsBtn = new Button { Text = "CardsView Items" };
			toCardsBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CardsSampleView());
			};

			var toCardsBtnCustom = new Button { Text = "CardsView CustomContexts" };
			toCardsBtnCustom.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CardsSampleCustomView());
			};

			var toCarouselBtn = new Button { Text = "SceneView" };
			toCarouselBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new SceneSampleView(Width));
			};

			var toCarouselScrollBtn = new Button { Text = "CarouselView scroll" };
			toCarouselScrollBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CarouselSampleSrollView());
			};

			var toCarouselDoubleBtn = new Button { Text = "CarouselView DoubleView" };
			toCarouselDoubleBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CarouselSampleDoubleView());
			};

			var toCarouselNoTemplateBtn = new Button { Text = "CarouselView No template" };
			toCarouselNoTemplateBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CarouselSampleViewNoTemplate());
			};

			var toCarouselXamlBtn = new Button { Text = "CarouselView Xaml" };
			toCarouselXamlBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CarouselSampleXamlView());
			};

			var toCarouselListBtn = new Button { Text = "Carousel ListView" };
			toCarouselListBtn.Clicked += (sender, e) =>
			{
				this.Navigation.PushAsync(new CarouselSampleListView());
			};

			Content = new StackLayout
			{
				Children = {
					toCardsBtn,
					toCardsBtnCustom,
					toCarouselBtn,
					toCarouselScrollBtn,
					toCarouselDoubleBtn,
					toCarouselNoTemplateBtn,
					toCarouselXamlBtn,
					toCarouselListBtn
				}
			};
		}
	}
}