

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
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(false));
=======
        bool isIpl = false;
        await Navigation.PushAsync(new MatchSelection(isIpl)) ;
>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(true));
=======
        bool isIpl = true;
        await Navigation.PushAsync(new MatchSelection(isIpl));
>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
    }
}