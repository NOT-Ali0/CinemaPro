using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Movie
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }


            

        


        


        
    }
    class MovList : Movie{

        public List<Movie> Mov = new List<Movie>()
        {
             new Movie{Name= "the punisher",Title="the gay can kill any one ",Year=2007 },
            new Movie{Name= " punisher",Title="the gay can kill any one ",Year=2007 },
            new Movie{Name= "the ",Title="the gay can kill any one ",Year=2007 },
            new Movie{Name= "the punisher",Title="the gay can kill any one ",Year=2007 },
            new Movie{Name= "tasfa",Title="the gay can kill any one ",Year=2007 },
            new Movie{Name= "the punisher",Title="the gay can kill any one ",Year=2007 },


        };
        public void Display()
        {
            foreach ( var m in Mov)
            {
                Console.WriteLine($"{m.Name}-{m.Title}-{m.Year}");
            }
        }
    }
}


