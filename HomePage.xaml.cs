namespace ForecastApp;

public partial class HomePage : ContentPage
{
    private bool _iplButtonClicked;

    public HomePage()
	{
		InitializeComponent();
	}

    async private void SettingsButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Setting());
    }

    async private void LaLigaMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        _iplButtonClicked = false;
        await Navigation.PushAsync(new MatchSelection(_iplButtonClicked));
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        _iplButtonClicked = true;
        await Navigation.PushAsync(new MatchSelection(_iplButtonClicked));
    }
}