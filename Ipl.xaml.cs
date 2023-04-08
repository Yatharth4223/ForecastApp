using ForecastApp.Models;

namespace ForecastApp;

public partial class Ipl : ContentPage
{
	public Ipl()
	{
		InitializeComponent();
        IplListView.ItemsSource = IplRepository.GetTeams();
	}

    private void SearchName_TextChanged(object sender, TextChangedEventArgs e)
    {
        IplListView.ItemsSource = IplRepository.SelectByName(SearchName.Text);

    }

    private void IplListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selectedMatch = IplListView.SelectedItem as Ipl;
        

    }
}