using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Input: string – sentence consisting of words separated by spaces
// output: string – output the sentence with the words in reverse order

namespace reverserwords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sentence");
            String data =  Console.ReadLine();
            Console.WriteLine(data);

            reverseorder.reverserword(data);
        }
    }
    public class reverseorder
    {
       

        public static void reverserword(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = s.Split(' ');

            for(int i = words.Length -1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }
           
            Console.WriteLine(sb);
        }
    }
}
