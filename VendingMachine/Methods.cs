using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VendingMachine
{
    public static class Methods
    {
        public static bool StringValidate(string coinText)
        {
            foreach (char n in coinText)
            {
                if (!char.IsDigit(n))
                { return false; }
            }
            return true;
        }

        public static void SaveDenominationWAmntList(List<string> items)
        {
            File.WriteAllLines(Application.CommonAppDataPath + "\\CoinDenomWAmount.txt", items);
        }

        public static void SaveDenominationList(ListBox.ObjectCollection items)
        {
            var tempList = new List<string>();
            tempList.AddRange(items.Cast<string>());
            File.WriteAllLines(Application.CommonAppDataPath + "\\CoinDenominations.txt", tempList);
        }

        public static void SaveDenominationList(List<string> items)
        {
            var tempList = new List<string>();
            tempList.AddRange(items);
            File.WriteAllLines(Application.CommonAppDataPath + "\\CoinDenominations.txt", tempList);
        }

        public static List<string> SetCoinDenomination(List<string> coinsList)
        {
            var retVal = new List<string>();
            retVal.AddRange(coinsList); return (retVal);
        }


        public static List<string> SortStrListAsIntList(List<string> unsortedList,  bool sortList = true, bool reverseList = false)
        {
            var retVal = new List<string>();
            var SorttingList = new List<int>();

            foreach (string strVal in unsortedList)
            { SorttingList.Add(Convert.ToInt32(strVal)); }

            if (sortList)
            { SorttingList.Sort(); }

            if (reverseList)
            { SorttingList.Reverse(); }

            foreach (var IntVal in SorttingList)
            { retVal.Add(Convert.ToString(IntVal)); }
            return retVal;
        }


        public static List<Coins> ConvertStrListToCoinsList(List<string> lstCoinDenomWAmounts)
        {
            var retVal = new List<Coins>();

            var c = 0; var v = 0;
            foreach (string entry in lstCoinDenomWAmounts)
            {
                v = Convert.ToInt32(entry.Split(char.Parse("#"))[0]);
                c = Convert.ToInt32(entry.Split(char.Parse("#"))[1]);
                retVal.Add(new Coins(v, c));
            }
            retVal.Sort((a, b) => a.Value.CompareTo(b.Value));
            retVal.Reverse(); return retVal;
        }

        public static List<string> ConvertCoinsListToStrList(List<Coins> lstCoinDenomWAmounts)
        {
            var retVal = new List<string>(); var vc = "";
            lstCoinDenomWAmounts.Sort((a, b) => a.Value.CompareTo(b.Value));

            foreach (Coins entry in lstCoinDenomWAmounts)
            { vc = entry.Value + "#" + entry.Amount; retVal.Add(vc); }
            return retVal;
        }
        public static List<int> ConvertStrListToIntList(List<string> stringList)
        {
            var retVal = new List<int>();
            foreach (string entry in stringList)
            { retVal.Add(int.Parse(entry)); }
            return retVal;
        }
    }
}
