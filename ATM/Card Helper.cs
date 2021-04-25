using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHelper
    {
        static public User[] users { get; set; }
        static DateTime current = DateTime.Now;
        static public User user { get; set; }
        static public User user2 { get; set; }


        public static bool CheckPan(string pan)
        {
            if (pan.Length == 16)
            {
                return true;
            }
            throw new System.Exception("Pan character count must be equal 16");
        }
        public static bool CheckPin(string pin)
        {
            if (pin.Length == 4)
            {
                return true;
            }
            throw new System.Exception("Pin character count must be equal 4");
        }
        public static bool CheckDate(Card bankCard)
        {
            if (bankCard.ExpireDate >= DateTime.Now)
            {
                return true;
            }
            throw new System.Exception("False Date");

        }
        public static bool CheckUser(string Pin)
        {
            foreach (var item in users)
            {
                if (Pin == item.Card.Pin)
                {
                    Console.WriteLine($"Welcome {item.Name} {item.Surname} ");
                    user = item;
                    return true;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Pin");
            return false;
        }
        public static void CheckMoney(User user, decimal balance)
        {
            if (balance <= user.Card.Balance)
            {
                user.Card.Balance = user.Card.Balance - balance;
            }
            else
            {
                throw new System.ApplicationException("Balance da yeterli qeder mebleg yoxdur!");
            }
        }
        public static bool searchUser(string pin)
        {
            foreach (var item in users)
            {
                if (pin == item.Card.Pin)
                {
                    user2 = item;
                    return true;

                }


            }
            return false;
        }
        public static void SendMoneyCarttoCart(User user1, decimal balance)
        {

            if (user.Card.Balance >= balance)
            {
                user.Card.Balance -= balance;
                user1.Card.Balance += balance;
            }
            else
            {
                throw new System.ApplicationException("Balance da yeterli qeder mebleg yoxdur!");

            }
        }

    }
}
