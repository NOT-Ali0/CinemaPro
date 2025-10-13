using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int PassWord { get; set; }


        public Person(string name , int password ,string tilte) {

            Name = name;
            Title = tilte;
            PassWord = password;
        }

    }
}
