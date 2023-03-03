using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301hw
{
    class Shop:IDisposable
    {
        public string name { get; set; }
        public string address { get; set; }
        public string type { get; set; }
        public Shop(string _name, string _address, string _type)
        {
            name = _name;
            address = _address;
            type = _type;
        }
        public override string ToString()
        {
            return "Name: " + name + "\nAddress: " + address + "\nType: " + type;
        }
        public void Print()
        {
            Console.WriteLine("Name: " + name + "\nAddress: " + address + "\nType: " + type);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose method call");
        }
        ~Shop()
        {
            Console.WriteLine("Destructor call");
        }
    }
}
