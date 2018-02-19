using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HotelReservation
{
    public class PriceCalculator
    {
        private decimal price;
        private int days;
        private Seasons season;
        private Discounts discount;

        public PriceCalculator(string input)
        {

            var splitInput = input.Split(' ');

            price = decimal.Parse(splitInput[0]);
            days = int.Parse(splitInput[1]);
            season = Enum.Parse<Seasons>(splitInput[2]);
            discount = Discounts.None;
            if (splitInput.Length > 3)
            {
                discount = Enum.Parse<Discounts>(splitInput[3]);
            }

        }


        public decimal CalculatePrice()
        {
            var totalPrice = price * days * (int) season;

            var discoutPercent = (totalPrice * (int) discount) / 100;

            var finalPrice = totalPrice - discoutPercent;

            return finalPrice;
        }
    }

}