using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static Shop shop = new Shop(50, 10, 7, 75, 20, 40, 17);

        static void Main(string[] args)
        {


            Queue<Buyer> buyers = new Queue<Buyer>();
            int CountDays = 0;
            while (CountDays < 14)
            {
                buyers.Enqueue(new Buyer(ListOfProducts(), 150));
                shop.NextBuyer(buyers.Dequeue());
                CountDays++;
                shop.ExpDateCount();
                if (CountDays % 7 == 0)
                {
                    shop.StatisticForLoses();
                }
            }

        }


        static List<Products> ListOfProducts()
        {
            List<Products> list = new List<Products>();
            Random random = new Random();
            int countOfMilk = random.Next(0, 4);
            for (int i = 0; i < countOfMilk; i++)
            {
                list.Add(new Milk());
            }
            int countOfBread = random.Next(0, 4);
            for (int i = 0; i < countOfBread; i++)
            {
                list.Add(new Bread());
            }
            int countOfCake = random.Next(0, 4);
            for (int i = 0; i < countOfCake; i++)
            {
                list.Add(new Cake());
            }
            int countOfCheese = random.Next(0, 4);
            for (int i = 0; i < countOfCheese; i++)
            {
                list.Add(new Cheese());
            }
            int countOfOat = random.Next(0, 4);
            for (int i = 0; i < countOfOat; i++)
            {
                list.Add(new Oat());
            }
            int countOfTomato = random.Next(0, 4);
            for (int i = 0; i < countOfTomato; i++)
            {
                list.Add(new Tomato());
            }
            int countOfYogurt = random.Next(0, 4);
            for (int i = 0; i < countOfYogurt; i++)
            {
                list.Add(new Yogurt());
            }
            return list;
        }
    }
}
