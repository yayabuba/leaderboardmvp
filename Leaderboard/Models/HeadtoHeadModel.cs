using Leaderboard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Leaderboard.Models
{
    public class HeadtoHeadModel
    {
        List<Competitor> competitors = new List<Competitor>();

        public HeadtoHeadModel()
        {
            SelectedRound = "Round1";
            SelectedCompetitor1 = "Footscray";
            SelectedCompetitor2 = "Richmond";
            SelectedCompetitor1Points = "0";
            SelectedCompetitor2Points = "0";
        }

        public HeadtoHeadModel(List<Competitor> competitors) 
            : this()
        {
            this.competitors = competitors;
        }

        public List<Competitor> Competitors
        {
            get { return this.competitors; }
            set { this.competitors = value; }
        }

        public string SelectedRound { get; set; }

        public SelectList RoundSelectList
        {
            get { return new SelectList(Enum.GetValues(typeof(Round))); }
        }

        public SelectList CompetitorSelectList
        {
            get { return new SelectList(competitors, "Name", "Name"); }
        }

        public string SelectedCompetitor1 { get; set; }

        public string SelectedCompetitor2 { get; set; }

        public string SelectedCompetitor1Points { get; set; }

        public string SelectedCompetitor2Points { get; set; }

        public SelectList ValidPoints
        {
            get { return new SelectList(new List<int>() { 0, 2, 4 }); }
        }

        public HeadToHead CreateHeadToHead()
        {
            return new HeadToHead(
                Str2Round(SelectedRound),
                Str2Competitor(SelectedCompetitor1),
                Str2Competitor(SelectedCompetitor2),
                Int32.Parse(SelectedCompetitor1Points),
                Int32.Parse(SelectedCompetitor2Points));
        }

        private Competitor Str2Competitor(string name)
        {
            return Competitors
                .Where(c => c.Str2Competitor(name) != null)
                .FirstOrDefault();
        }

        static private Round Str2Round(string round)
        {
            return (Round)Enum.Parse(typeof(Round), round);
        }
    }
}