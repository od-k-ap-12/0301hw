using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("name", "address", "type");
            Play play = new Play("name", "author", "genre", 2023);
            shop.Print();
            play.Print();
            shop.Dispose();
            play.Dispose();
            GC.Collect(0, GCCollectionMode.Forced);
        }
    }
}
