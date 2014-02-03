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
        private int initialCargoPriceSpices = 100;
        private int initialCargoPriceBullets = 90;
        private int initialCargoPriceRum = 80;
        private int initialCargoPriceTobacco = 70;
        private int initialCargoPriceCloth = 60;
        private int initialCargoPriceGunpowder = 50;
        private int initialCargoPricePearls = 40;

        
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
        public int initialPrice(String cargoName) //Inte klar! :D
        {
            switch (cargoName)
            {
                case "Spices":
                    return initialCargoPriceSpices;
                    break;
                case "Bullets":
                    return initialCargoPriceBullets;
                    break;
                case "Rum":
                    return initialCargoPriceRum;
                    break;
                case "Tobacco":
                    return initialCargoPriceTobacco;
                    break;
                case "Cloth":
                    return initialCargoPriceCloth;
                    break;
                case "Gunpowder":
                    return initialCargoPriceGunPowder;
                    break;
                case "Pearls":
                    return initialCargoPricePearls;
                    break;
                default:
                    return 0;
                    break;
            }
        }

    }

}