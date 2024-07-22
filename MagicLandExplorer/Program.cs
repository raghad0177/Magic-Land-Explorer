using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DelegateInvoker();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }











        }
        public delegate void delegateTemplate(List<Category> anyInput);
        public static void DelegateInvoker()
        {
            delegateTemplate Delegate = FilterDestinations.filterDestinations;
            Delegate += LongestDuration.filterlongestDestinations;
            Delegate += SortByName.fillterByName;
            Delegate += Top3Duration.threelongestDestinations;
            string filepath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filepath);
            var data = JsonConvert.DeserializeObject<List<Category>>(json);
            Delegate(data);
        }
    }
}
