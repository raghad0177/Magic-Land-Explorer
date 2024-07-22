using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Category
    {
        //Define properties for CategoryName and a list of Destination objects.
        public  string category { get; set; }
        public  List<Destination> destinations { get; set; }

    }
}
