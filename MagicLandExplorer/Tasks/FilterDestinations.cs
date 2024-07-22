using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        //Find all destinations name with a duration less than 100 minutes.
        public static void filterDestinations(List<Category> filedata)
        {
            // Select all the data 
            var result = from data in filedata
                             // Select the destinations inside the data
                         from destination in data.destinations
                             // If the duration inside the distination is not null and less than 100
                         where destination.duration != null &&
                         // Parse the string result to int after the first space 
                         int.TryParse(destination.duration.Split(' ')[0], out int munite) && munite < 100
                         // Then give me the name inside the distination 
                         select "\nName: " + destination.name + "\nDuration: " + destination.duration;
            // In Lamda Expression 
            //var result2 = filedata
            //             .SelectMany(data => data.destinations)
            //             .Where(destination => destination.duration != null &&
            //              int.TryParse(destination.duration.Split(' ')[0], out int munite) &&
            //              munite < 100)
            //              .Select(destination => "\nName: " + destination.name + "\nDuration: " + destination.duration);
            Console.WriteLine("1-Destinations less than 100 munit");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
