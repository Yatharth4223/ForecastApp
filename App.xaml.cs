﻿namespace ForecastApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		MainPage = new NavigationPage(new HomePage(darkMode : false));
	}
}
