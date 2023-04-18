using ForecastApp.Models;
namespace ForecastApp;

public partial class StatsPage : ContentPage
{
    private MatchStats _matchStats;

    public StatsPage(Team team) { 
        InitializeComponent();
        FirstStatsLabel.Text = $"The probability of the {team.HomeTeam} team to win is: {_matchStats.FindProbabilityOverPopulation()}";
        SecondStatsLabel.Text = $"The probability of the {team.Opponent} team to win is: {1 - _matchStats.FindProbabilityOverPopulation()}";
    }

}

