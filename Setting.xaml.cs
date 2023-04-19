
using Microsoft.Maui.Controls;
namespace ForecastApp;

public partial class Setting : ContentPage
{
	public Setting(bool darkMode)
	{
		InitializeComponent();
		LoadSetting();
	}

    private void DarkMode_Toggled(object sender, ToggledEventArgs e)
    {
		
    }

	private void LoadSetting()
	{
		

	}

    private void FavoritePicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}