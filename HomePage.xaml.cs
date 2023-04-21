

using ForecastApp.Themes;

namespace ForecastApp;

public partial class HomePage : ContentPage
{

    private bool _darkmode;
    public HomePage(bool darkMode)

	{
		InitializeComponent();
    }

    async private void SettingsButton_Clicked(object sender, EventArgs e)

    {   
        await Navigation.PushAsync(new Setting(_darkmode));
    }

    async private void LaLigaMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        bool isIpl = false;

        await Navigation.PushAsync(new MatchSelection(isIpl,_darkmode)) ;
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        bool isIpl = true;


        await Navigation.PushAsync(new MatchSelection(isIpl,_darkmode));

        

    }
}