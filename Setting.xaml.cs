
using ForecastApp.Models;
using ForecastApp.Themes;


namespace ForecastApp;

public partial class Setting : ContentPage
{

	

	private List<Team> _football;
	private List<Team> _cricket;
	bool IsDarkMode;

	public Setting(bool isDarkMode)

	{
		InitializeComponent();
        var darkMode = isDarkMode ? true : false;
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (isDarkMode == true)
        {
            mergedDictionaries.Clear();
            Application.Current.Resources.Add(new DarkTheme());
            DarkMode.IsToggled = true;
            

        }
        else
        {
            mergedDictionaries.Clear();
            Application.Current.Resources.Add(new LightTheme());
            DarkMode.IsToggled = false;



        }

        LoadSetting();
		
        
        var football = TeamRepository.GetTeams();
		var cricket = IplRepository.GetTeams();
		FavoritePicker.ItemsSource = football;
		FavoriteIplPicker.ItemsSource = cricket;

		
	}
	
    private void DarkMode_Toggled(object sender, ToggledEventArgs e)
    {
		ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
		if(DarkMode.IsToggled)
		{
			mergedDictionaries.Clear();
			mergedDictionaries.Add(new DarkTheme());
			IsDarkMode= true;
			
			
		}
		else
		{
			mergedDictionaries.Clear();
			mergedDictionaries.Add(new LightTheme());
			IsDarkMode= false;
			
            
		}
		
    }

	private void LoadSetting()
	{
        
    }

    private void FavoritePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
		_football = FavoritePicker.SelectedItem as List<Team>;


    }

    private void FavoriteIplPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
		_cricket = FavoritePicker.SelectedItem as List<Team>;
    }

    protected override void OnDisappearing()
    {
        if (DarkMode.IsToggled == true)
		{
            Application.Current.Resources.Add(new DarkTheme());
			IsDarkMode= true;
        }
		else
		{
            Application.Current.Resources.Add(new LightTheme());
			IsDarkMode= false;

        }

    }
    

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
		bool darkMode = IsDarkMode? true: false;

        await DisplayAlert("Save", "Changes are saved", "OK");
		await Navigation.PushAsync(new HomePage(darkMode));
		
    }
}