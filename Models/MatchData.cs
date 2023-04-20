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

        public MatchData()
        {
            MatchOutcomes = new List<bool>();            
        }

        public async void PopulateMatchOutcomes()
        {
            List<bool> outcomes = new List<bool> { true, false };

            //Added 100 values for match data
            for (int i = 0; i < 100; i++)
            {
                MatchOutcomes.Add(outcomes[random.Next(0, 2)]);
            }
        }
        

    }
}

