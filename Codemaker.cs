using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_game
{
    class Codemaker
    {
        string[] colours = new string[8] { "Red","Green","Yellow","White","Orange","Blue","Black","Pink"};
        string[] code = new string[4];
        string[] key = new string[3] { "Red", "White", "Black" };
        string[] key_peg = new string[4];
        public string [] Random_code_maker()
        {
            Random r = new Random();
            for (int i = 0; i < code.Length; i++)
            {
                int temp = r.Next(colours.Length);
                code[i] = colours[temp];
            }
            return code;
        }
        public string[] Put_key_peg(string [] array)
        {
            
            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (code[i] == array[j])
                    {
                        if (i == j)
                        {
                            key_peg[i] = "Red";
                            break;
                        }
                        else
                        {
                            key_peg[i] = "White";
                            break;
                        }
                    }
                    else
                    {
                        key_peg[i] = "Black";

                    }
                    temp++;

                }
               
            }
            string[] val=new string[4];
            int l=0;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < key_peg.Length; j++)
                {
                    if (key[i]==key_peg[j])
                    {
                        val[l] = key_peg[j];
                        l++;
                    }
                   
                }
            }
            return val;
        }
    }
}
