using ForecastApp.Models;
namespace ForecastApp;

public partial class StatsPage : ContentPage
{
    private MatchStats _matchStats;
    private double _winpercentage;
    private Team _team;

    public StatsPage(Team team)
    { 
        InitializeComponent();
        _team = team;
        _matchStats = new MatchStats();
        _winpercentage = _matchStats.GetProbabilityOverPopulation();
        Team1Logo.Source =$"{team.HomeTeamLogo}";
        Team2Logo.Source = $"{team.OpponentLogo}";

        List<string> images = new List<string> { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty","hundred"};
        Team1StatsImage.Source = $"{images[(int)(_winpercentage*10)]}.jpg";
        Team2StatsImage.Source = $"{images[(int)(10 - (_winpercentage * 10))]}.jpg";
        Team1List.ItemsSource = _matchStats.GetMatches();

    }

    private void BidButton_Clicked(object sender, EventArgs e)
    {
        if (_winpercentage > (100 - _winpercentage))
            DisplayAlert("Info", $"You should bid for {_team.HomeTeam}", "OK");
        else
        {
            DisplayAlert("Info", $"You should bid for {_team.Opponent}", "OK");
        }
    }
}

