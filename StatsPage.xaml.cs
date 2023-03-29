namespace ForecastApp;

public partial class StatsPage : ContentPage
{
    private MatchData _matchData;
	public StatsPage()
	{
		InitializeComponent();
        _matchData= new MatchData();
	}
    public float FindWinProbability()
    {
        int favourableOutcomes = 0;
        foreach (bool k in _matchData.MatchOutcomes)
        {

            if (k == true)
            {
                favourableOutcomes += 1;
            }
        }
        return favourableOutcomes / _matchData.MatchOutcomes.Count;
    }

    //The above method finds probability in a small sample of values, the below method finds it for a big data(more accurate)
    public float FindProbabilityOverPopulation()
    {
        //formula used probability = C(n,r) * p^(n-r) * q^r
        //where n is total number of values, r is one(because we need winning condition in next match only), p is calculated from above table and q is 1-p

        //todo: make a method to calculate factorial
        //todo: use formula and find probability
        //todo: use formula and find probability
        return 0.0f;
    }



}