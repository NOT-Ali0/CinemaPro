using System;

namespace ConsoleApp1 {

    class Program {

        static void Main(){
            //Food f = new Food();
            //f.Dik.Add("Popcorn",12.5);
            //f.Dik.Add("rice", 6.50);
            //f.Dik.Add("pepsi", 5.20);
            //f.Dik.Add("pizza", 4.90);
            //f.Dik.Add("chocholate", 2.99);

            //foreach (KeyValuePair<string, double> d in f.Dik) {

            //    Console.WriteLine($"1-{ d.Key} ${d.Value}");
            //}

            Console.WriteLine("WelCome To Cinema app please signin to continue");
            Console.Write("user");
            string NameInput = Console.ReadLine();
            int? PassInput = int.TryParse(Console.ReadLine(), out var num) ? num : null;



            Console.WriteLine("End the program");
            Console.ReadKey();
        }





    }
}