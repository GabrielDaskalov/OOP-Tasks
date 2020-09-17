using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.Cards
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(double turnover, double purchaseValue)
            :base(turnover, purchaseValue)
        {
        }

        public override double Turnover { get; set; }

        public override double PurchaseValue { get; set; }

        public override double DiscountRate => Turnover < 100 ? 0 : (Turnover >= 100 && Turnover <= 300) ? 1 : 2.5;

        public override double Discount => CalculateDiscount();


        protected override double CalculateDiscount()
        {

            double discount = PurchaseValue * (DiscountRate /100);

            return discount;
        }

    }
}
