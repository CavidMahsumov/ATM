using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Card Card { get; set; }
        public void ShowUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========User Info=========");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Card.Show();
        }
    }
}
