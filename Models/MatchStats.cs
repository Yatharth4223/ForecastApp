using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    internal class MatchStats
    {
        private MatchData _matchData;

        public MatchStats() 
        {
            _matchData = new MatchData();
            PopulateMatchOutcomes();
        }
        public double GetProbabilityOverPopulation()
        {
            //formula used probability = C(n,r) * p^(n-r) * q^r
            // C(10,1) is 10 therefore formula is 10* p(9) * q(1)
            double p = GetWinProbabilityForOneMatch();
            //double q = 1 - p;
            //double winProbability = 100 * Math.Pow(p, 9) * q;
            //where n is total number of values, r is one(because we need winning condition in next match only), p is calculated from above table and q is 1-p
            return p;
        }
        
        public double GetWinProbabilityForOneMatch()
        {
            int totalWins = 0;
            foreach (bool b in _matchData._matchOutcomes)
            {
                if (b == true)
                {
                    totalWins += 1;
                }
            }
            //because total matches were 10
            return (double)totalWins / 10;  
        }


        public void PopulateMatchOutcomes()
        {
            List<bool> outcomes = new List<bool> { true, false };
            for(int i=0;i<10;i++)
            {
                _matchData._matchOutcomes.Add(outcomes[new Random().Next(0,2)]);
            }        
        }

        public List<bool> GetMatches()
        {
            return _matchData._matchOutcomes;
        }
       
    }



}
