using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05.DataModifier
{
    public class DataModifier
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            var first =
                DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var second =
                DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((int)(second - first).TotalDays);
        }
    }
}
