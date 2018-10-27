using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class StringWorker
    {


        public static List<int> FindAllIndexes(string a, string z)
        {
            int x = 0, i = z.IndexOf(a, x, StringComparison.OrdinalIgnoreCase);
            List<int> indexes = new List<int>();
            while (i != -1)
            {
                indexes.Add(i);
                x = i + 1;
                i = z.IndexOf(a, x, StringComparison.OrdinalIgnoreCase);
            }
            return indexes;

        }
        public static string ReverseWordsInString(string input)
        {
            string[] answerArray = Regex.Split(input, @"(\s+)", RegexOptions.ExplicitCapture);
            Array.Reverse(answerArray);
             return String.Join(" ", answerArray);

        }
        

    }
}
