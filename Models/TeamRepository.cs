

namespace ForecastApp.Models
{
   
    public static class TeamRepository
    {

        public static List<Team> _teams;

        static TeamRepository() 
        {
            _teams = new List<Team>
            {
                new Team()
                {
                    HomeTeam= "Sevilla",
                    Opponent= "Celta Vigo",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/hCTs5EX3WjCMC5Jl3QE4Rw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/wpdhixHP_sloegfP0UlwAw_48x48.png",
                    MatchTime= "Fri, April 7, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Osasuna",
                    Opponent="Elche",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/pk-hNCNpGM_JDoHHvLVF-Q_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/uyyqqxLIYT_lQIXRyMI_RA_48x48.png",
                    MatchTime= "Sat, April 8, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Espanyol",
                    Opponent="Athletic Club",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TKitIqelDyN6M-kYt4Uc0g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/OSL_5Zm6kYPP1J17Bo5uDA_48x48.png",
                    MatchTime= "Sat, April 8, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Real Sociedad",
                    Opponent="Getafe",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/w8tb1aeBfVZIj9tZXf7eZg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/1UDHZMdKZD15W5gus7dJyg_48x48.png",
                    MatchTime= "Sat, April 8, 12:30 p.m."
                },
                new Team()
                {
                    HomeTeam="Real Madrid",
                    Opponent="Villareal",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Th4fAVAZeCJWRcKoLW7koA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/WKH7Ak5cYD6Qm1EEqXzmVw_48x48.png",
                    MatchTime= "Sat, April 8, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Valladolid",
                    Opponent="Mallorca",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/yvPDWQC1M4G7SIg9_eidgg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Ss21P4CUmigjrEtcoapjVg_48x48.png",
                    MatchTime= "Sun, April 9, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Real Betis",
                    Opponent="Cadiz",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/S0fDZjYYytbZaUt0f3cIhg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/H1vdTrUUqJBeUW1HfbW0nQ_48x48.png",
                    MatchTime= "Sun, April 9, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Almeria",
                    Opponent="Valencia",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kt3Bf9IFcvWB2N3CN-N7Wg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/QPbjvDwI_0Wuu4tCS2O6uw_48x48.png",
                    MatchTime= "Sun, April 9, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Rayo Vallecano",
                    Opponent="Atletico Madrid",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/i5LifmxEVIl0sbvIysiyhw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/srAAE0bOnCppUrlbJpFiHQ_48x48.png",
                    MatchTime= "Sun, April 9, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Barcelona",
                    Opponent="Girona",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/paYnEE8hcrP96neHRNofhQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Tyy5rCdiLCw2_8z04DM-GQ_48x48.png",
                    MatchTime= "Mon, April 10, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Rayo Vallencano",
                    Opponent="Osasuna",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/i5LifmxEVIl0sbvIysiyhw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/pk-hNCNpGM_JDoHHvLVF-Q_48x48.png",
                    MatchTime= "Fri, April 14, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Villarreal",
                    Opponent="Valladolid",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/WKH7Ak5cYD6Qm1EEqXzmVw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/yvPDWQC1M4G7SIg9_eidgg_48x48.png",
                    MatchTime= "Sat, April 15, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Althetic Club",
                    Opponent="Real Sociedad",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/OSL_5Zm6kYPP1J17Bo5uDA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/w8tb1aeBfVZIj9tZXf7eZg_48x48.png",
                    MatchTime= "Sat, April 15, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Real Betis",
                    Opponent="Espanyol",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/S0fDZjYYytbZaUt0f3cIhg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TKitIqelDyN6M-kYt4Uc0g_48x48.png",
                    MatchTime= "Sat, April 15, 12:30 a.m."
                },
                new Team()
                {
                    HomeTeam="Cadiz",
                    Opponent="Real Madrid",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/H1vdTrUUqJBeUW1HfbW0nQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Th4fAVAZeCJWRcKoLW7koA_48x48.png",
                    MatchTime= "Sat, April 15, 3:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Girona",
                    Opponent="Elche",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Tyy5rCdiLCw2_8z04DM-GQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/uyyqqxLIYT_lQIXRyMI_RA_48x48.png",
                    MatchTime= "Sun, April 16, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Getafe",
                    Opponent="Barcelona",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/1UDHZMdKZD15W5gus7dJyg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/paYnEE8hcrP96neHRNofhQ_48x48.png",
                    MatchTime= "Sun, April 16, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Atletico Madrid",
                    Opponent="Almeria",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/srAAE0bOnCppUrlbJpFiHQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kt3Bf9IFcvWB2N3CN-N7Wg_48x48.png",
                    MatchTime= "Sun, April 16, 12:30 a.m."
                },
                new Team()
                {
                    HomeTeam="Valencia",
                    Opponent="Sevilla",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/QPbjvDwI_0Wuu4tCS2O6uw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/hCTs5EX3WjCMC5Jl3QE4Rw_48x48.png",
                    MatchTime= "Sun, April 16, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Celta Vigo",
                    Opponent="Mallorca",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/wpdhixHP_sloegfP0UlwAw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Ss21P4CUmigjrEtcoapjVg_48x48.png",
                    MatchTime= "Mon, April 17, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Espanyol",
                    Opponent="Cadiz",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TKitIqelDyN6M-kYt4Uc0g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/H1vdTrUUqJBeUW1HfbW0nQ_48x48.png",
                    MatchTime= "Fri, April 21, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Osasuna",
                    Opponent="Real Betis",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/pk-hNCNpGM_JDoHHvLVF-Q_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/S0fDZjYYytbZaUt0f3cIhg_48x48.png",
                    MatchTime= "Sat, April 22, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Almeria",
                    Opponent="Athletic Club",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kt3Bf9IFcvWB2N3CN-N7Wg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/OSL_5Zm6kYPP1J17Bo5uDA_48x48.png",
                    MatchTime= "Sat, April 22, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Real Sociedad",
                    Opponent="Rayo Vallecano",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/w8tb1aeBfVZIj9tZXf7eZg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/i5LifmxEVIl0sbvIysiyhw_48x48.png",
                    MatchTime= "Sat, April 22, 12:30 p.m."
                },
                new Team()
                {
                    HomeTeam="Valladolid",
                    Opponent="Girona",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/yvPDWQC1M4G7SIg9_eidgg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Tyy5rCdiLCw2_8z04DM-GQ_48x48.png",
                    MatchTime= "Sat, April 22, 12:30 p.m."
                },
                new Team()
                {
                    HomeTeam="Real Madrid",
                    Opponent="Celta Vigo",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Th4fAVAZeCJWRcKoLW7koA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/wpdhixHP_sloegfP0UlwAw_48x48.png",
                    MatchTime= "Sat, April 22, 3:00 p.m."
                },
                new Team()
                {
                    HomeTeam="Elche",
                    Opponent="Valencia",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/uyyqqxLIYT_lQIXRyMI_RA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/QPbjvDwI_0Wuu4tCS2O6uw_48x48.png",
                    MatchTime= "Sun, April 23, 8:00 a.m."
                },
                new Team()
                {
                    HomeTeam="Barcelona",
                    Opponent="Atletico Madrid",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/paYnEE8hcrP96neHRNofhQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/srAAE0bOnCppUrlbJpFiHQ_48x48.png",
                    MatchTime= "Sun, April 23, 10:15 a.m."
                },
                new Team()
                {
                    HomeTeam="Mallorca",
                    Opponent="Getafe",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/Ss21P4CUmigjrEtcoapjVg_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/1UDHZMdKZD15W5gus7dJyg_48x48.png",
                    MatchTime= "Sun, April 23, 12:30 a.m."
                },
                new Team()
                {
                    HomeTeam="Sevilla",
                    Opponent="Villareal",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/hCTs5EX3WjCMC5Jl3QE4Rw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/WKH7Ak5cYD6Qm1EEqXzmVw_48x48.png",
                    MatchTime= "Sun, April 23, 3:00 p.m."
                },


            };


        }
        public static List<Team> GetTeams()
        {
            return _teams;
        }

        public static List<Team> SelectByName(string name)
        {
            var result = new List<Team>();
            foreach(var team in _teams)
            {
                if(team.HomeTeam.ToLower().Contains(name.ToLower()) || team.Opponent.ToLower().Contains(name.ToLower()))
                    result.Add(team);
            }
            return result;
        }
    }
}
