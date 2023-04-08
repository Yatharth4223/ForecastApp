using ForecastApp.Models;

namespace ForecastApp;

public partial class MatchSelection : ContentPage
{
    
	public MatchSelection(bool isChecked)
	{
		InitializeComponent();
        if (isChecked)
        {
            //TeamsListView.ItemsSource = TeamRepository.GetTeams();
            TeamsListView.ItemsSource = IplRepository.GetTeams();
        }
        else 
        {
            TeamsListView.ItemsSource = TeamRepository.GetTeams();
        }

    }

    private void SearchName_TextChanged(object sender, TextChangedEventArgs e)
    {
        TeamsListView.ItemsSource = TeamRepository.SelectByName(SearchName.Text);
    }

    private void TeamsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selectedMatch = TeamsListView.SelectedItem as Team;
    }
}