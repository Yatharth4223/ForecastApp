using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    public class Ipl
    {
        public string HomeTeam { get; set; }
        public string Opponent { get; set; }

        public string HomeTeamLogo { get; set; }

        public string OpponentLogo { get; set; }

        public string MatchTime { get; set; }
    }
}
