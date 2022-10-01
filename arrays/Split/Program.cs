using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hi my name is Zheka";
            string[] words = phrase.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
