using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    public class TextOperations
    {
        public static string Path = "favourites.txt";

        public static List<string> ReadText()
        {
            var lines = new List<string>();
            using (StreamReader file = new StreamReader(Path))
            {
                string line = String.Empty;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        public static void PrintLines()
        {
            Console.Write("C# FavouriteAnimals: ");
            foreach (var line in ReadText())
            {
                Console.Write("[{0}] ",line);
            }
        }

        public static void AddNewAnimal(string[] args)
        {
            foreach (var arg in args)
            {
                using (StreamWriter file = new StreamWriter(Path, true))
                {
                    file.WriteLine(arg);
                }
            }
        }
    }
}
