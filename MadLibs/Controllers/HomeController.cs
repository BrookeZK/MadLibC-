using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/MadLibLetter")]
    public ActionResult MadLibLetter(string noun1, string name, string location, string verb1, string number, string noun2, string adjective, string exclamation, string verb2)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun1(noun1);
      myMadLibVariable.Name(name);
      myMadLibVariable.Location(location);
      myMadLibVariable.Verb1(verb1);
      myMadLibVariable.Number(number);
      myMadLibVariable.Noun2(noun2);
      myMadLibVariable.Adjective(adjective);
      myMadLibVariable.Exclamation(exclamation);
      myMadLibVariable.Verb2(verb2);
      return View(myMadLibVariable);
    }

  }
}
