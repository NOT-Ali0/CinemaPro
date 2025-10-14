using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class MovieComp
    {

        public string Name { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        
    }
    class MovList  {

        public List<MovieComp> Movies { get; set; }
        public MovList() {

            Random rand = new Random();
            var randHours = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours1 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours2 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours3 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours4 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours5 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours6 = DateTime.Now.AddHours(rand.Next(1,10));

            Movies = new List<MovieComp>();

            Movies.Add(new MovieComp { Name = $"[1] the punisher {randHours}", Title = "  the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[2] the punisher {randHours1}", Title = "  the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[3] punisher {randHours2}", Title = "   the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[4] the {randHours3}", Title = "   the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[5] the punisher {randHours4}", Title = "   the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[6] tasfa {randHours5}", Title = "   the gay can kill any one ", Year = 2007 });
            Movies.Add(new MovieComp { Name = $"[7] the punisher {randHours6}", Title = "   the gay can kill any one ", Year = 2007 });
                

            
        }
          
        
        public void Display()
        {
            
            foreach(var Mov in Movies)
            {
                Console.WriteLine($"{Mov.Name}");
            }
        }
    }
}


