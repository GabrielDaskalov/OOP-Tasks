using MarketStore.Cards;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace MarketStore
{
    public class PayDesk
    {
        public bool IsItValid(string cardType)
        {
            if (cardType == "bronze" || cardType == "gold" || cardType == "silver")
            {
                return true;

            }
   
            return false;
        
        }

        public DiscountCard CreateCard(string cardType, double turnover, double purchaseValue)
        {
            var discountCard = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(DiscountCard).IsAssignableFrom(t)
                 && t.Name.ToLower().Contains(cardType))
                .FirstOrDefault();

            var newCard = (DiscountCard)Activator.CreateInstance(discountCard, new object[] { turnover, purchaseValue });

            return newCard;
        }

        public string GetInfo(DiscountCard card)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Purchase value: ${card.PurchaseValue:f2}");
            sb.AppendLine($"Discount rate: {card.DiscountRate}%");
            sb.AppendLine($"Discount: ${card.Discount:f2}");
            sb.AppendLine($"Total: ${(card.PurchaseValue - card.Discount):f2}");

            return sb.ToString().Trim();
        }

    }
}
