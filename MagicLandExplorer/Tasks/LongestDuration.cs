using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        //Write a LINQ query to find and display name of the destination with the longest duration among all categories.
        public static void filterlongestDestinations(List<Category> filedata)
        {
            int munite = 0;
            // Select all the data 
            var result = (from data in filedata
                             // Select the destinations inside the data
                         from destination in data.destinations
                         // If the duration inside the distination is not null and less than 100
                         where  destination.duration != null
                          // Parse the string result to int after the first space 
                          orderby int.Parse(destination.duration.Split(' ')[0]) descending
                         // Then give me the name inside the distination 
                          select destination.name).FirstOrDefault();
                          Console.WriteLine("\n\n2.Longest Destination Name : ");
                          Console.WriteLine(result);       
        }
    }
}
