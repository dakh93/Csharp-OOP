using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GreedyTimes
{
    class Gem
    {
        public string GemName { get; set; }

        public long Amount { get; set; }

        public Gem()
        {
            Amount = 0;
        }

        public void GemUpdateAmount(long amount)
        {
            Amount += amount;
        }
    }
}
