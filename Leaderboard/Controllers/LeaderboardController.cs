using Leaderboard.Entities;
using Leaderboard.Models;
using System.Web.Mvc;

namespace Leaderboard.Controllers
{
    public class LeaderboardController : Controller
    {
        private static LeaderboardModel model = new LeaderboardModel();

        public ActionResult Index()
        {
            ViewBag.Title = "Leaderboard";
            return View(model.GetLeaderboardItems());
        }

        [HttpPost]
        public ActionResult Competitor()
        {
            return View(new Competitor());
        }

        [HttpPost]
        public ActionResult AddCompetitor(Competitor competitor)
        {
            model.AddCompetitor(competitor);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult HeadToHead()
        {
            return View(
                "HeadToHead", 
                new HeadtoHeadModel(model.GetCompetitors()));
        }

        [HttpPost]
        public ActionResult AddHeadToHead(HeadtoHeadModel m)
        {
            m.Competitors = model.GetCompetitors();
            model.AddHeadToHead(m.CreateHeadToHead());
            return RedirectToAction("Index");
        }
    }
}
