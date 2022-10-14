using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind_game
{
    class MastermindBoard
    {
        string[,] board = new string[10, 4];
        string[,] keypegsboard = new string[10, 4];
        int size = 0;
        int player1score=10;
        int player2score=0;

        public int Player1score { get { return player1score; } }

        public int Player2score { get { return player2score; } }

        public void mark(string[] usercolorpegs, string[] keypegs)
        {
            for (int i = 0; i < 4; i++)
            {
                board[size, i] = usercolorpegs[i];
                keypegsboard[size, i] = keypegs[i];
            }
            size++;
        }
        public string Printboard(string[] code)
        {
            string print = "";
            //for (int i = 0; i < code.Length; i++)
            //{
            //    print += code[i] + "\t";
            //}
            print += "\n";
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    print += board[i,j] + "\t";
                }
                print += "\n";
                
                for (int k = 0; k <4; k++)
                {
                    
                    print += keypegsboard[i,k] + "\t";
                    
                }
                print += "\n";
                print += "\n";
            }
            return print;
        }
        public void score(bool val)
        {
            if (val)
            {
                player1score--;
            }
            else
            {
                player2score++;
            }
        }
        public string final(string[] code)
        {
            string print = "";
            for (int i = 0; i < code.Length; i++)
            {
                print += code[i] + "\t";
            }
            return print;
        }
    }
}
