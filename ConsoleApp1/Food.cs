using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Food
    {
        public string? Name { get; set; }
        public double Price { get; set; }
    }
    public class FoodList {


        public Dictionary<int, Food> food = new Dictionary<int, Food>();


        public FoodList()
        {
            food.Add(1, new Food { Name = "Popcorn (Small)", Price = 2.5 });
            food.Add(2, new Food { Name = "Popcorn (Large)", Price = 4.0 });
            food.Add(3, new Food { Name = "Nachos with Cheese", Price = 3.4 });
            food.Add(4, new Food { Name = "Hot Dog", Price = 3.0 });
            food.Add(5, new Food { Name = "French Fries", Price = 2.5 });
            food.Add(6, new Food { Name = "Chocolate Bar", Price = 1.5 });
            food.Add(7, new Food { Name = "Candy Pack", Price = 1.0 });
            food.Add(8, new Food { Name = "Ice Cream", Price = 2.0 });
            food.Add(9, new Food { Name = "Soft Drink (Small)", Price = 1.5 });
            food.Add(10, new Food { Name = "Soft Drink (Large)", Price = 2.5 });
            food.Add(11, new Food { Name = "Water Bottle", Price = 1.0 });
            food.Add(12, new Food { Name = "Coffee", Price = 2.0 });


        }
        public void foodListDisplay()
        {

            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}.{item.Value.Name} {item.Value.Price}$");
            }
        }
       
    }

        
    


    
}
