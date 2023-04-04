using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models
{
    public static class IplRepository
    {
        public static List<Ipl> _iplMatches;

        static IplRepository()
        {
            _iplMatches = new List<Ipl>
            {
                new Ipl()
                {
                    HomeTeam= "CSK",
                    Opponent= "GT",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    MatchTime= "Fri, Mar 31, 3:00 p.m."
                },
                new Ipl()
                {
                    HomeTeam="PBKS",
                    Opponent="KKR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    MatchTime= "Sat, April 1, 8:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="LSG",
                    Opponent="DC",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TjudW-BaNE2HcD_6cOWC7Q_48x48.png",
                    MatchTime= "Sat, April 1, 10:15 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RR",
                    Opponent="SRH",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    MatchTime= "Sun, April 2, 12:30 p.m."
                },
                new Ipl()
                {
                    HomeTeam="MI",
                    Opponent="RCB",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/f958HPOsI1ugsHmwc4piCw_48x48.png",
                    MatchTime= "Sun, April 2, 3:00 p.m."
                },
                new Ipl()
                {
                    HomeTeam="CSK",
                    Opponent="LSG",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    MatchTime= "Mon, April 3, 8:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="DC",
                    Opponent="GT",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TjudW-BaNE2HcD_6cOWC7Q_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    MatchTime= "Tue, April 4, 10:15 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RR",
                    Opponent="PBKS",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    MatchTime= "Wed, April 5, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="KKR",
                    Opponent="RCB",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/f958HPOsI1ugsHmwc4piCw_48x48.png",
                    MatchTime= "Thu, April 6, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="LSG",
                    Opponent="SRH",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    MatchTime= "Fri, April 7, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RR",
                    Opponent="DC",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TjudW-BaNE2HcD_6cOWC7Q_48x48.png",
                    MatchTime= "Sat, April 8, 6:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="MI",
                    Opponent="CSK",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    MatchTime= "Sat, April 8, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="GT",
                    Opponent="KKR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    MatchTime= "Sun, April 9, 6:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="SRH",
                    Opponent="PBKS",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    MatchTime= "Sun, April 9, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RCB",
                    Opponent="LSG",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/f958HPOsI1ugsHmwc4piCw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    MatchTime= "Mon, April 10, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="DC",
                    Opponent="MI",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TjudW-BaNE2HcD_6cOWC7Q_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    MatchTime= "Tue, April 11, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="CSK",
                    Opponent="RR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    MatchTime= "Wed, April 12, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="PBKS",
                    Opponent="GT",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    MatchTime= "Thu, April 13, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="KKR",
                    Opponent="SRH",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    MatchTime= "Fri, April 14, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="LSG",
                    Opponent="PBKS",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    MatchTime= "Sat, April 15, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="MI",
                    Opponent="KKR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    MatchTime= "Sun, April 16, 6:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="GT",
                    Opponent="RR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    MatchTime= "Sun, April 16, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RCB",
                    Opponent="CSK",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/f958HPOsI1ugsHmwc4piCw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    MatchTime= "Mon, April 17, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="SRH",
                    Opponent="MI",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    MatchTime= "Tue, April 18, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="RR",
                    Opponent="LSG",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/turpQqyPRIMvuksLiSDSjQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    MatchTime= "Wed, April 19, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="PBKS",
                    Opponent="RCB",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/f958HPOsI1ugsHmwc4piCw_48x48.png",
                    MatchTime= "Thu, April 20, 6:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="DC",
                    Opponent="KKR",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/TjudW-BaNE2HcD_6cOWC7Q_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/kkwGQB9t8WtGPx9WuiBGOw_48x48.png",
                    MatchTime= "Thu, April 20, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="CSK",
                    Opponent="SRH",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/exZiFUT_GXScTyr358t7SQ_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/G9q07ZXPVbPkXOagStz3Yw_48x48.png",
                    MatchTime= "Fri, April 21, 10:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="LSG",
                    Opponent="GT",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/b6uyRF-RX56muhQOv1-Z3A_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/24uPDj4LAP1wpSEGHZWRDQ_48x48.png",
                    MatchTime= "Sat, April 22, 6:00 a.m."
                },
                new Ipl()
                {
                    HomeTeam="MI",
                    Opponent="PBKS",
                    HomeTeamLogo="https://ssl.gstatic.com/onebox/media/sports/logos/JTre94vh6WJeLmIL-Dfc1g_48x48.png",
                    OpponentLogo="https://ssl.gstatic.com/onebox/media/sports/logos/HxbhoKfAgDZogey6S9E4bA_48x48.png",
                    MatchTime= "Sat, April 22, 10:00 a.m."
                },


            };


        }
        public static List<Ipl> GetTeams()
        {
            return _iplMatches;
        }

        public static List<Ipl> SelectByName(string name)
        {
            var result = new List<Ipl>();
            foreach (var iplMatch in _iplMatches )
            {
                if (iplMatch.HomeTeam.ToLower().Contains(name.ToLower()) || iplMatch.Opponent.ToLower().Contains(name.ToLower()))
                    result.Add(iplMatch);
            }
            return result;
        }
    }
}
