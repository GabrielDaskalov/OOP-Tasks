using MarketStore.Cards;
using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var payDesk = new PayDesk();

            while (true)
            {
                Console.WriteLine("Welcome! Please enter the type of card which you have or enter EXIT to leave the application!");

                var input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    return;

                }

                if (payDesk.IsItValid(input))
                {
                    Console.WriteLine("Your card is valid.");

                }
                else
                {
                    Console.WriteLine(("Invalid card."));
                    return;

                }

                Console.WriteLine("Please enter a turnover and a purchase value:");
                
                double turnover = 0;
                double purchaseValue = 0;

                try
                {
                    turnover = double.Parse(Console.ReadLine());

                    if (turnover < 0)
                    {
                        var ex = new NegativeNumberException("Turnover shouldn't be less than 0");
                        Console.WriteLine(ex.Message);
                        return;

                    }
                }
                catch 
                {
                    var ex = new InvalidInputException("Invalid input for turnover. You should enter a number!");
                    Console.WriteLine(ex.Message);
                    return;
                }

                try
                {
                    purchaseValue = double.Parse(Console.ReadLine());

                    if (purchaseValue <= 0)
                    {
                        var ex = new NegativeNumberException("Purchase value shouldn't be less or equal 0");
                        Console.WriteLine(ex.Message);
                        return;

                    }
                }
                catch
                {
                    var ex = new InvalidInputException("Ivalid input for purchase value. You should enter a number!");
                    Console.WriteLine(ex.Message);
                    return;
                }

                var card = payDesk.CreateCard(input, turnover, purchaseValue);

                Console.WriteLine(payDesk.GetInfo(card));

                break;

            }


        }

    }
}
