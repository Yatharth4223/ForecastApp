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
<<<<<<< HEAD
        TeamsListView.ItemsSource = TeamRepository.GetTeams();
        
=======
        else
        {
            TeamsListView.ItemsSource = TeamRepository.GetTeams();

        }

>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
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
<<<<<<< HEAD

=======
        Navigation.PushAsync(new StatsPage(selectedMatchVaribale));
        
>>>>>>> 0418c2b5cb18df06eb12c990ad77202428cd5357
    }
}