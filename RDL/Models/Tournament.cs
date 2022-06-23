using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


namespace RDL.Models
{
    public class Tournament
    {
        public Team teamOne { get; set; }
        public Team teamTwo { get; set; }
        public Team teamThree { get; set; }
        public List<Team> teams { get; set; } = new List<Team>();

        Random rand = new Random();
        public List<Match> matches { get; set; } = new List<Match>();

        Tournament()
        {
            teams.Add(teamOne);
            teams.Add(teamTwo);
            teams.Add(teamThree);

            Match matchOne = new Match();
            Match matchTwo = new Match();
            Match matchThree = new Match();
            Match matchFour = new Match();
            Match matchFive = new Match();

            int redTeam = rand.Next(1, 3);
            int blueTeam = rand.Next(1, 3);
            while(redTeam == blueTeam)
            {
                blueTeam = rand.Next(1, 3);
            }


        }
        
    }
}