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


        public Dictionary<string,string> MovDick = new Dictionary<string,string>();
        public MovList() {

            Random rand = new Random();
            var randHours = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours1 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours2 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours3 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours4 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours5 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours6 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours7 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours8 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours9 = DateTime.Now.AddHours(rand.Next(1, 10));


            MovDick.Add($"1. The Dark Knight                {randHours}", "Genre: Action / Crime\r\n\r\nDescription: Batman faces his greatest challenge when the Joker brings chaos and fear to Gotham City.\r\n\r\nRelease Year: 2008");
            MovDick.Add($"2. Inception                      {randHours1}", "Genre: Sci-Fi / Thriller\r\n\r\nDescription: A skilled thief enters people’s dreams to steal secrets, but his latest mission is to plant an idea instead.\r\n\r\nRelease Year: 2010 ");
            MovDick.Add($"3. Interstellar                   {randHours2}", "Genre: Sci-Fi / Adventure\r\n\r\nDescription: A group of astronauts travels through a wormhole in search of a new home for humanity.\r\n\r\nRelease Year: 2014 ");
            MovDick.Add($"4. The Matrix                     {randHours3}", "Genre: Sci-Fi / Action\r\n\r\nDescription: A hacker discovers that the world he lives in is a simulation created by intelligent machines.\r\n\r\nRelease Year: 1999 ");
            MovDick.Add($"5. John Wick                      {randHours4}", "Genre: Action / Thriller\r\n\r\nDescription: A retired hitman seeks vengeance after a group of gangsters kills his dog, the last gift from his wife.\r\n\r\nRelease Year: 2014 ");
            MovDick.Add($"6. Avengers: Endgame              {randHours5}", "Genre: Action / Superhero\r\n\r\nDescription: The Avengers assemble once more in a final stand against Thanos to restore balance to the universe.\r\n\r\nRelease Year: 2019 ");
            MovDick.Add($"7. The Shawshank Redemption       {randHours6}", "Genre: Drama\r\n\r\nDescription: A man wrongly imprisoned for murder forms a friendship that gives him hope and a chance at freedom.\r\n\r\nRelease Year: 1994 ");
            MovDick.Add($"8. Gladiator                      {randHours7}", "Genre: Action / Historical Drama\r\n\r\nDescription: A betrayed Roman general fights his way back to honor through the gladiatorial arena.\r\n\r\nRelease Year: 2000 ");
            MovDick.Add($"9. The Wolf of Wall Street        {randHours8}", "Genre: Biography / Comedy / Drama\r\n\r\nDescription: The true story of a stockbroker who rises to wealth through corruption and fraud on Wall Street.\r\n\r\nRelease Year: 2013 ");
            MovDick.Add($"10. Joker                         {randHours9}", "Genre: Drama / Thriller\r\n\r\nDescription: A lonely man struggling with mental illness transforms into the infamous villain, Joker.\r\n\r\nRelease Year: 2019 ");











            //Movies = new List<MovieComp>();

            //Movies.Add(new MovieComp { Name = $"1. The Dark Knight    {randHours}", Title = "Genre: Action / Crime\r\n\r\nDescription: Batman faces his greatest challenge when the Joker brings chaos and fear to Gotham City.\r\n\r\nRelease Year: 2008", Year = 2008 });
            //Movies.Add(new MovieComp { Name = $"2. Inception     {randHours1}", Title = "Genre: Sci-Fi / Thriller\r\n\r\nDescription: A skilled thief enters people’s dreams to steal secrets, but his latest mission is to plant an idea instead.\r\n\r\nRelease Year: 2010 ", Year = 2010 });
            //Movies.Add(new MovieComp { Name = $"3. Interstellar     {randHours2}", Title = "Genre: Sci-Fi / Adventure\r\n\r\nDescription: A group of astronauts travels through a wormhole in search of a new home for humanity.\r\n\r\nRelease Year: 2014 ", Year = 2014 });
            //Movies.Add(new MovieComp { Name = $"4. The Matrix     {randHours3}", Title = "Genre: Sci-Fi / Action\r\n\r\nDescription: A hacker discovers that the world he lives in is a simulation created by intelligent machines.\r\n\r\nRelease Year: 1999 ", Year = 1999 });
            //Movies.Add(new MovieComp { Name = $"5. John Wick     {randHours4}", Title = "Genre: Action / Thriller\r\n\r\nDescription: A retired hitman seeks vengeance after a group of gangsters kills his dog, the last gift from his wife.\r\n\r\nRelease Year: 2014 ", Year = 2014 });
            //Movies.Add(new MovieComp { Name = $"6. Avengers: Endgame     {randHours5}", Title = "Genre: Action / Superhero\r\n\r\nDescription: The Avengers assemble once more in a final stand against Thanos to restore balance to the universe.\r\n\r\nRelease Year: 2019 ", Year = 2019 });
            //Movies.Add(new MovieComp { Name = $"7. The Shawshank Redemption     {randHours6}", Title = "Genre: Drama\r\n\r\nDescription: A man wrongly imprisoned for murder forms a friendship that gives him hope and a chance at freedom.\r\n\r\nRelease Year: 1994 ", Year = 1994 });
            //Movies.Add(new MovieComp { Name = $"8. Gladiator     {randHours7}", Title = "Genre: Action / Historical Drama\r\n\r\nDescription: A betrayed Roman general fights his way back to honor through the gladiatorial arena.\r\n\r\nRelease Year: 2000 ", Year = 2000 });
            //Movies.Add(new MovieComp { Name = $"9. The Wolf of Wall Street     {randHours8}", Title = "Genre: Biography / Comedy / Drama\r\n\r\nDescription: The true story of a stockbroker who rises to wealth through corruption and fraud on Wall Street.\r\n\r\nRelease Year: 2013 ", Year = 2013 });
            //Movies.Add(new MovieComp { Name = $"10. Joker     {randHours9}", Title = "Genre: Drama / Thriller\r\n\r\nDescription: A lonely man struggling with mental illness transforms into the infamous villain, Joker.\r\n\r\nRelease Year: 2019 ", Year = 2019 });




        }


        public void Display()
        {

            foreach (var Mov in MovDick)
            {
                Console.WriteLine($"{Mov.Key}");

            }
        }
    }
}


