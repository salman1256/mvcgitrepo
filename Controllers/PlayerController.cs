using Microsoft.AspNetCore.Mvc;
using WebAPPMCGit.Models;

namespace WebAPPMCGit.Controllers
{
    public class PlayerController : Controller
    {
        List<Player> _players = new List<Player>()
        {
            new Player(){Id=1,Name="MSD",Role="WicketKeeper/Batsman",Team="CSK"},
            new Player(){Id=2,Name="V.Kohli",Role="Batsman",Team="RCB"},
            new Player(){Id=3,Name="M.Siraj",Role="Bowler",Team="RCB"},
            new Player(){Id=4,Name="Rohit Sharma",Role="Batsman",Team="MI"}
        };
        public IActionResult Index()
        {
            return View(_players);
        }
    }
}
