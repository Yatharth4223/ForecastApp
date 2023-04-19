<<<<<<< HEAD
namespace ForecastApp;

public partial class HomePage : ContentPage
{   
    public HomePage()
=======




using ForecastApp.Themes;

namespace ForecastApp;

public partial class HomePage : ContentPage
{

    private bool _darkmode;
    public HomePage(bool darkMode)
>>>>>>> 6f8e67b02661a6bff72fb5976d6747861ed3fae2
	{
		InitializeComponent();
        _darkmode = darkMode;
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (darkMode == true)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new DarkTheme());
            

        }
        else
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());
        }

    }

    async private void SettingsButton_Clicked(object sender, EventArgs e)
<<<<<<< HEAD
    {   
        await Navigation.PushAsync(new Setting(_darkMode));
=======
    {
        

        await Navigation.PushAsync(new Setting(_darkmode));
>>>>>>> 6f8e67b02661a6bff72fb5976d6747861ed3fae2
    }

    async private void LaLigaMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        bool isIpl = false;
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(isIpl, _darkMode)) ;
=======
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(isIpl,_darkmode)) ;
=======
        await Navigation.PushAsync(new MatchSelection(isIpl)) ;
>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
>>>>>>> 746d8c12b416a6b117d49a30d22eda31b8357fe1
>>>>>>> 6f8e67b02661a6bff72fb5976d6747861ed3fae2
    }

    private async void IplMatchSelectionButton_Clicked(object sender, EventArgs e)
    {
        bool isIpl = true;
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(isIpl, _darkMode));

=======
<<<<<<< HEAD
        await Navigation.PushAsync(new MatchSelection(isIpl,_darkmode));
=======
        await Navigation.PushAsync(new MatchSelection(isIpl));
>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
>>>>>>> 746d8c12b416a6b117d49a30d22eda31b8357fe1
>>>>>>> 6f8e67b02661a6bff72fb5976d6747861ed3fae2
    }
}