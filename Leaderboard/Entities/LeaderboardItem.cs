
namespace Leaderboard.Entities
{
    public class LeaderboardItem
    {
        public LeaderboardItem(string competitor, int played, int won, int lost, int drawn, int totalPoints)
        {
            Competitor = competitor;
            Played = played;
            Won = won;
            Lost = lost;
            Drawn = drawn;
            TotalPoints = totalPoints;
        }

        public string Competitor { get; }

        public int Played  { get; }

        public int Won { get; }

        public int Lost { get; }

        public int Drawn { get; }

        public int TotalPoints { get; }
    }
}