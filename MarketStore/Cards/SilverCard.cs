using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.Cards
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(double turnover, double purchaseValue)
            :base(turnover, purchaseValue)
        {
        }

        public override double Turnover { get; set; }

        public override double PurchaseValue { get; set; }

        public override double DiscountRate => Turnover > 300 ? 3.5 : 2;

        public override double Discount => CalculateDiscount();

        protected override double CalculateDiscount()
        {

            return PurchaseValue * (DiscountRate / 100);
        }

 

        
    }
}
