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
        

        static void Main(){
            var p = new Program();
            
            MovList movlist = new MovList();
            
            //add user info

            Person user1 = new Person("Ali", 1976, "Cashier");
            Person user2 = new Person("mohammed", 21412, "sales");
            Person user3 = new Person("Raheem", 123546, "sales");
            Person user4 = new Person("haider", 19346776, "customerservice");

            //main minu
            Console.WriteLine("[1] Movies");
            Console.WriteLine("[2] Snacks & Drinks");
            Console.WriteLine("[3] Pay");
            Console.WriteLine("[4] End of the day");
            Console.WriteLine("[5] Exit");

            Console.Write("Type Your Choice: (numbers!!) ");
            int? MinuUserInput = int.TryParse(Console.ReadLine(), out int num)? num : null;

            if (MinuUserInput == 1)
            {
                Console.Clear();
                movlist.Display();
                Console.Write("Type the Movie name To Display The description");
                int? MovieSelect = int.TryParse(Console.ReadLine(), out num) ? num : null;
                foreach (var m in movlist.MovDick.Keys)
                {
                    if (MovieSelect == m.First()) {

                        Console.WriteLine(movlist.MovDick.Values);
                    }
                }
                
                


                
            }
            else if (MinuUserInput == 2 && MinuUserInput == 3 && MinuUserInput == 4 && MinuUserInput == 5) { Console.WriteLine("Coming soon"); }
            else { Console.WriteLine("Invalid input"); }













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