using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class AddCoin : Form
    {
        public List<string> lstCoinDenom = new List<string>();
        public AddCoin()
        {
            InitializeComponent();
        }

        private void AddCoin_Load(object sender, EventArgs e)
        {
            if (lstCoinDenom.Count > 0)
            {
                lstCoinDenom = Methods.SortStrListAsIntList(lstCoinDenom);
                lbxDenominations.Items.AddRange(lstCoinDenom.ToArray());
            }
        }

        private void txtCoin_TextChanged(object sender, EventArgs e)
        {
            if ((txtCoin.TextLength > 0) && (Methods.StringValidate(txtCoin.Text) == true) && (int.Parse(txtCoin.Text) > 0) &&
                (lbxDenominations.Items.Contains(txtCoin.Text) == false))
            { btnAddCoin.Enabled = true; }
            else
            { btnAddCoin.Enabled = false; }
        }

        private void btnAddCoin_Click(object sender, EventArgs e)
        {
            lbxDenominations.Items.Add(txtCoin.Text);
            lstCoinDenom.Add(txtCoin.Text);
            Methods.SaveDenominationList(lbxDenominations.Items);
            txtCoin.Text = ""; txtCoin.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            Methods.SaveDenominationList(lstCoinDenom);
            formMain.PopluateCoinDenom(lstCoinDenom);
            formMain.Show(); this.Close();
        }

        private void btnRemoveCoin_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure you want to \nremove " + Convert.ToString(lbxDenominations.Items[lbxDenominations.Items.IndexOf(lbxDenominations.SelectedItem)]) + " from index " + Convert.ToString(lbxDenominations.SelectedIndex) + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                lstCoinDenom.Remove(lbxDenominations.SelectedItem.ToString());
                lbxDenominations.Items.RemoveAt(lbxDenominations.SelectedIndex);
                Methods.SaveDenominationList(lbxDenominations.Items);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbxDenominations.Items.Clear();
            lstCoinDenom.Clear();
            Methods.SaveDenominationList(lbxDenominations.Items);
        }

        private void lbxDenominations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDenominations.SelectedIndex > -1)
            { btnRemoveCoin.Enabled = true; }
            else
            { btnRemoveCoin.Enabled = false; }
        }

        private void txtCoin_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && (txtCoin.TextLength > 0) &&
                    (Methods.StringValidate(txtCoin.Text)) && (int.Parse(txtCoin.Text) > 0) &&
                    (lbxDenominations.Items.Contains(txtCoin.Text) == false))
            {
                lbxDenominations.Items.Add(txtCoin.Text);
                Methods.SaveDenominationList(lbxDenominations.Items);
                lstCoinDenom.Add(txtCoin.Text);
                txtCoin.Text = ""; txtCoin.Focus();
            }
        }
    }
}
