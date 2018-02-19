
using System.Collections.Generic;

namespace Leaderboard.Entities
{
    public static class ExampleData
    {
        public static void SetupExampleData(
            List<Competitor> competitorList,
            List<HeadToHead> headToHeadList)
        {
            var footscray = AddCompetitor(competitorList, "Footscray");
            var nthMelbourne = AddCompetitor(competitorList, "Nth Melbourne");
            var richmond = AddCompetitor(competitorList, "Richmond");
            var stkilda = AddCompetitor(competitorList, "St Kilda");
            var melbourne = AddCompetitor(competitorList, "Melbourne");
            var carlton = AddCompetitor(competitorList, "Carlton");

            // round 1
            headToHeadList.Add(new HeadToHead(Round.Round1, footscray, nthMelbourne, 4, 0));
            headToHeadList.Add(new HeadToHead(Round.Round1, richmond, stkilda, 4, 0));
            headToHeadList.Add(new HeadToHead(Round.Round1, melbourne, carlton, 4, 0));

            // round 2
            headToHeadList.Add(new HeadToHead(Round.Round2, footscray, carlton, 4, 0));
            headToHeadList.Add(new HeadToHead(Round.Round2, melbourne, richmond, 0, 4));
            headToHeadList.Add(new HeadToHead(Round.Round2, nthMelbourne, stkilda, 2, 2));

            // round 3
            headToHeadList.Add(new HeadToHead(Round.Round3, footscray, stkilda, 4, 0));
            headToHeadList.Add(new HeadToHead(Round.Round3, melbourne, carlton, 2, 2));
            headToHeadList.Add(new HeadToHead(Round.Round3, nthMelbourne, richmond, 0, 4));
        }

        private static Competitor AddCompetitor(List<Competitor> competitorList, string name)
        {
            var competitor = new Competitor(name);
            competitorList.Add(competitor);
            return competitor;
        }
    }
}