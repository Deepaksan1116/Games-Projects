using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind_game
{
    class Codemaker
    {
        string[] colours = new string[8] { "Red", "Green", "Yellow", "White", "Orange", "Blue", "Black", "Pink" };
      public static string[] code = new string[4] { "White","Orange","Black","Red"};
        string[] key = new string[3] { "red", "white", "black" };
        
        public string[] Random_code_maker()
        {
            Random r = new Random();
            for (int i = 0; i < code.Length; i++)
            {
                int temp = r.Next(colours.Length);
                code[i] = colours[temp];
            }
            return code;
        }
      
        public bool winningstate(string[] array)
        {
            bool check = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==key[0])
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
        public string[] Put_key_pegs(string[] array)
        {
            string[] key_peg = new string[4];
            string[] distinctpegs = distinctelement(code);
            int redcount = Sameindex(distinctpegs, array);
            int whitecount = NotSameindex(distinctpegs, array);
            for (int i = 0; i < redcount; i++)
            {
                key_peg[i] = "red";
            }
            for (int i = redcount; i < redcount+whitecount; i++)
            {
                key_peg[i] = "white";
            }
            //int temp = 0;
            //int count = 0;
            //for (int i = 0; i < 4; i++)
            //{

            //    //int m = i;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (code[j] == array[i])
            //        {
            //            if (i == j)
            //            {
            //                //key_peg[i] = "Red";
            //                count++;
            //                //break;
            //            }
            //            else if (i != j&&i<=j )
            //            {

            //                temp++;

            //            }
            //        }




            //    }
            //    //if (temp>=1&&count==0)
            //    //{
            //    //    key_peg[i] = "White";
            //    //}


            //}
            //for (int i = 0; i < count; i++)
            //{
            //    key_peg[i] = "Red";
            //}
            //for (int i = count; i < temp; i++)
            //{
            //    key_peg[i] = "White";
            //}
            for (int i = 0; i < key_peg.Length; i++)
            {
                if (string.IsNullOrEmpty(key_peg[i]))
                {
                    key_peg[i] = "black";
                }
            }
            //string[] val = new string[4];
            //int l = 0;
            //for (int i = 0; i < key.Length; i++)
            //{
            //    for (int j = 0; j < key_peg.Length; j++)
            //    {
            //        if (key[i] == key_peg[j])
            //        {
            //            val[l] = key_peg[j];
            //            l++;
            //        }

            //    }
            //}
            //return val;
            return key_peg;
        }
        public int distinctcount(string[] code)
        {
            int count = 0;
            for (int i = 0; i < code.Length; i++)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code[i]==code[j])
                    {
                        if (i == j)
                        {
                            count++;
                        }
                        break;

                    }
                   
                }
               
            }
            return count;
        }
        public string[] distinctelement(string[] code)
        {
           int size= distinctcount(code);
            string[] distinctarray = new string[size];
            int length = 0;
            for (int i = 0; i < code.Length; i++)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code[i] == code[j])
                    {
                        if (i == j)
                        {
                            distinctarray[length] = code[i];
                        }
                        break;

                    }
                   
                    
                }
                length++;
            }
            return distinctarray;
        }
        public int Sameindex(string[] distinct,string[] array)
        {
            int same = 0;
            for (int i = 0; i < distinct.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (distinct[i]==array[j])
                    {
                        if (i==j)
                        {
                            same++;
                        }
                    }
                }
            }
            return same;
        }
        public int NotSameindex(string[] distinct, string[] array)
        {
            int same = 0;
            for (int i = 0; i < distinct.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (distinct[i] == array[j])
                    {
                        if (i != j)
                        {
                            same++;
                        }
                    }
                }
            }
            return same;
        }
    }
}
