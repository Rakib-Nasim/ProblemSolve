﻿using System;
using System.Collections.Generic;

namespace SoloLearn_DictionaryProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (var item in coffee)
            {
                var discountrate = (item.Value * discount) / 100;
                int netPrice = item.Value - discountrate;
                Console.WriteLine(item.Key + ":" + netPrice);
            }
        }
    }
}
