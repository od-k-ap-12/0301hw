using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301hw
{
    class Play:IDisposable
    {
        public string name { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public Play(string _name,string _author,string _genre, int _year)
        {
            name = _name;
            author = _author;
            genre = _genre;
            year = _year;
        }
        public override string ToString()
        {
            return "Name: "+name+"\nAuthor: "+author+"\nGenre: "+genre+"\nYear: "+year;
        }
        public void Print()
        {
            Console.WriteLine("Name: " + name + "\nAuthor: " + author + "\nGenre: " + genre + "\nYear: " + year);
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose method call");
        }
        ~Play()
        {
            Console.WriteLine("Destructor call");
        }
    }
}
