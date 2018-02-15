using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Models.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void PlayerOneRock_PlayerOneWins_False()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOneRock("Paper");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);
  }
  [TestMethod]
    public void PlayerOneRock_PlayerOneWins_True()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOneRock("Scissors");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);

    }

    [TestMethod]
    public void PlayerOnePaper_PlayerOneWins_True()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOnePaper("Rock");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);
    }

    [TestMethod]
    public void PlayerOnePaper_PlayerOneWins_False()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOnePaper("Scissors");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);
    }

    [TestMethod]
    public void PlayerOneScissors_PlayerOneWins_True()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOneScissor("Paper");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);
    }

    [TestMethod]
    public void PlayerOneScissors_PlayerOneWins_False()
    {
      RockPaperScissor newGame = new RockPaperScissor();
      newGame.PlayerOneScissor("Rock");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);
    }
  }
}
