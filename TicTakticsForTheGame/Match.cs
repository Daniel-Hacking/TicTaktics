using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakticsForTheGame
{
    internal class Match
    {
        private int matchId;
        private Player player1;
        private Player player2;
        private int moves;
        private string winner;
        private char[] board = new char[9];

        public Match () { }

        public Match (Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
        public int Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public bool gameWon()
        {
            if (board[0] != '\0' && board[0] == board[4] && board[0] == board[8])
            {
                return true;
            }
            else if (board[2] != '\0' && board[2] == board[4] && board[2] == board[6])
            {
                return true;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i * 3] != '\0' && board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 1])
                    {
                        return true;
                    }
                    else if (board[i * 3] != '\0' && board[i] == board[i + 3] && board[i] == board[i + 6])
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        public bool tiedGame()
        {
            if (moves >= 9 && !gameWon())
            {
                return true;
            }
            return false;
        }
    }
}
