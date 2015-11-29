using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTeamFoundationServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker joker = new Worker {Name = "Joker"};
            Customer batmen = new Customer{Age = 17, Name = "John Wayn"};
            Console.WriteLine(joker.Name);
        }
    }

    class Worker
    {
        public string Name { get; set; } 
    }

    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
