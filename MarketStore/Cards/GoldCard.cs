using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.Cards
{
    public class GoldCard : DiscountCard
    {
        public GoldCard(double turnover, double purchaseValue)
            :base(turnover, purchaseValue)
        {

        }
        
        public override double Turnover { get; set; }

        public override double PurchaseValue { get; set; }

        public override double DiscountRate => (int)Turnover/100 + 2 > 10 ? 10 : (int)Turnover / 100 + 2;

        public override double Discount => CalculateDiscount();


        protected override double CalculateDiscount()
        {

            return PurchaseValue * (DiscountRate / 100);
        }



        
    }
}
