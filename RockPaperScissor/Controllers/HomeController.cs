using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      return View(newGame);
    }


  [HttpPost("/gameResult")]
    public ActionResult GameResult()
    {
      string POChoice = Request.Form["PlayerOne"];
      string PTChoice = Request.Form["PlayerTwo"];
      RockPaperScissor newGame = new RockPaperScissor();
      if (POChoice == "Rock"){
        newGame.PlayerOneRock(PTChoice);
      } else if (POChoice == "Paper"){
        newGame.PlayerOnePaper(PTChoice);
      } else if (POChoice == "Scissors"){
        newGame.PlayerOneScissor(PTChoice);
      }

      return View("Index", newGame);
    }
  }
}
