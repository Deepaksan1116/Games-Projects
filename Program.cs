using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Codemaker cm = new Codemaker();
            string[] code = cm.Random_code_maker();
            //foreach (string items in code)
            //{
            //    Console.WriteLine(items);
            //}
            string[] input = new string[4] { "Black","White","Red","Green"};
            string [] output = cm.Put_key_peg(input);
            foreach (string item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
