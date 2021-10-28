using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleChangeMaker
{
    internal sealed class Program
    {
        public static int[] BritishPound { get; set; } = new int[] { 1, 2, 5, 10, 20, 50 };

        public static int[] change { get; set; } = Array.Empty<int>();

        public static int[] NorwegianKrone { get; set; } = new int[] { 1, 5, 10, 20 };

        public static int[] USDollar { get; set; } = new int[] { 1, 5, 10, 25 };

        private static VendingMachine machine;
        private static double purchaseAmount;
        private static bool tempBool = false;
        private static double tenderAmount;

        public static void Main()
        {
            while (!tempBool)
            {
                Console.WriteLine("Select country coin denomination: British=br, US=us or Norwegian=nr.");
                var tempString = Console.ReadLine();
                switch (tempString)
                {
                    case "br":
                        SetCoinDenomination(BritishPound.ToList());
                        break;
                    case "us":
                        SetCoinDenomination(USDollar.ToList());
                        break;
                    case "nr":
                        SetCoinDenomination(NorwegianKrone.ToList());
                        break;
                    default:
                        Console.WriteLine("Invalid selection: Try Again:");
                        tempBool = false;
                        break;
                }
            }

            tempBool = false;
            while (!tempBool)
            {
                Console.WriteLine("Running");
                Console.WriteLine("Enter P\\T followed by the amount or -1 to Exit. Ex. T10 P10");
                var tempString = Console.ReadLine().Replace("  ", " ").ToLower().ToUpper();
                if (tempString == "-1")
                {
                    tempBool = true;
                }
                else if (tempString.StartsWith("P") && (tempString.Split(" ".ToCharArray()).Count() == 2 && tempString.Split(" ".ToCharArray())[1].StartsWith("T")))
                {
                    purchaseAmount = Convert.ToDouble(tempString.Split(" ".ToCharArray())[0].Replace("P", ""));
                    tenderAmount = Convert.ToDouble(tempString.Split(" ".ToCharArray())[1].Replace("T", ""));
                }
                else if (tempString.StartsWith("T") && (tempString.Split(" ".ToCharArray()).Count() == 2 && tempString.Split(" ".ToCharArray())[1].StartsWith("P")))
                {
                    tenderAmount = Convert.ToDouble(tempString.Split(" ".ToCharArray())[0].Replace("T", ""));
                    purchaseAmount = Convert.ToDouble(tempString.Split(" ".ToCharArray())[1].Replace("P", ""));
                }
                else
                {
                    Console.WriteLine("Invalid entry. Try again.");
                }

                if (tenderAmount >= purchaseAmount)
                {
                    change = (machine.CalculateChange​(purchaseAmount, tenderAmount)).ToArray();
                }
                else
                {
                    Console.WriteLine("Invalid entry. Try again.");
                }

                var counter = 0;
                foreach (var coin in change)
                {
                    Console.WriteLine("change[" + Convert.ToString(coin) + "] = " + Convert.ToString(coin));
                    counter++;
                }
            }

        }

        private static void SetCoinDenomination(List<int> CoinSet)
        {
            Console.WriteLine("Booting");
            CoinSet.Reverse();
            machine = new VendingMachine(CoinSet.ToArray());
            tempBool = true;
        }

    }
}
