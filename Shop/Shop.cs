using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Shop
    {

        Bread bread1 = new Bread();
        Cake cake1 = new Cake();
        Cheese cheese1 = new Cheese();
        Milk milk1 = new Milk();
        Oat oat1 = new Oat();
        Tomato tomato1 = new Tomato();
        Yogurt yogurt1 = new Yogurt();





        public Queue<Milk> milk = new Queue<Milk>();
        public Queue<Bread> bread = new Queue<Bread>();
        public Queue<Cake> cake = new Queue<Cake>();
        public Queue<Cheese> cheese = new Queue<Cheese>();
        public Queue<Oat> oat = new Queue<Oat>();
        public Queue<Tomato> tomato = new Queue<Tomato>();
        public Queue<Yogurt> yogurt = new Queue<Yogurt>();

        public Shop(int milkCount, int breadCount, int cakeCount, int cheeseCount, int oatCount, int tomatoCount, int yogurtCount)
        {
            for (int i = 0; i < milkCount; i++)
            {
                milk.Enqueue(new Milk());
            }
            for (int i = 0; i < cakeCount; i++)
            {
                cake.Enqueue(new Cake());
            }
            for (int i = 0; i < breadCount; i++)
            {
                bread.Enqueue(new Bread());
            }
            for (int i = 0; i < cheeseCount; i++)
            {
                cheese.Enqueue(new Cheese());
            }
            for (int i = 0; i < oatCount; i++)
            {
                oat.Enqueue(new Oat());
            }
            for (int i = 0; i < tomatoCount; i++)
            {
                tomato.Enqueue(new Tomato());
            }
            for (int i = 0; i < yogurtCount; i++)
            {
                yogurt.Enqueue(new Yogurt());
            }

        }
        public void NextBuyer(Buyer buyer)
        {
            int totalPrice = 0;
            int milkCount = 0;
            int breadCount = 0;
            int cakeCount = 0;
            int cheeseCount = 0;
            int oatCount = 0;
            int tomatoCount = 0;
            int yogurtCount = 0;
            int q = 0;
            int w = 0;
            int e = 0;
            int r = 0;
            int t = 0;
            int y = 0;
            int u = 0;

            foreach (Products p in buyer._productList)
            {

                if (p is Milk)
                {
                    
                    milkCount++;
                    if (milk.Count != 0 && milk1._endDate > 0)
                    {
                        milk.Dequeue();
                        totalPrice += ((Milk)p)._price;
                    }
                    else if(q==0)
                    {
                        Console.WriteLine("We are out of Milk");
                        q++;
                    }
                    continue;
                }
                if (p is Bread)
                {
                    breadCount++;
                    if (bread.Count != 0 && bread1._endDate > 0)
                    {
                        bread.Dequeue();
                        totalPrice += ((Bread)p)._price;
                    }
                    else if(w==0)
                    {
                        Console.WriteLine("We are out of Bread");
                        w++;
                    }
                    continue;
                }
                if (p is Cheese)
                {
                   
                    cheeseCount++;
                    if (cheese.Count != 0 && cheese1._endDate > 0)
                    {
                        cheese.Dequeue();
                        totalPrice += ((Cheese)p)._price;
                    }
                    else if(e==0)
                    {
                        Console.WriteLine("We are out of Cheese");
                        e++;
                    }
                    continue;
                }
                if (p is Oat)
                {
                   
                    oatCount++;
                    if (oat.Count != 0 && oat1._endDate > 0)
                    {
                        oat.Dequeue();
                        totalPrice += ((Oat)p)._price;
                    }
                    else if(r==0)
                    {
                        Console.WriteLine("We are out of Oat");
                        r ++;
                    }
                    continue;
                }
                if (p is Tomato)
                {
                   
                    tomatoCount++;
                    if (tomato.Count != 0 && tomato1._endDate > 0)
                    {
                        tomato.Dequeue();
                        totalPrice += ((Tomato)p)._price;
                    }
                    else if(t==0)
                    {
                        Console.WriteLine("We are out of Tomato");
                        t++;
                    }
                    continue;
                }
                if (p is Yogurt)
                {
                    
                    yogurtCount++;
                    if (yogurt.Count != 0 && yogurt1._endDate > 0)
                    {
                        yogurt.Dequeue();
                        totalPrice += ((Yogurt)p)._price;
                    }
                    else if(y==0)
                    {
                        Console.WriteLine("We are out of Yogurt");
                        y++;
                    }
                    continue;
                }

                
                if (p is Cake)
                {
                    cakeCount++;
                    if (cake.Count != 0 && cake1._endDate > 0)
                    {
                        cake.Dequeue();
                        totalPrice += ((Cake)p)._price;
                    }
                    else if(u==0)
                    {
                        Console.WriteLine("We are out of Cake");
                        u++;
                    }
                }

            }
            Console.WriteLine("Milk - " + milkCount);
            Console.WriteLine("Bread - " + breadCount);
            Console.WriteLine("Cake - " + cakeCount);
            Console.WriteLine("Cheese - " + cheeseCount);
            Console.WriteLine("Oat - " + oatCount);
            Console.WriteLine("Tomato - " + tomatoCount);
            Console.WriteLine("Yogurt - " + yogurtCount);

            Console.WriteLine("Total price =" + totalPrice);
            if (totalPrice > buyer._cash)
            {
                Console.WriteLine("Sorry, but you dont have enough money");
                foreach (Products p in buyer._productList)
                {
                    if (p is Milk)
                    {
                        milk.Enqueue(new Milk());
                    }

                    if (p is Bread)
                    {
                        bread.Enqueue(new Bread());
                    }
                    if (p is Cake)
                    {
                        cake.Enqueue(new Cake());
                    }
                    if (p is Cheese)
                    {
                        cheese.Enqueue(new Cheese());
                    }
                    if (p is Oat)
                    {
                        oat.Enqueue(new Oat());
                    }
                    if (p is Tomato)
                    {
                        tomato.Enqueue(new Tomato());
                    }
                    if (p is Yogurt)
                    {
                        yogurt.Enqueue(new Yogurt());
                    }
                }
            }
            else
            {
                buyer._cash -= totalPrice;
                Console.WriteLine("Great! Now you have" + buyer._cash + "$ left.");
            }
        }
        public void ExpDateCount()
        {
            bread1._endDate--;
            cake1._endDate--;
            cheese1._endDate--;
            milk1._endDate--;
            oat1._endDate--;
            tomato1._endDate--;
            yogurt1._endDate--;
        }
        public void StatisticForLoses()
        {
            int breadLoses = 0;
            int cakeLoses = 0;
            int cheeseLoses = 0;
            int milkLoses = 0;
            int oatLoses = 0;
            int tomatoLoses = 0;
            int yogurtLoses = 0;

            int breadCount = 0;
            int cakeCount = 0;
            int cheeseCount = 0;
            int milkCount = 0;
            int oatCount = 0;
            int tomatoCount = 0;
            int yogurtCount =0;
            
            if (bread1._endDate <= 0)
            {
                breadLoses = bread1._price * bread.Count;
                breadCount = bread.Count;

                for (int i = 0; i < bread.Count; i++)
                {
                    bread.Dequeue();
                }
            }
            if (cake1._endDate <= 0)
            {
                cakeLoses = cake1._price * cake.Count;
                cakeCount = cake.Count;
                for (int i = 0; i < cake.Count; i++)
                {
                    cake.Dequeue();
                }

            }
            if (cheese1._endDate <= 0)
            {
                cheeseLoses = cheese1._price * cheese.Count;
                cheeseCount = cheese.Count;

                for (int i = 0; i < cheese.Count; i++)
                {
                    cheese.Dequeue();
                }
            }
            if (milk1._endDate <= 0)
            {
                milkLoses = milk1._price * milk.Count;
                milkCount = milk.Count;

                for (int i = 0; i < milk.Count; i++)
                {
                    milk.Dequeue();
                }
            }
            if (oat1._endDate <= 0)
            {
                oatLoses = oat1._price * oat.Count;
                oatCount = oat.Count;
                for (int i = 0; i < oat.Count; i++)
                {
                    oat.Dequeue();
                }
            }
            if (tomato1._endDate <= 0)
            {
                tomatoLoses = tomato1._price * tomato.Count;
                tomatoCount = tomato.Count;
                for (int i = 0; i < tomato.Count; i++)
                {
                    tomato.Dequeue();
                }
            }
            if (yogurt1._endDate <= 0)
            {
                yogurtLoses = yogurt1._price * yogurt.Count;
                yogurtCount = yogurt.Count;
                for (int i = 0; i < yogurt.Count; i++)
                {
                    yogurt.Dequeue();
                }
            }
             int totalLoses = (breadLoses + cakeLoses + cheeseLoses + milkLoses + oatLoses + tomatoLoses + yogurtLoses);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Bread loss:   " +breadCount+"items;    "+ breadLoses +"$.");
            Console.WriteLine("Cake loss:    " +cakeCount + "items;   "+ cakeLoses + "$.");
            Console.WriteLine("Cheese loss   " +cheeseCount + "items; "+ cheeseLoses + "$.");
            Console.WriteLine("Milk loss:    " +milkCount + "items;   "+ milkLoses +"$.");
            Console.WriteLine("Oat loss:     " +oatCount + "items;    "+ oatLoses + "$.");
            Console.WriteLine("Tomato loss:  " +tomatoCount + "items; "+ tomatoLoses +"$.");
            Console.WriteLine("Yogurt loss:  " +yogurtCount + "items; "+ yogurtLoses + "$.");
            Console.WriteLine();
            Console.WriteLine("Total loss:   " + totalLoses + "$.");
            Console.WriteLine("-----------------------------------------------------------");

        }

    }
}
