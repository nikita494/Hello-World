using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1{
    class Program{
 public static void Main(string[] args){
            string input;
            input = Console.ReadLine();
List<int> indexes = StringWorker.FindAllIndexes(" ",input) ;
                indexes.Insert(0, 0);
               if (input.IndexOf(" ", StringComparison.OrdinalIgnoreCase) != -1) 
             Console.WriteLine("Индекс(ы) пробела(ов) ");
            indexes.ForEach(Console.WriteLine);
            Console.WriteLine(StringWorker.ReverseWordsInString(input));
            Console.ReadLine();
           }}}