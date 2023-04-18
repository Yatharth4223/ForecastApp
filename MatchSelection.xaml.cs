using ForecastApp.Models;
using ForecastApp.Themes;

namespace ForecastApp;

public partial class MatchSelection : ContentPage
{
    private bool _isIpl;

    private bool _darkMode;

    public static bool isToggled = false;
	public MatchSelection(bool isIPL,bool darkMode)
	{
		InitializeComponent();
        _isIpl = isIPL;
        if (_isIpl == true)
        {
            TeamsListView.ItemsSource = IplRepository.GetTeams();
        }
        else
        {
            TeamsListView.ItemsSource = TeamRepository.GetTeams();

        }
        _darkMode = darkMode;
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (_darkMode == true)
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

    private void SearchName_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (_isIpl)
        {
            TeamsListView.ItemsSource = IplRepository.SelectByName(SearchName.Text);

        }
        else
        {
            TeamsListView.ItemsSource = TeamRepository.SelectByName(SearchName.Text);

        }
    }

    private void TeamsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selectedMatchVaribale = TeamsListView.SelectedItem as Team;
        Navigation.PushAsync(new StatsPage(selectedMatchVaribale));
        
    }
}