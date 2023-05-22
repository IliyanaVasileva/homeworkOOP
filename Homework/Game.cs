using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Game
    {
        public Team FootballTeam1 { get;set }
    
            
        public Team FootballTeam2 { get; set; }
        public Referee Referee { get; set; }

        public List<string> CoReferees { get; set; }

        public List<(int Minute, FootballPlayer Player)> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void Goal(int minute, FootballPlayer player)
        {
            Goals.Add((minute, player));
        }

        public void ResultSet(string result, Team winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}
