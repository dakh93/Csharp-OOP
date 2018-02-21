using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.GreedyTimes
{
    class Type
    {
        public List<Gold> Gold = new List<Gold>();

        public List<Gem> Gems = new List<Gem>();

        public List<Cash> Cash = new List<Cash>();

        public long GetTypesSum()
        {
            return GemsSum() + GoldSum() + CashSum();
        }

        public long GemsSum()
        {
            return Gems.Select(x => x.Amount).Sum();
        }

        public long CashSum()
        {
            return Cash.Select(x => x.Amount).Sum();
        }

        public long GoldSum()
        {
            return Gold.Select(x => x.Amount).Sum();
        }
    }
}
