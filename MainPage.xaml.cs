namespace ForecastApp;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}


    async void Setting_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Setting());
    }

    async void MatchSelection_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MatchSelection());
    }
}

