using Microsoft.AspNetCore.Mvc;
// using System.Web.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(FormCollection madlibWords)
    {
      //TODO: Model manipulation stuff from form
      return View();
    }
  }
}