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
    public class MovieComp
    {

        public string Name { get; set; }
        public DateTime date { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }

        
    }

    public class MovList  {


        public Dictionary<int, MovieComp> MovDick = new Dictionary<int, MovieComp>();
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
            var randHours10 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours11 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours12 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours13 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours14 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours15 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours16 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours17 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours18 = DateTime.Now.AddHours(rand.Next(1, 10));
            var randHours19 = DateTime.Now.AddHours(rand.Next(1, 10));



            MovDick.Add(1, new MovieComp {Name= $"The Dark Knight              ",date=randHours,Title= "Genre: Action / Crime\r\n\r\nDescription: Batman faces his greatest challenge when the Joker brings chaos and fear to Gotham City.\r\n\r\nRelease Year: 2008\n\n " });
            MovDick.Add(2,new MovieComp {Name= $"Inception                    ",date=randHours1, Title= "Genre: Sci-Fi / Thriller\r\n\r\nDescription: A skilled thief enters people’s dreams to steal secrets, but his latest mission is to plant an idea instead.\r\n\r\nRelease Year: 2010\n\n  " });
            MovDick.Add(3,new MovieComp { Name = $"Interstellar                 ",date=randHours2, Title = "Genre: Sci-Fi / Adventure\r\n\r\nDescription: A group of astronauts travels through a wormhole in search of a new home for humanity.\r\n\r\nRelease Year: 2014 \n\n " });
            MovDick.Add(4,new MovieComp { Name = $"The Matrix                   ",date=randHours3, Title= "Genre: Sci-Fi / Action\r\n\r\nDescription: A hacker discovers that the world he lives in is a simulation created by intelligent machines.\r\n\r\nRelease Year: 1999\n\n  " });
            MovDick.Add(5,new MovieComp { Name = $"John Wick                    ",date=randHours4, Title= "Genre: Action / Thriller\r\n\r\nDescription: A retired hitman seeks vengeance after a group of gangsters kills his dog, the last gift from his wife.\r\n\r\nRelease Year: 2014\n\n  " });
            MovDick.Add(6,new MovieComp { Name = $"Avengers: Endgame            ",date=randHours5, Title= "Genre: Action / Superhero\r\n\r\nDescription: The Avengers assemble once more in a final stand against Thanos to restore balance to the universe.\r\n\r\nRelease Year: 2019\n\n  " });
            MovDick.Add(7,new MovieComp { Name = $"The Shawshank Redemption     ",date=randHours6, Title= "Genre: Drama\r\n\r\nDescription: A man wrongly imprisoned for murder forms a friendship that gives him hope and a chance at freedom.\r\n\r\nRelease Year: 1994\n\n  " });
            MovDick.Add(8,new MovieComp { Name = $"Gladiator                    ",date=randHours7, Title= "Genre: Action / Historical Drama\r\n\r\nDescription: A betrayed Roman general fights his way back to honor through the gladiatorial arena.\r\n\r\nRelease Year: 2000\n\n  " });
            MovDick.Add(9,new MovieComp { Name = $"The Wolf of Wall Street      ",date=randHours8, Title= "Genre: Biography / Comedy / Drama\r\n\r\nDescription: The true story of a stockbroker who rises to wealth through corruption and fraud on Wall Street.\r\n\r\nRelease Year: 2013\n\n  " });
            MovDick.Add(10,new MovieComp { Name = $"Dune: Part Two              ",date=randHours9, Title= "Epic sci-fi adventure continuing Paul Atreides’ story as he unites the Fremen against House Harkonnen.\r\n\r\nReleased: March 1, 2024\n\n " });
            MovDick.Add(11,new MovieComp { Name = $"Oppenheimer                 ",date=randHours10, Title= "Historical drama about J. Robert Oppenheimer and the creation of the atomic bomb, directed by Christopher Nolan.\r\n\r\nReleased: July 21, 2023\n\n  " });
            MovDick.Add(12,new MovieComp { Name = $"John Wick: Chapter 4        ",date=randHours11, Title= "John Wick faces new challenges as the bounty on his head grows — action-packed and visually stunning.\r\n\r\nReleased: March 24, 2023\n\n  " });
            MovDick.Add(13,new MovieComp { Name = $"The Batman                  ",date=randHours12, Title= "A darker, detective-style take on Gotham’s vigilante, starring Robert Pattinson.\r\n\r\nReleased: March 4, 2022\n\n  " });
            MovDick.Add(14,new MovieComp { Name = $"Avatar: The Way of Water    ",date=randHours13, Title= "The sequel to James Cameron’s epic, exploring Pandora’s oceans and new Na’vi clans.\r\n\r\nReleased: December 16, 2022\n\n  " });
            MovDick.Add(15,new MovieComp { Name = $"Mission: Impossible         ",date=randHours14, Title= "Ethan Hunt returns with a new impossible mission filled with espionage and breathtaking stunts.\r\nReleased: July 12, 2023\n\n  " });
            MovDick.Add(16,new MovieComp { Name = $"Top Gun: Maverick           ",date=randHours15, Title= "A legacy sequel where Maverick trains a new generation of pilots — full of emotion and adrenaline.\r\nReleased: May 27, 2022\n\n  " });
            MovDick.Add(17,new MovieComp { Name = $"Damsel                      ",date=randHours16, Title= "A dark fantasy adventure about a young woman who discovers she’s been chosen as a sacrifice to a dragon.\r\n\r\nReleased: March 8, 2024\n\n  " });
            MovDick.Add(18,new MovieComp { Name = $"Inside Out 2                ",date=randHours17, Title= "Pixar’s emotional sequel introducing new emotions as Riley becomes a teenager.\r\n\r\nReleased: June 14, 2024\n\n  " });
            MovDick.Add(19,new MovieComp { Name = $"Deadpool & Wolverine        ",date=randHours18, Title= "The chaotic team-up of Deadpool and Wolverine in the Marvel multiverse — full of humor and action.\r\n\r\nReleased: July 26, 2024\n\n  " });
            MovDick.Add(20,new MovieComp { Name = $"Joker                       ",date=randHours19, Title="Genre: Drama / Thriller\r\n\r\nDescription: A lonely man struggling with mental illness transforms into the infamous villain, Joker.\r\n\r\nRelease Year: 2019\n\n "});








            List<string> SeatsList = new List<string>()
            {
                "A1","A2","A3","A4","A5","A6","A7","A8",
                "B1","B2","B3","B4","B5","B6","B7","B8",
                "C1","C2","C3","C4","C5","C6","C7","C8",
                "D1","D2","D3","D4","D5","D6","D7","D8",
                "E1","E2","E3","E4","E5","E6","E7","E8",
                "F1","F2","F3","F4","F5","F6","F7","F8",
            };







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
            Console.WriteLine("Movies List\n\n");
            foreach (var Mov in MovDick)
            {

                Console.WriteLine($"{Mov.Key}.{Mov.Value.Name}                {Mov.Value.date}");

            }
        }
    }
    public class SeatShowAndPrace {
        
        public void Display() {

            string seatingMap = @"
╔════════════════════════════════════════════════════════╗
║                 CINEMA SEATING MAP                      ║
╠════════════════════════════════════════════════════════╣
║  Screen:  ───────────────────────────────────────      ║
║                                                        ║
║   Seats legend: [ ] = Available    [X] = Booked        ║
║                                                        ║
║   Row A  1   2   3   4   5   6   7   8                      ║
║         [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]                  ║
║   Row B  1   2   3   4   5   6   7   8                        ║
║         [ ] [ ] [ ] [ ] [X] [ ] [ ] [ ]                  ║
║   Row C  1   2   3   4   5   6   7   8                      ║
║         [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]                  ║
║   Row D  1   2   3   4   5   6   7   8                        ║
║         [ ] [X] [ ] [ ] [ ] [ ] [ ] [ ]                  ║
║   Row E  1   2   3   4   5   6   7   8                      ║
║         [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]                  ║
║   Row F  1   2   3   4   5   6   7   8                        ║
║         [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]                  ║
║                                                        ║    ║
╚════════════════════════════════════════════════════════╝
";
            Console.WriteLine(seatingMap);

        }
        public SeatShowAndPrace() {


        }
    }
}


