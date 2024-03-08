using System;
using RPSGameItem;
using RPSGameStatus;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameStatus result = (GameStatus) Enum.Parse(typeof(GameStatus), RockPaperScissors(args[0], args[1]));

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static string RockPaperScissors(string player1, string player2)
        {
            GameItem ItemPlayer1 = (GameItem) Enum.Parse(typeof(GameItem), player1);
            GameItem ItemPlayer2 = (GameItem) Enum.Parse(typeof(GameItem), player2);
            int PlayerMove = (int)ItemPlayer1 >> 1;

            string result = "none";

            if (ItemPlayer1 == ItemPlayer2)
            {
                result = "Draw"; // Draw
            }
            else if ((PlayerMove == ((int)ItemPlayer2)) || ((PlayerMove == 0) && ((int)ItemPlayer2 == (int)GameItem.Scissors)))
            {
                result = "Player1Wins"; // Player 1 wins
            }
            else
            {
                result = "Player2Wins"; // Player 2 wins
            }
            return result;
        }
    }
}
