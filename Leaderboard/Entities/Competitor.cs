using System.Collections.Generic;
using System.Linq;

namespace Leaderboard.Entities
{
    public class Competitor
    {
        Dictionary<Round, int> allPoints;

        public Competitor()
        {
            this.allPoints = new Dictionary<Round, int>();
        }

        public Competitor(string name)
        {
            this.allPoints = new Dictionary<Round, int>();
            Name = name;
        }

        public string Name { get; set; }


        public int Played()
        {
            return allPoints.Count;
        }

        public int Won()
        {
            return allPoints.Count(x => x.Value == 4);
        }

        public int Lost()
        {
            return allPoints.Count(x => x.Value == 0);
        }

        public int Drawn()
        {
            return allPoints.Count(x => x.Value == 2);
        }

        public int TotalPoints()
        {
            return allPoints.Sum(x => x.Value);
        }

        public void SetPoints(Round round, int points)
        {
            allPoints[round] = points;
        }

        public int GetPoints(Round round)
        {
            return allPoints.ContainsKey(round) ? allPoints[round] : 0;
        }

        public Competitor Str2Competitor(string name)
        {
            return this.Name == name ? this : null; 
        }
    }
}