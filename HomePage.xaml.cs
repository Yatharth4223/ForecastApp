

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

    async private void LaLigaMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new MatchSelection(false));
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new MatchSelection(true));
    }
}