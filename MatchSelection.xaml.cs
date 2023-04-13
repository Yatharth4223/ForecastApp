using ForecastApp.Models;

namespace ForecastApp;

public partial class MatchSelection : ContentPage
{
    private bool _isIpl;
	public MatchSelection(bool isIPL)
	{
		InitializeComponent();
        _isIpl = isIPL;
        if (_isIpl == true)
        {
            TeamsListView.ItemsSource = IplRepository.GetTeams();
        }
        TeamsListView.ItemsSource = TeamRepository.GetTeams();
        
    }

    private void SearchName_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(_isIpl)
            TeamsListView.ItemsSource = IplRepository.SelectByName(SearchName.Text);
        TeamsListView.ItemsSource = TeamRepository.SelectByName(SearchName.Text);
    }

    private void TeamsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selectedMatchVaribale = TeamsListView.SelectedItem as Team;

    }
}