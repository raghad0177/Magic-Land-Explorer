using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        //Sort destinations alphabetically by their name.
        public static void fillterByName(List<Category> filedata)
        {
            var result = (from data in filedata
                          from destination in data.destinations                       
                          select destination.name).OrderBy(n => n);
            Console.WriteLine("\n\n3-Names Odrerd From A-Z\n");
            foreach (var category in result)
            {
                Console.WriteLine(category);
            }
        }
    }
}
