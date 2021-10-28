using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeMaker
{
    public partial class frmMain : Form
    {
        private Button btnDenominateCoins;
        private Button button1;
        private Label lblCoins;

        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnDenominateCoins = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDenominateCoins
            // 
            this.btnDenominateCoins.Location = new System.Drawing.Point(285, 38);
            this.btnDenominateCoins.Name = "btnDenominateCoins";
            this.btnDenominateCoins.Size = new System.Drawing.Size(99, 41);
            this.btnDenominateCoins.TabIndex = 0;
            this.btnDenominateCoins.Text = "Add Coin Denomination";
            this.btnDenominateCoins.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset Coin Denomination";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCoins
            // 
            this.lblCoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoins.Location = new System.Drawing.Point(117, 38);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(162, 41);
            this.lblCoins.TabIndex = 1;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(593, 496);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDenominateCoins);
            this.Name = "frmMain";
            this.ResumeLayout(false);

        }
    }
}
