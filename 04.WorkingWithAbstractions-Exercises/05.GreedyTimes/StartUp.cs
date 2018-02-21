using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace _05.GreedyTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] inventory =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Type bag = new Type();
            

            for (int i = 0; i < inventory.Length; i += 2)
            {
                string name = inventory[i];
                long amount = long.Parse(inventory[i + 1]);

                string type = string.Empty;

                type = CheckItemType(name, type);

                if (type == "")
                {
                    continue;
                }
                else if (bagCapacity < bag.GetTypesSum() + amount)
                {
                    continue;
                }


                switch (type)
                {
                        
                    case "Gem":
                        if (!bag.Gems.Any(x =>
                        string.Equals(x.GemName, name, StringComparison.InvariantCultureIgnoreCase)))
                        {
                            
                            
                            if (bag.GoldSum() < amount + bag.GemsSum())
                            {
                               continue;
                            }
                            else
                            {
                                Gem gem = new Gem();
                                gem.Amount = amount;
                                gem.GemName = name;

                                bag.Gems.Add(gem);
                            }
                          
                        }
                        else if (bag.GoldSum() > bag.GemsSum() + amount)
                        {
                            var index = bag.Gems.FindIndex(x => x.GemName.ToLower().Equals(name.ToLower()));
                            bag.Gems[index].Amount += amount;
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.Cash.Any(x =>
                            string.Equals(x.Currency, name, StringComparison.InvariantCultureIgnoreCase)))
                        {
                            
                            if (bag.GemsSum() < amount + bag.CashSum())
                            {
                                continue;
                            }
                            else
                            {
                                Cash cash = new Cash();
                                cash.Amount = amount;
                                cash.Currency = name;
                                bag.Cash.Add(cash);
                            }
                         
                        }
                        else if (bag.CashSum() + amount < bag.GemsSum())
                        {
                            var index = bag.Cash.FindIndex(x => x.Currency.ToLower().Equals(name.ToLower()));
                            bag.Cash[index].Amount += amount;
                            continue;
                        }
                        break;
                    case "Gold":
                        Gold currGold = new Gold();
                        currGold.Amount += amount;
                        bag.Gold.Add(currGold);
                        break;
                }

            }

            PrintBagContent(bag);
            
        }

        private static void PrintBagContent(Type bag)
        {
            if (bag.Gold.Count > 0)
            {
                Console.WriteLine($"<Gold> ${bag.GoldSum()}");
                Console.WriteLine($"##Gold - {bag.GoldSum()}");
            }
            if (bag.Gems.Count > 0)
            {
                Console.WriteLine($"<Gem> ${bag.GemsSum()}");
                foreach (var gem in bag.Gems.OrderByDescending(x => x.GemName).ThenBy(x => x.Amount))
                {
                    Console.WriteLine($"##{gem.GemName} - {gem.Amount}");
                }
            }
            if (bag.Cash.Count > 0)
            {
                Console.WriteLine($"<Cash> ${bag.CashSum()}");
                foreach (var cash in bag.Cash.OrderByDescending(x => x.Currency).ThenBy(x => x.Amount))
                {
                    Console.WriteLine($"##{cash.Currency} - {cash.Amount}");
                }
            }
            
           
        }

        private static string CheckItemType(string name, string type)
        {
            if (name.Length == 3)
            {
                type = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                type = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                type = "Gold";
            }

            return type;
        }
    }
}
