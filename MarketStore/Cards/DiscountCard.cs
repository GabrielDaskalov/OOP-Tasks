using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        protected DiscountCard(double turnover, double purchaseValue)
        {
            Turnover = turnover;
            PurchaseValue = purchaseValue;
        }

        public abstract double PurchaseValue { get; set; }

        public abstract double Turnover { get; set; }

        public abstract double DiscountRate { get; }

        public abstract double Discount { get; }

        protected abstract double CalculateDiscount();

    }
}
