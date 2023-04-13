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
        }
        public double FindProbabilityOverPopulation()
        {
            //formula used probability = C(n,r) * p^(n-r) * q^r
            // C(100,1) is 100 therefore formula is 100* p(99) * q(1)
            double p = GetWinProbabilityForOneMatch();
            double q = 1 - p;
            double winProbability = 100 * Math.Pow(p, 99) * q;
            //where n is total number of values, r is one(because we need winning condition in next match only), p is calculated from above table and q is 1-p
            return winProbability;
        }

        private double GetWinProbabilityForOneMatch()
        {
            int totalWins = 0;
            foreach (bool b in _matchData.MatchOutcomes)
            {
                if (b == true)
                {
                    totalWins += 1;
                }
            }
            return totalWins / 10;
        }
    }


}
