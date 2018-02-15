using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{
  public class RockPaperScissor
  {
    private int _playerOneScore;
    private int _playerTwoScore;
    private string _result;

    public void SetPlayerOneScore(int newScore)
    {
      _playerOneScore += newScore;
    }
    public void SetPlayerTwoScore(int newScore)
    {
      _playerTwoScore += newScore;
    }
    public int GetPlayerOneScore()
    {
      return _playerOneScore;
    }
    public int GetPlayerTwoScore()
    {
      return _playerTwoScore;
    }
    public string GetResult()
    {
      return _result;
    }
    public string PlayerOneRock(string PlayerTwoChoice)
    {
      if (PlayerTwoChoice == "Rock")
      {
        _result = "Draw";
      } else if(PlayerTwoChoice == "Paper")
      {
        SetPlayerTwoScore(1);
        _result = "Player Two Wins";
      } else{
        SetPlayerOneScore(1);
        _result = "Player One Wins";
      }
      return _result;
    }
    public string PlayerOnePaper(string PlayerTwoChoice)
    {
      if (PlayerTwoChoice == "Paper")
      {
        _result = "Draw";
      } else if(PlayerTwoChoice == "Scissors")
        {
        SetPlayerTwoScore(1);
        _result = "Player Two Wins";
      } else {
        SetPlayerOneScore(1);
        _result = "Player One Wins";
      }
      return _result;
    }
    public string PlayerOneScissor(string PlayerTwoChoice)
    {
      if (PlayerTwoChoice == "Scissors")
    {
      _result = "Draw";
    } else if(PlayerTwoChoice == "Rock")
    {
      SetPlayerTwoScore(1);
      _result = "Player Tw0 wins";
    } else {
      SetPlayerOneScore(1);
      _result = "player one wins";
      }
      return _result;
    }
  }
}
