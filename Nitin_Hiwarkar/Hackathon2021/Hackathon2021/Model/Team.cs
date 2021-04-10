using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon2021.Model
{
   
    public class Categories
    {
        public int categoryID { get; set; }
        public string Category { get; set; } //batsman,bowler,wc

    }
    public class Teams
    {
        public int teamID { get; set; }
        public string teamName { get; set; } // westindies or india
    }
    public class Cricketer
    {
        public int id { get; set; }
        public int teamID { get; set; }  // westindies or india
        public int categoryID { get; set; } //batsman,bowler,wc
        public string cricketer_Name { get; set; }

    }

    public class Season
    {
        public int Seasonid { get; set; }
        public string Season_Name { get; set; }

    }
    public class Venue
    {
        public int Venueid { get; set; }
        public string Venue_Name { get; set; }

    }
    public class wickettype
    {
        public int wicket_type_id { get; set; }
        public string wicket_type { get; set; }

    }
    public class Data
    {
        public int match_id { get; set; }
        public int Seasonid { get; set; }
        public DateTime start_date { get; set; }
        public int Venueid { get; set; }
        public int innings { get; set; }
        public float ball { get; set; }
        public int batting_teamID { get; set; }
        public string bowling_teamID { get; set; }
        public string striker { get; set; }
        public string non_striker { get; set; }
        public int bowlerID { get; set; }
        public int runs_off_bat { get; set; } 
        public int extras { get; set; }
        public int wides { get; set; }
        public int noballs { get; set; }
        public int byes { get; set; }
        public int legbyes { get; set; }
        public int penalty { get; set; } 
        public int wicket_type_id { get; set; }
        public string player_dismissed { get; set; } 
        public string other_wicket_type { get; set; }
        public string other_player_dismissed { get; set; }

    }
}

