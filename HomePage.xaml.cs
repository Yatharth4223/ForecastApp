namespace ForecastApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    async private void SettingsButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Setting());
    }

    async private void MatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MatchSelection());
    }
}