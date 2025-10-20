using System;
using System.Security;

namespace ConsoleApp1 {

  
    
    class Program {
        

        public void MenuShow() {

            Console.WriteLine("[1] Movies\n[2] Snacks & Drinks\n[3] End of the day (Comming soon)\n\n (0) to quit");

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
            bool FoodRunning = true;
            bool FoodRunning1 = true;



            //Food list
            FoodList food = new FoodList();

            //food price
            double TotelFood = 0;
            List<string> foodchoice = new List<string>();
            







            //movie list
            MovList movlist = new MovList();

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

                    while (IsRunning1)
                    {
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
                                while (IsRunning2)
                                {
                                    int? SeatInput = int.TryParse(Console.ReadLine(), out num) ? num : null;
                                    if (SeatInput == 1)
                                    {
                                        Console.Clear();
                                        while (IsRunning3)
                                        {

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
                                                    var SeatSelecter = Console.ReadLine().ToUpper().Trim();
                                                    //var SeatUpper = SeatSelecter.ToUpper().Trim();

                                                    if (hall.SeatsList.Contains(SeatSelecter))
                                                    {
                                                        quantList.Add(SeatSelecter);

                                                    }

                                                    if (SeatSelecter == "D2" || SeatSelecter == "B5")
                                                    {
                                                        Console.WriteLine($"The Seats ({SeatSelecter}) unavailable");
                                                        goto here;
                                                        
                                                    }

                                                    else if (!hall.SeatsList.Contains(SeatSelecter))
                                                    {
                                                        Console.WriteLine($"Sorry the {SeatSelecter} not found!! ");
                                                        goto here;
                                                    }
                                                    ;






                                                }
                                                Console.Write("Enter your name )>");
                                                string? CusName = Console.ReadLine()?.Trim();
                                                double Price = Convert.ToDouble(m.Value.Price * Quant);
                                                string seat = string.Join(',', quantList);
                                                Console.Clear();
                                                Console.WriteLine($@"
                                            ╔════════════════════════════════╗
                                            ║          TICKET / INVOICE      ║
                                            ╠════════════════════════════════╣
                                            ║ Movie : {m.Value.Name}         
                                            ║ CusName : {CusName}
                                            ║                                ║
                                            ║                                ║
                                            ║ Time  : {DateTime.Now}  ║  
                                            ║ Show Time: {m.Value.date.ToString("hh:mm tt")}            ║
                                            ╠════════════════════════════════╣
                                            ║ Selected Seats: {seat}             ║
                                            ║ per seat: {m.Value.Price + "$"}                   ║
                                            ║ Quantity: {Quant}                    ║
                                            ║ ------------------------------ ║
                                            ║ TOTAL: {Price + "$"}                      ║
                                            ╠════════════════════════════════╣
                                            ║   Thank you! Enjoy the show <3 ║
                                            ╚════════════════════════════════╝
                                            ");
                                                Console.Write("(0) To Quit )>");
                                                int? SeatOut = int.TryParse(Console.ReadLine(), out num) ? num : null;
                                                if (SeatOut == 0) { Console.Clear(); IsRunning1 = false; IsRunning2 = false; IsRunning3 = false; }



                                            }
                                            else { Console.Clear(); Console.WriteLine($"Invalid Input!! \n\n"); }



                                        }



                                    }
                                    else if (SeatInput == 0)
                                    {
                                        IsRunning2 = false;
                                        IsRunning1 = false;
                                        Console.Clear();


                                    }
                                }
                                
                            }
                            

                        }
                    }
                }
                
                if (MinuUserInput == 2) {


                    Console.Clear();
                    FoodRunning = true;
                    while (FoodRunning) {

                        FoodRunning1 = true;
                        while (FoodRunning1)
                        {
                            Console.Clear() ;
                            food.foodListDisplay();
                            Console.WriteLine("(0) to To calculate the totale");
                            Console.Write("Enter your Choice )>");
                            int? FoodInput = int.TryParse(Console.ReadLine(), out int number) ? number : null;
                            if (FoodInput == 0) { FoodRunning1 = false; FoodRunning = false; }
                            if (FoodInput > 12 || FoodInput < 0 || FoodInput == null)
                            {

                                Console.Clear();
                                Console.WriteLine("Invalid input please try a again!!!!!\n\n\n ");
                                FoodRunning1 = false;
                            }
                            TotelFood = FoodInput switch
                            {
                                1 => TotelFood += food.food[(int)FoodInput].Price,
                                2 => TotelFood += food.food[(int)FoodInput].Price,
                                3 => TotelFood += food.food[(int)FoodInput].Price,
                                4 => TotelFood += food.food[(int)FoodInput].Price,
                                5 => TotelFood += food.food[(int)FoodInput].Price,
                                6 => TotelFood += food.food[(int)FoodInput].Price,
                                7 => TotelFood += food.food[(int)FoodInput].Price,
                                8 => TotelFood += food.food[(int)FoodInput].Price,
                                9 => TotelFood += food.food[(int)FoodInput].Price,
                                10 => TotelFood += food.food[(int)FoodInput].Price,
                                11 => TotelFood += food.food[(int)FoodInput].Price,
                                12 => TotelFood += food.food[(int)FoodInput].Price,
                                _ => TotelFood


                            };
                            if (FoodInput >= 1)
                            {
                                foodchoice.Add(food.food[(int)FoodInput].Name);
                            }
                            
                        }
                        Console.Clear();
                        Console.WriteLine($@"
========================================
            CINEMA FOOD BILL 
========================================
{DateTime.Now:f}");
                        Console.WriteLine("-------------your order-------------\n");
                        foreach (var item in foodchoice) {

                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n------------------------------------\n");
                        Console.WriteLine($"your total price is {TotelFood}$");
                        Console.WriteLine("========================================\r\n     THANK YOU FOR YOUR PURCHASE! \r\n========================================");

                        Console.Write("\n\n\n\n\nType (0) to Exit )>");
                        int? FoodOut = int.TryParse(Console.ReadLine(), out int number1) ? number1 : null;
                        if (FoodOut == 0) { IsRunning = false; };
                        



                        
            


                    }

                }
                if (MinuUserInput == 0) { break; }
                if (MinuUserInput == 3) { Console.WriteLine("Comming soon");break; }












            }
            













            

            





            


            










            Console.WriteLine("End the program");
            Console.ReadKey();
        }





    }
}