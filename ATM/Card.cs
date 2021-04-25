using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Balance { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========Card Info===========");
            Console.WriteLine($"Pan : {Pan}");
            Console.WriteLine($"Pin : {Pin}");
            Console.WriteLine($"Cvc : {Cvc}");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine($"Date Time : {ExpireDate.ToShortDateString()}");
        }

    }

}
