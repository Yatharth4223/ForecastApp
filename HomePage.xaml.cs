



using ForecastApp.Themes;

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
        bool isIpl = false;
        await Navigation.PushAsync(new MatchSelection(isIpl)) ;
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        bool isIpl = true;
        await Navigation.PushAsync(new MatchSelection(isIpl));
    }
}