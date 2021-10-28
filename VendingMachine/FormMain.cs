using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class FormMain : Form
    {
        public List<string> lstCoinDenominations { get; set; } = new List<string>();
        public List<string> lstCoinDenomWAmounts { get; set; } = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSetCoins_Click(object sender, EventArgs e)
        {
            AddCoin addCoin = new AddCoin();
            addCoin.lstCoinDenom = lstCoinDenominations;
            this.Hide(); addCoin.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lvwCDenominations.Columns.Add("Coin Value", 100, HorizontalAlignment.Center);
            lvwDenomWValues.Columns.Add("Coin", 100, HorizontalAlignment.Center);
            lvwDenomWValues.Columns.Add("Count", 100, HorizontalAlignment.Center);

            lstCoinDenominations.Clear();
            if (File.Exists(Application.CommonAppDataPath + "\\CoinDenominations.txt"))
            {
                lstCoinDenominations.AddRange(File.ReadAllLines(Application.CommonAppDataPath + "\\CoinDenominations.txt").ToList());
            }

            lstCoinDenomWAmounts.Clear();
            if (File.Exists(Application.CommonAppDataPath + "\\CoinDenomWAmount.txt"))
            {
                lstCoinDenomWAmounts.AddRange(File.ReadAllLines(Application.CommonAppDataPath + "\\CoinDenomWAmount.txt").ToList());
            }

            lstCoinDenominations = Methods.SortStrListAsIntList(lstCoinDenominations);
            PopluateCoinDenom(lstCoinDenominations);
            PopulateCDenomWAmounts(lstCoinDenomWAmounts);
        }
        private void btnSetCoinWValues_Click(object sender, EventArgs e)
        {
            AddCoinWAmount addCoinWAmount = new AddCoinWAmount();
            addCoinWAmount.lstCoinsWCounters = Methods.SetCoinDenomination(lstCoinDenomWAmounts);
            this.Hide(); addCoinWAmount.Show();
        }

        private void btnStartVMachine_Click(object sender, EventArgs e)
        {
            VendMach vendMach = new VendMach();
            vendMach.lstCDenom = lstCoinDenominations;
            this.Hide(); vendMach.Show();
        }

        private void btnSVMachWUpsAmts_Click(object sender, EventArgs e)
        {
            VendMachWCCount vendMachWCCount = new VendMachWCCount();
            vendMachWCCount.lstCDenomWAmnts = Methods.ConvertStrListToCoinsList(lstCoinDenomWAmounts);
            this.Hide(); vendMachWCCount.Show();
        }
        public void PopluateCoinDenom(List<string> lstCoinDenom)
        {
            lvwCDenominations.Items.Clear();
            foreach (string coin in lstCoinDenom)
            {
                var lvwItem = new ListViewItem(coin);
                lvwCDenominations.Items.Add(lvwItem);
            }
        }

        public void PopulateCDenomWAmounts(List<string> coinList)
        {
            lvwDenomWValues.Items.Clear();
            lstCoinDenomWAmounts = coinList;
            foreach (string coin in lstCoinDenomWAmounts)
            {
                var newC = new Coins(Convert.ToInt32(coin.Split(("#").ToCharArray())[0]), Convert.ToInt32(coin.Split(("#".ToCharArray()))[1]));
                var lvwItem = new ListViewItem();
                var lvSItemVal = new ListViewItem.ListViewSubItem(lvwItem, newC.Value.ToString());
                var lvSItemCtr = new ListViewItem.ListViewSubItem(lvwItem, newC.Amount.ToString());
                lvwItem.SubItems.Add(lvSItemVal);
                lvwItem.SubItems.Add(lvSItemCtr);
                lvwItem.SubItems.RemoveAt(0);
                lvwDenomWValues.Items.Add(lvwItem);
            }
        }

        private static void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
