using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class VendMachWCCount : Form
    {
        public List<Coins> lstCDenomWAmnts { get; set; } = new List<Coins>();

        public VendMachWCCount()
        {
            InitializeComponent();
        }

        private void VendMachWCCount_Load(object sender, EventArgs e)
        {
            lvwOutput.Columns.Add("Coin", 50, HorizontalAlignment.Left);
            lvwOutput.Columns.Add("Count", 50, HorizontalAlignment.Left);

            if (lstCDenomWAmnts.Count > 0)
            { PopulateListview(); }

            btnCalculate.Enabled = false; txtTotal.Focus();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (((txtTotal.TextLength > 0) && (txtTendered.TextLength > 0)) &&
                (Methods.StringValidate(txtTotal.Text)
                && Methods.StringValidate(txtTendered.Text))
                && (int.Parse(txtTotal.Text) <= int.Parse(txtTendered.Text)))
            { btnCalculate.Enabled = true; }
            else
            { btnCalculate.Enabled = false; }
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtTotal.TextLength > 0)
                && (Methods.StringValidate(txtTotal.Text)))
            {
                txtTotal.Enabled = false; txtTendered.Enabled = true;
                txtTendered.Focus();
            }
        }

        private void txtTendered_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtTotal.TextLength > 0
                && txtTendered.TextLength > 0)
                && (Methods.StringValidate(txtTotal.Text)
                && Methods.StringValidate(txtTendered.Text))
     && (int.Parse(txtTotal.Text) <= int.Parse(txtTendered.Text)))
            { if (btnCalculate.Enabled) { btnCalculate_Click(sender, e); } }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear(); var changeAmount = 0;
            var totalAmount = int.Parse(txtTotal.Text);
            var tenderAmount = int.Parse(txtTendered.Text);

            changeAmount = tenderAmount - totalAmount;

            lstCDenomWAmnts.Sort(delegate (Coins a, Coins b) { return a.Value.CompareTo(b.Value); });
            lstCDenomWAmnts.Reverse();

            var outputList = new List<string>();
            outputList.Add("Change: " + Convert.ToString(tenderAmount) + " - " + Convert.ToString(totalAmount) + " = " + Convert.ToString(changeAmount));
            outputList.Add(""); lvwOutput.Items.Clear();

            foreach (var coin in lstCDenomWAmnts)
            {
                var c = 0;
                while (changeAmount >= coin.Value)
                { c++; changeAmount -= coin.Value; }
                outputList.Add("C: " + Convert.ToString(coin.Value) + " Rem C: " + Convert.ToString(coin.Amount - c) + " CCnt: " + Convert.ToString(c) + " Total: " + Convert.ToString(coin.Value * c));
                coin.Amount -= c; AddItemToListView(coin);
            }
            Methods.SaveDenominationWAmntList(Methods.ConvertCoinsListToStrList(lstCDenomWAmnts));

            lstOutput.Items.AddRange(outputList.ToArray());
            txtTotal.Text = ""; txtTendered.Text = "";
            txtTotal.Enabled = true; txtTendered.Enabled = false;
            btnCalculate.Enabled = false; txtTotal.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (var formMain = new FormMain())
            {
                formMain.PopulateCDenomWAmounts(Methods.ConvertCoinsListToStrList(lstCDenomWAmnts));
                formMain.Show();
                this.Close();
            }
        }

        private void PopulateListview()
        {
            foreach (var coin in lstCDenomWAmnts)
            { AddItemToListView(coin); }
        }

        private void AddItemToListView(Coins coin)
        {
            var lvItem = new ListViewItem();
            var lvSItemVal = new ListViewItem.ListViewSubItem(lvItem, coin.Value.ToString());
            var lvSItemAm = new ListViewItem.ListViewSubItem(lvItem, coin.Amount.ToString());
            lvItem.SubItems.Add(lvSItemVal);
            lvItem.SubItems.Add(lvSItemAm);
            lvItem.SubItems.RemoveAt(0);

            lvwOutput.Items.Add(lvItem);
        }

    }
}
