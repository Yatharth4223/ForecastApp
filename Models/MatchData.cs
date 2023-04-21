using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    internal class MatchData
    {
        //private string teamOne;
        //private string teamTwo;
        //private bool didFirstTeamWin = false;
        public List<bool> _matchOutcomes;

        public MatchData()
        {
            _matchOutcomes = new List<bool>();            
        }


        

    }
}

