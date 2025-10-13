using System;
using System.Security;

namespace ConsoleApp1 {

    class Program {

        static void Main(){
            //add user info

            Person user1 = new Person("Ali",1976,"Cashier");
            Person user2 = new Person("mohammed", 21412, "sales");
            Person user3 = new Person("Raheem", 123546, "sales");
            Person user4 = new Person("haider", 19346776, "customerservice");


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
            Console.WriteLine("please signin to continue                                                                     "+ DateTime.Now);
            Console.WriteLine("--------------------------");




            Console.Write("user name: ");
            string UserNameInput = Console.ReadLine();

            Console.Write("PassWord: ");
            int? UserPassInput = int.TryParse(Console.ReadLine(), out var num) ? num : null;
            //Console.WriteLine($"user name is {UserNameInput} and password is {UserPassInput}");


            Console.WriteLine("[1] Film");
            Console.WriteLine("[2] Food and Drinks");
            Console.WriteLine("[3] Cancel item");
            Console.WriteLine("[4] Pay");
            Console.WriteLine("[5] End of the day");
            Console.WriteLine("[6] Exit");










            Console.WriteLine("End the program");
            Console.ReadKey();
        }





    }
}