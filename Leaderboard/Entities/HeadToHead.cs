
namespace Leaderboard.Entities
{
    public enum Round
    {
        Round1,
        Round2,
        Round3,
        Round4,
        Round5,
        Round6,
        Round7,
        Round8,
    }

    public class HeadToHead
    {
        public HeadToHead(
            Round round,
            Competitor competitor1, 
            Competitor competitor2,
            int points1,
            int points2) 
        {
            Round = round;
            Competitor1 = competitor1;
            Competitor2 = competitor2;
            competitor1.SetPoints(round, points1);
            competitor2.SetPoints(round, points2);
        }

        public Round Round { get; }

        public Competitor Competitor1 { get; }

        public Competitor Competitor2 { get; }
    }
}