using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_List_of_folders
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\79113\Desktop\Автоматизация BIM проектирования";
            string[] folders = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string folder in folders)
            {
                string[] folders2 = Directory.GetDirectories(folder);
                string[] files2 = Directory.GetFiles(folder);
                foreach (string folder2 in folders2)
                    Console.WriteLine(folder2.Remove(0, path.Length));
                foreach (string file in files2)
                    Console.WriteLine(file.Remove(0, path.Length));
            }
            foreach (string file in files)
                Console.WriteLine(file.Remove(0, path.Length));
            Console.ReadKey();
        }
    }
}
