using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class VendMach : Form
    {
        public List<string> lstCDenom { get; set; } = new List<string>();

        public VendMach()
        {
            InitializeComponent();
        }

        private void VendMach_Load(object sender, EventArgs e)
        {
            txtTotal.Focus(); btnCalculate.Enabled = false;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (((txtTotal.TextLength > 0) && (txtTendered.TextLength > 0)) &&
                (Methods.StringValidate(txtTotal.Text) &&
                    Methods.StringValidate(txtTendered.Text)) &&
                    (int.Parse(txtTotal.Text) <= int.Parse(txtTendered.Text)))
            { btnCalculate.Enabled = true; }
            else
            { btnCalculate.Enabled = false; }
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtTotal.TextLength > 0) &&
                (Methods.StringValidate(txtTotal.Text)))
            {
                txtTendered.Enabled = true; txtTendered.Focus();
                txtTotal.Enabled = false;
            }
        }

        private void txtTendered_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtTotal.TextLength > 0 &&
                txtTendered.TextLength > 0) &&
                (Methods.StringValidate(txtTotal.Text) &&
                    Methods.StringValidate(txtTendered.Text)) &&
                    (int.Parse(txtTotal.Text) <= int.Parse(txtTendered.Text)))
            {
                if (btnCalculate.Enabled)
                { btnCalculate_Click(sender, e); }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear(); var changeAmount = 0;
            var totalAmount = int.Parse(txtTotal.Text);
            var tenderAmount = int.Parse(txtTendered.Text);

            changeAmount = tenderAmount - totalAmount;
           var checkList = Methods.ConvertStrListToIntList(lstCDenom);
            checkList.Sort(); checkList.Reverse();

            var outputList = new List<string>();
            outputList.Add("Change: " + Convert.ToString(tenderAmount) +
                " - " + Convert.ToString(totalAmount) + " = " +
                Convert.ToString(changeAmount));
            outputList.Add("");

            foreach (int coin in checkList)
            {
                var c = 0;
                while (changeAmount >= coin)
                { c++; changeAmount -= coin; }

                outputList.Add("Coin: " + Convert.ToString(coin) + " Amount: "
                    + Convert.ToString(c) + " Total: " + (coin) * c);
            }
            lstOutput.Items.AddRange(outputList.ToArray());
            txtTotal.Text = ""; txtTendered.Text = "";
            txtTotal.Enabled = true; txtTendered.Enabled = false;
            btnCalculate.Enabled = false; txtTotal.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (var formMain = new FormMain())
            {
                Methods.SaveDenominationList(lstCDenom);
                formMain.PopluateCoinDenom(lstCDenom);
                formMain.Show(); this.Close();
            }
        }
    }
}
