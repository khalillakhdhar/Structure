using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure.Adapter;
namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(1, "toshiba", 2100, "gaming laptop");
            Product p2 = new Product();
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
           // Console.WriteLine(p);
            Console.WriteLine(p2.Serialize(p));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
