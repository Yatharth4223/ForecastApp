using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp
{
    internal class MatchData
    {
        private string teamOne;
        private string teamTwo;
        private bool didTeamWin = false;

        public List<bool> MatchOutcomes { get; }

        public MatchData()
        {
            List<bool> list = new List<bool>()
            {
                //todo: generate true or false randomly 10 times;
                true, false, true, true, false, false, false, false, true, true
            };
            MatchOutcomes = list;
        }

    }
}
