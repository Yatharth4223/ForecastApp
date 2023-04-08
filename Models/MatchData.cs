using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    internal class MatchData
    {
        private string teamOne;
        private string teamTwo;
        private bool didFirstTeamWin = false;
        private Random random = new Random();
        public List<bool> MatchOutcomes { get; }



        //public List<bool> MatchOutcomes { get; }

        public MatchData()
        {
            List<bool> outcomes = new List<bool> { true, false };
            MatchOutcomes = new List<bool>()
            {
                //todo: generate true or false randomly 10 times;
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
                outcomes[random.Next(0, outcomes.Count)],
            };
        }

        
    }
}

