using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(IFormCollection madlibWords)
    {
      MadLibData data = new MadLibData(madlibWords);
      return View(data);
    }
  }
}