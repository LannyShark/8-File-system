using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_Text_stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Text.txt";
            string text = File.ReadAllText(path);
            string[] words = File.ReadAllText(path).Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            string[] lines = File.ReadAllLines(path);
            int countChars, countWords, countLines;
            countChars = text.Length;
            countWords = words.Length;
            countLines = lines.Length;
            Console.WriteLine("{0},{1},{2}", countChars, countWords, countLines);
            Console.ReadKey();
        }
    }
}
