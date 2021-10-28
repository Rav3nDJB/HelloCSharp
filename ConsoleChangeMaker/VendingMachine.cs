using System;
using System.Collections.Generic;

namespace ConsoleChangeMaker
{
    public class VendingMachine
    {

        public int[] CoinDenominations { get; set; }

        public List<Coin> Coins { get; set; } = new List<Coin>();

        public VendingMachine(int[] coinDenom)
        {
            CoinDenominations = coinDenom;
        }

        public List<int> CalculateChange​(double purchaseAmount​, double tenderAmount)
        {
            var retVal = new List<int>();
            Coins = new List<Coin>();
            var change = Convert.ToInt32(tenderAmount - purchaseAmount​);

            foreach (var coinValue in CoinDenominations)
            {
                var coinCounter = 0;
                while (change >= coinValue)
                {
                    change -= coinValue;
                    coinCounter++;
                    retVal.Add(coinValue);
                }
                Coins.Add(new Coin(coinValue, coinCounter));
            }
            return retVal;
        }

    }
}
