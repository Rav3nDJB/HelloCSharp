using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class AddCoinWAmount : Form
    {
        public List<string> lstCoinsWCounters { get; set; } = new List<string>();

        public AddCoinWAmount()
        {
            InitializeComponent();
        }

        private void AddCoinWAmount_Load(object sender, EventArgs e)
        {
            lvwCoinsWAmounts.Columns.Add("Coin", 100, HorizontalAlignment.Center);
            lvwCoinsWAmounts.Columns.Add("Count", 100, HorizontalAlignment.Center);

            foreach (string coin in lstCoinsWCounters)
            {
                Coins newC = new Coins(Convert.ToInt32(coin.Split(("#").ToCharArray())[0]), Convert.ToInt32(coin.Split(("#").ToCharArray())[1]));
                ListViewItem lvwItem = new ListViewItem();
                ListViewItem.ListViewSubItem lvSItemVal = new ListViewItem.ListViewSubItem(lvwItem, newC.Value.ToString());
                ListViewItem.ListViewSubItem lvSItemCtr = new ListViewItem.ListViewSubItem(lvwItem, newC.Amount.ToString());
                lvwItem.SubItems.Add(lvSItemVal);
                lvwItem.SubItems.Add(lvSItemCtr);
                lvwItem.SubItems.RemoveAt(0);
                lvwCoinsWAmounts.Items.Add(lvwItem);
            }

            if (lvwCoinsWAmounts.Items.Count == 0)
            {
                btnRemoveCoin.Enabled = false;
                btnClearList.Enabled = false;
            }
            else if (lvwCoinsWAmounts.Items.Count > 0)
            { btnClearList.Enabled = true; }
            txtCoin.Focus();
        }

        private void txtCoin_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && (txtCoin.TextLength > 0) &&
                (Methods.StringValidate(txtCoin.Text)))
            {
                bool ContainsCoin = false;
                foreach (ListViewItem lvItem in lvwCoinsWAmounts.Items)
                {
                    foreach (ListViewItem.ListViewSubItem SItem in lvItem.SubItems)
                    {
                        if (lvItem.Index == 0)
                        {
                            if (SItem.Text == txtCoin.Text)
                            { ContainsCoin = true; break; }
                        }
                    }
                    if (ContainsCoin) { break; }
                }
                if (!ContainsCoin)
                { disEnableAllCtlExCCount(false); }
                else
                {
                    MessageBox.Show("Coin already exists!");
                    txtCoin.Text = ""; txtCoin.Focus();
                }
            }
        }

        private void txtCoinCount_TextChanged(object sender, EventArgs e)
        {
            if ((txtCoinCount.TextLength > 0 && txtCoin.TextLength > 0) &&
                (Methods.StringValidate(txtCoinCount.Text) &&
                Methods.StringValidate(txtCoin.Text)))
            { btnAddCoinWCount.Enabled = true; }
            else
            { btnAddCoinWCount.Enabled = false; }
        }

        private void txtCoinCount_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && (txtCoinCount.TextLength > 0) &&
                (Methods.StringValidate(txtCoinCount.Text)))
            {
                AddCoinWCount();
                Methods.SaveDenominationWAmntList(lstCoinsWCounters);
                disEnableAllCtlExCCount(true);
            }
        }

        private void lvwCoinsWAmounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCoinsWAmounts.SelectedItems.Count > 0)
            { btnRemoveCoin.Enabled = true; }
            else
            { btnRemoveCoin.Enabled = false; }
        }

        private void btnAddCoinWCount_Click(object sender, EventArgs e)
        {
            AddCoinWCount();
            Methods.SaveDenominationWAmntList(lstCoinsWCounters);
            disEnableAllCtlExCCount(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.PopulateCDenomWAmounts(lstCoinsWCounters);
            Methods.SaveDenominationWAmntList(lstCoinsWCounters);
            formMain.Show(); this.Close();
        }

        private void btnRemoveCoin_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure you want to \nremove " + lvwCoinsWAmounts.SelectedItems[0].SubItems[0].Text + " from index " + Convert.ToString(lvwCoinsWAmounts.SelectedItems[0].Index) + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                var tString = lvwCoinsWAmounts.SelectedItems[0].SubItems[0].Text + "#" + lvwCoinsWAmounts.SelectedItems[0].SubItems[1].Text;
                var tIndex = lstCoinsWCounters.IndexOf(tString);
                lstCoinsWCounters.RemoveAt(tIndex);
                lvwCoinsWAmounts.Items.RemoveAt(lvwCoinsWAmounts.SelectedItems[0].Index);
                Methods.SaveDenominationWAmntList(lstCoinsWCounters);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lvwCoinsWAmounts.Items.Clear();
            lstCoinsWCounters.Clear();
            Methods.SaveDenominationWAmntList(lstCoinsWCounters);
        }
        private void disEnableAllCtlExCCount(bool blnVal)
        {
            txtCoin.Enabled = blnVal; btnAddCoinWCount.Enabled = blnVal;
            btnBack.Enabled = blnVal; lvwCoinsWAmounts.Enabled = blnVal;
            btnClearList.Enabled = blnVal; btnRemoveCoin.Enabled = blnVal;
            txtCoinCount.Enabled = !blnVal;

            if (!txtCoinCount.Enabled)
            { txtCoin.Focus(); txtCoin.Text = ""; txtCoinCount.Text = ""; }
            else
            { txtCoinCount.Focus(); }
        }

        private void AddCoinWCount()
        {
            ListViewItem lvItem = new ListViewItem();
            ListViewItem.ListViewSubItem lvSItmVal = new ListViewItem.ListViewSubItem(lvItem, txtCoin.Text);
            ListViewItem.ListViewSubItem lvSItmCtr = new ListViewItem.ListViewSubItem(lvItem, txtCoinCount.Text);
            lstCoinsWCounters.Add(txtCoin.Text + "#" + txtCoinCount.Text);
            lvItem.SubItems.Add(lvSItmVal);
            lvItem.SubItems.Add(lvSItmCtr);
            lvItem.SubItems.RemoveAt(0);
            lvwCoinsWAmounts.Items.Add(lvItem);
        }
    }
}
