using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_RandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int sum = 0;
            int[] array = new int[n];
            string path = "RandSum.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(random.Next(0,100));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < n; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
