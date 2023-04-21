using ForecastApp.Models;
namespace ForecastApp;

public partial class StatsPage : ContentPage
{
    private MatchStats _matchStats;

    public StatsPage(Team team)
    { 
        InitializeComponent();
        _matchStats = new MatchStats();
        double winpercentage= _matchStats.GetProbabilityOverPopulation() * 100;
        FirstStatsLabel.Text = $"The probability of the {team.HomeTeam} team to win is: {winpercentage}%";
        SecondStatsLabel.Text = $"The probability of the {team.Opponent} team to win is:{100 - winpercentage}%";

    }

}

