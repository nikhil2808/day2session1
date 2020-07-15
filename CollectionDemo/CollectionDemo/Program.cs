using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile M1 = new Mobile();

            MobileCatalog catalog = new MobileCatalog();
            catalog.Add(new Mobile(1654, "iphone", "11pro", 67000, "available in black and grey colors"));
            catalog.Add(new Mobile(1655, "one plus", "7pro", 51000, "available in black, red and blue colors"));

            var m = catalog.GetMobile(1655);
            m.Display();
            Console.ReadLine();
        }
    }
}