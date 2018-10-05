using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Utility;
using Resources.Concrete;

namespace ResourceBuilder 
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Resources.Utility.ResourceBuilder();
            string filePath = builder.Create(new DbResourceProvider(@"Data Source=149.28.148.65,2020;Initial Catalog=BExchange_Old;MultipleActiveResultSets=True;Max Pool Size=50000;User ID=bcashico;Password=1m*Rvq7gv4%AxBfW;Connection Timeout=30;"),
                summaryCulture: "en-us");

            Console.WriteLine("Created file {0}", filePath);            

        }
    }
}
