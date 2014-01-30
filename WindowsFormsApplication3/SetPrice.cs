using System;
namespace PirateWars
{

    public class SetPrice
    {
        private Random rand = new Random();

        //Price configuration
        private int priceDirectionChance = 35;
        private int priceChangeMinimumPercentage = 5;
        private int priceChangeMaximumPercentage = 10;

        
        //Ändrar priset på en vara. Retunerar det nya priset.
        public int PriceChangeMove(int initialPrice, bool priceDirectionUp)
        {
            int returnPrice;
            int priceChange = rand.Next(priceChangeMinimumPercentage, priceChangeMaximumPercentage);
            

            if (rand.Next(0, 100) > priceDirectionChance)
                priceDirectionUp = !priceDirectionUp;

            if (priceDirectionUp)
            {
                priceChange += 100;
                returnPrice = (initialPrice * priceChange) / 100;
            }
            else
            {
                priceChange = 100 - priceChange;
                returnPrice = (initialPrice * priceChange) / 100;
            }
            return returnPrice;

        

        }

        public int initialPrice(String cargoName) //Inte klar! :D
        {
            return 10;
        }

    }

}