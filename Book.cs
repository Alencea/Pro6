using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryKioskSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Publiser { get; set; }

        public void Print(string Title, string Author, int Pages, string Publisher) => Console.WriteLine(Title + ", " + Author + ", " + Pages + ", " + Publisher);
    }

    
}
