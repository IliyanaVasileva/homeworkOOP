using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Team
    {
        public Coach Coach { get; set; }
        private List<FootballPlayer> players;

        public List<FootballPlayer> Players {
            get { return players; }
            set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new ArgumentException("A team must have between 11 and 22 players.");
                }
                players = value;
            }
        }

        public double AverageAge()
        {
            double AverageAge = Players.Sum(player => player.Age);
            return AverageAge / Players.Count;
        }
    }
}
