using Leaderboard.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Leaderboard.Models
{
    public class LeaderboardModel
    {
        private static List<Competitor> competitorList = new List<Competitor>();
        private static List<HeadToHead> headToHeadList = new List<HeadToHead>();

        public LeaderboardModel()
        {
            ExampleData.SetupExampleData(
                competitorList, 
                headToHeadList);
        }

        public void AddCompetitor(Competitor competitor)
        {
            competitorList.Add(competitor);
        }

        public void AddHeadToHead(HeadToHead headToHead)
        {
            headToHeadList.Add(headToHead);
        }

        public List<Competitor> GetCompetitors()
        {
            return competitorList;
        }

        public List<HeadToHead> GetHeadToHeads()
        {
            return headToHeadList;
        }

        public List<LeaderboardItem> GetLeaderboardItems()
        {
            var items = GetCompetitors()
                .Select(c => new LeaderboardItem(
                    c.Name, 
                    c.Played(), 
                    c.Won(), 
                    c.Lost(), 
                    c.Drawn(), 
                    c.TotalPoints()));

            return items.OrderByDescending(x => x.TotalPoints).ToList();
        }
    }
}