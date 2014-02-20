using System;
namespace PirateWars
{

    public class SetPrice
    {
        private Random rand = new Random();

        //Price configuration
        private int priceDirectionChance = 60; //40% chance of a pricechange
        private int priceChangeMinimumPercentage = 1;
        private int priceChangeMaximumPercentage = 5;
        private int initialCargoPriceSpices = 1000;
        private int initialCargoPriceBullets = 900;
        private int initialCargoPriceRum = 800;
        private int initialCargoPriceTobacco = 700;
        private int initialCargoPriceCloth = 600;
        private int initialCargoPriceGunPowder = 500;
        private int initialCargoPricePearls = 400;

        
        /**
         * Function to change the price of a cargo in ports each move. 
         * @param initialPrice The price of the cargo at the start of the  function
         * @param priceDirectionUp Indicates if the cargo price is moving. Up or down.
         * @return The new price of the specific cargo.
         * */
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

        /**
         *To be called at the start of a new game to set the prices of different cargo.
         *@param cargoName The name of the cargo to get an initial price.
         *@return Integer containing the price.
         */
        public int initialPrice(String cargoName)
        {
            switch (cargoName)
            {
                case "Spices":
                    return initialCargoPriceSpices;
                case "Bullet":
                    return initialCargoPriceBullets;
                case "Rum":
                    return initialCargoPriceRum;
                case "Tobacco":
                    return initialCargoPriceTobacco;
                case "Cloth":
                    return initialCargoPriceCloth;
                case "Gunpowder":
                    return initialCargoPriceGunPowder;
                case "Pearl":
                    return initialCargoPricePearls;
                default:
                    return 0;
            }
        }

    }

}