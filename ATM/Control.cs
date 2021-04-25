using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Control
    {
        public static void Run()
        {


            User user = new User
            {
                Name = "Cavid",
                Surname = "Mahsumov",
                Card = new Card
                {
                    Pan = "2222222222222222",
                    Pin = "4321",
                    Balance = 10000,
                    Cvc = "567",
                    ExpireDate = new DateTime(2022, 04, 25)
                }
            };
            User user1 = new User
            {

                Name = "Tural",
                Surname = "Tahirli",
                Card = new Card
                {
                    Pan = "1111111111111111",
                    Pin = "1212",
                    Balance = 10000,
                    Cvc = "123",
                    ExpireDate = new DateTime(2021, 02, 11)
                }
            };
            User user2 = new User
            {
                Name = "John",
                Surname = "Johnlu",
                Card = new Card
                {
                    Pan = "3333333333333333",
                    Pin = "3223",
                    Balance = 10000,
                    Cvc = "355",
                    ExpireDate = new DateTime(2022, 01, 2)
                }
            };
            User user3 = new User
            {

                Name = "Murad",
                Surname = "Sadixov",
                Card = new Card
                {
                    Pan = "9999999999999999",
                    Pin = "3223",
                    Balance = 10000,
                    Cvc = "355",
                    ExpireDate = new DateTime(2022, 01, 2)
                }
            };
            User user4 = new User
            {
                Name = "Elsever",
                Surname = "Teyyubov",
                Card = new Card
                {
                    Pan = "5555555555555555",
                    Pin = "4343",
                    Balance = 10000,
                    Cvc = "355",
                    ExpireDate = new DateTime(2022, 01, 2)
                }
            };
            User user5 = new User
            {
                Name = "Kenan",
                Surname = "Ezizov",
                Card = new Card
                {
                    Pan = "7777777777777777",
                    Pin = "6666",
                    Balance = 10000,
                    Cvc = "355",
                    ExpireDate = new DateTime(2022, 01, 2)
                }
            };
            User[] users = new User[6] { user, user1, user2, user3, user4, user5 };
            System.Text.StringBuilder text1 = new System.Text.StringBuilder("========EMELIYYATLARIN SIYAHISI========\n");

            CardHelper.users = users;
            string pin = "";
            int choose = 0;
            Console.WriteLine("Please Enter The Pin ");
            pin = Console.ReadLine();
            if (CardHelper.CheckUser(pin) && CardHelper.CheckPin(pin) && CardHelper.CheckDate(CardHelper.user.Card))
            {
                Menu();


            }
            void tryAgain()
            {
                Console.WriteLine("Hansi Karta Mebleg Gondermek isteyirsiz ?(PIN)");
                string cardpin = Console.ReadLine();
                if (CardHelper.searchUser(cardpin))
                {

                    Console.WriteLine("Ne qeder Mebleg gondermek isteyirsiz?");
                    decimal money = default;
                    money = decimal.Parse(Console.ReadLine());
                    CardHelper.SendMoneyCarttoCart(CardHelper.user2, 200);
                    Menu();


                }
                else
                {
                    Console.Clear();
                    tryAgain();
                }
            }

            void Menu()
            {
                Console.WriteLine("Please Choose Variant");
                Console.WriteLine("1)Balance");
                Console.WriteLine("2)Negd Pul");
                Console.WriteLine("3)Edilen emeliyyatlarin siyahisi.");
                Console.WriteLine("4)Kartdan karta kocurme");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine($"Balance : {CardHelper.user.Card.Balance}");
                    int menuchoose = 0;
                    Console.WriteLine("1)Menu");
                    menuchoose = int.Parse(Console.ReadLine());
                    if (menuchoose == 1)
                    {
                        text1.Append("Balanca Baxildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();

                    }


                }
                else if (choose == 2)
                {
                    int chooseMoney = default;
                    Console.WriteLine("1)10 AZN");
                    Console.WriteLine("2)20 AZN");
                    Console.WriteLine("3)50 AZN");
                    Console.WriteLine("4)100 AZN");
                    Console.WriteLine("5)Other");
                    chooseMoney = int.Parse(Console.ReadLine());
                    if (chooseMoney == 1)
                    {
                        text1.Append("Pul Cixarildi! Date : ").Append(DateTime.Now).Append("\n");

                        CardHelper.CheckMoney(CardHelper.user, 10);
                        Console.Clear();
                        Menu();

                    }
                    else if (chooseMoney == 2)
                    {
                        CardHelper.CheckMoney(CardHelper.user, 20);
                        Console.Clear();
                        text1.Append("Pul Cixarildi! Date : ").Append(DateTime.Now).Append("\n");

                        Menu();
                    }
                    else if (chooseMoney == 3)
                    {
                        CardHelper.CheckMoney(CardHelper.user, 50);
                        Console.Clear();
                        text1.Append("Pul Cixarildi! Date : ").Append(DateTime.Now).Append("\n");

                        Menu();
                    }
                    else if (chooseMoney == 4)
                    {
                        CardHelper.CheckMoney(CardHelper.user, 100);
                        Console.Clear();
                        text1.Append("Pul Cixarildi! Date : ").Append(DateTime.Now).Append("\n");

                        Menu();
                    }
                    else if (chooseMoney == 5)
                    {
                        Console.WriteLine("Ne qeder Pul kecmek isteyirsi?");
                        decimal othermoney = 0;
                        othermoney = decimal.Parse(Console.ReadLine());
                        CardHelper.CheckMoney(CardHelper.user, othermoney);
                        Console.Clear();
                        text1.Append("Pul Cixarildi! Date : ").Append(DateTime.Now).Append("\n");

                        Menu();

                    }
                }
                else if (choose == 3)
                {
                    text1.Append("Emeliyyatlar sistemine baxildi! Date : ").Append(DateTime.Now).Append("\n");

                    Console.WriteLine(text1);

                }
                else if (choose == 4)
                {
                    text1.Append("Kartdan Kata Pul Kocuruldu! Date : ").Append(DateTime.Now).Append("\n");

                    tryAgain();
                }
            }
        }


    }
}
