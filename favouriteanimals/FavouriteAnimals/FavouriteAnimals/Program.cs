using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                TextOperations.AddNewAnimal(args);
            }
            else
            {
                TextOperations.PrintLines();
            }
        }    
    }
}
