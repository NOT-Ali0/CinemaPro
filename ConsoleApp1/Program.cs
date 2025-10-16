using System;
using System.Security;

namespace ConsoleApp1 {

  
    class Person
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int PassWord { get; set; }


        public Person(string name, int password, string tilte)
        {

            Name = name;
            Title = tilte;
            PassWord = password;
        }

    }
    class Program {
        

        public void MenuShow() {

            Console.WriteLine("[1] Movies\n[2] Snacks & Drinks\n[3] Pay\n[4] End of the day\n[5] Exit\n\n (0) to quit");

        }
        public class CinemaHall {


            public List<string> SeatsList = new List<string>()
            {
                "A1","A2","A3","A4","A5","A6","A7","A8",
                "B1","B2","B3","B4","B6","B7","B8",
                "C1","C2","C3","C4","C5","C6","C7","C8",
                "D1","D3","D4","D5","D6","D7","D8",
                "E1","E2","E3","E4","E5","E6","E7","E8",
                "F1","F2","F3","F4","F5","F6","F7","F8",
            };
        } 


        static void Main(){
            bool IsRunning = true;
            bool IsRunning1 = true;
            bool IsRunning2 = true;
            bool IsRunning3 = true;

            var p = new Program();

            //quantity count
            int PricePerSeat = 10;
            
            MovList movlist = new MovList();
            //add user info

            Person user1 = new Person("Ali", 1976, "Cashier");
            Person user2 = new Person("mohammed", 21412, "sales");
            Person user3 = new Person("Raheem", 123546, "sales");
            Person user4 = new Person("haider", 19346776, "customerservice");

            //main minu
            Program menu = new Program();

            //seating
            SeatShowAndPrace seatObj = new SeatShowAndPrace();

            //list for seats
            CinemaHall hall = new CinemaHall();

            //Quantity
            List<string> quantList = new List<string>();

            while (IsRunning) {
                menu.MenuShow();
                Console.Write("Type your choice )> ");
                int? MinuUserInput = int.TryParse(Console.ReadLine(), out int num) ? num : null;
                if (MinuUserInput == 1)
                {
                    Console.Clear();
                    movlist.Display();
                    Console.Write("\n\nType your choice (0) To Quit )> ");
                    IsRunning1 = true;
                }
                while (IsRunning1) {
                    int? MovieSelect = int.TryParse(Console.ReadLine(), out num) ? num : null;
                    if (MovieSelect == 0)
                    {
                        Console.Clear();
                        IsRunning1 = false;
                        menu.MenuShow();
                    }

                    foreach (var m in movlist.MovDick)
                    {
                        if (MovieSelect == m.Key)
                        {

                            Console.Clear();
                            Console.WriteLine(m.Value.Title);
                            Console.WriteLine("\n\n(0) to quit");
                            Console.Write("Type [1] to the seatingMap )> ");
                            IsRunning2 = true;
                            IsRunning3 = true;
                            while (IsRunning2) {
                                int? SeatInput = int.TryParse(Console.ReadLine(), out num) ? num : null;
                                if (SeatInput == 1)
                                {
                                    Console.Clear();
                                    while (IsRunning3) {
                                        
                                        seatObj.Display();
                                        Console.WriteLine("(0) to quit");
                                        Console.Write("How many seats would you like to book: ");
                                        int? Quant = int.TryParse(Console.ReadLine(), out num) ? num : null;
                                        if (Quant == 0) { Console.Clear(); IsRunning3 = false; IsRunning2 = false; movlist.Display(); }
                                        else if (Quant > 46) { Console.Clear(); Console.WriteLine("You selected more seats than available. Please choose a smaller number!!!!! "); }

                                        else if (Quant >= 1 || Quant <= 45)
                                        {
                                            for (int i = 0; i < Quant; ++i)
                                            {
                                            here:
                                                Console.Write("Enter your Seats: ");
                                                var SeatSelecter = Console.ReadLine();
                                                var SeatUpper = SeatSelecter.ToUpper().Trim();
                                                
                                                if (hall.SeatsList.Contains(SeatUpper))
                                                {
                                                    quantList.Add(SeatUpper);

                                                }

                                                if (SeatUpper == "D2" || SeatUpper == "B5")
                                                {
                                                    Console.WriteLine($"The Seats ({SeatUpper}) unavailable");
                                                    goto here;

                                                }

                                                else if (!hall.SeatsList.Contains(SeatUpper)) {
                                                    Console.WriteLine($"Sorry the {SeatUpper} not found!! ");
                                                    goto here;
                                                }
                                                ;






                                            }
                                            double Price = Convert.ToDouble(PricePerSeat * Quant);
                                            string seat = string.Join(',', quantList);
                                            Console.WriteLine($@"
                                            ╔════════════════════════════════╗
                                            ║          TICKET / INVOICE      ║
                                            ╠════════════════════════════════╣
                                            ║ Movie : {m.Value.Name}         ║
                                            ║                                ║
                                            ║ Time  : {DateTime.Now}  ║
                                            ║ Showdat: {m.Value.date}║
                                            ╠════════════════════════════════╣
                                            ║ Selected Seats: {seat}           ║
                                            ║ per seat: {PricePerSeat + "$"}                  ║
                                            ║ Quantity: {Quant}                    ║
                                            ║ ------------------------------ ║
                                            ║ TOTAL: {Price + "$"}                     ║
                                            ╠════════════════════════════════╣
                                            ║   Thank you! Enjoy the show <3  ║
                                            ╚════════════════════════════════╝
                                            ");
                                            int? SeatOut = int.TryParse(Console.ReadLine(), out num) ? num : null;
                                            if (SeatOut == 0) { Console.Clear(); IsRunning1 = false; IsRunning2 = false; IsRunning3 = false; }



                                        }
                                        else { Console.Clear(); Console.WriteLine($"Invalid Input!! \n\n"); }



                                    }



                                }
                                else if (SeatInput == 0) { 
                                    IsRunning2 = false;
                                    IsRunning1 = false;
                                    Console.Clear();

                                   
                                }
                            }
                            //movlist.Display();
                            //Console.Write("Type (0) To Quit )> ");
                            //int? MovieExet = int.TryParse(Console.ReadLine(), out num) ? num : null;
                            //if (MovieExet == 0)
                            //{
                            //    Console.Clear();
                            //    movlist.Display();
                            //}
                        }
                        //else if (MovieSelect == 0) { IsRunning1 = false; }

                    }
                }
                
                    




                
                
                


                
            }
            













            //add food and prices info

            //Food f = new Food();
            //f.Dik.Add("Popcorn",12.5);
            //f.Dik.Add("rice", 6.50);
            //f.Dik.Add("pepsi", 5.20);
            //f.Dik.Add("pizza", 4.90);
            //f.Dik.Add("chocholate", 2.99);

            //foreach (KeyValuePair<string, double> d in f.Dik) {

            //    Console.WriteLine($"1-{ d.Key} ${d.Value}");
            //}

            //set Input for name and pass
            //Console.WriteLine("please signin to continue                                                                     "+ DateTime.Now);
            //Console.WriteLine("--------------------------");





            //Console.Write("user name: ");
            //string UserNameInput = Console.ReadLine();

            //Console.Write("PassWord: ");
            //int? UserPassInput = int.TryParse(Console.ReadLine(), out var num) ? num : null;
            ////Console.WriteLine($"user name is {UserNameInput} and password is {UserPassInput}");


            










            Console.WriteLine("End the program");
            Console.ReadKey();
        }





    }
}