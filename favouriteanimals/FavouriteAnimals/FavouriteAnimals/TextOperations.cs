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
        public static List<string> ReadText(string path)
        {
            var lines = new List<string>();
            using (StreamReader file = new StreamReader(path))
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
            foreach (var line in ReadText("favourites.txt"))
            {
                Console.Write("[{0}] ",line);
            }
        }
    }
}
