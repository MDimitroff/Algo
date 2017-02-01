using Algo.Web.Services;
using System.Text;
using System.Web.Mvc;

namespace Algo.Web.Controllers
{
    public class AlgoController : Controller
    {
        public ActionResult DFS()
        {
            var startFolder = HttpContext.Server.MapPath("~/Search");
            var traversedPaths = new StringBuilder();

            TraverseTree.DFS(startFolder, traversedPaths);

            ViewBag.Paths = traversedPaths.ToString();
            return View();
        }

        public ActionResult BFS()
        {
            var fullPath = HttpContext.Server.MapPath("~/Search");

            var traversedPaths = TraverseTree.BFS(fullPath);

            ViewBag.Paths = traversedPaths.ToString();    
            return View();
        }
    }
}