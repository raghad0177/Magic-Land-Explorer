using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        public static void threelongestDestinations(List<Category> filedata)
        {
            var result = (from data in filedata
                              // Select the destinations inside the data
                          from destination in data.destinations
                              // If the duration inside the destination is not null
                          where destination.duration != null 
                          // Parse the string result to int after the first space
                          orderby(int.Parse(destination.duration.Split(' ')[0]))descending
                          // Order by duration in descending order
                          // Select the name inside the destination
                          select destination.name +" "+destination.duration).Take(3);

            Console.WriteLine("\n\n4. Three Longest Destination Names: ");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
    
}
