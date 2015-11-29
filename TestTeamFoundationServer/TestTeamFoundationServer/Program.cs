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
            Console.WriteLine(joker.Name);
        }
    }

    class Worker
    {
        public string Name { get; set; } 
    }
}
