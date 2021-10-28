
namespace VendingMachine
{
    partial class AddCoinWAmount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwCoinsWAmounts = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRemoveCoin = new System.Windows.Forms.Button();
            this.btnAddCoinWCount = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCoinCount = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwCoinsWAmounts
            // 
            this.lvwCoinsWAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCoinsWAmounts.FullRowSelect = true;
            this.lvwCoinsWAmounts.HideSelection = false;
            this.lvwCoinsWAmounts.Location = new System.Drawing.Point(17, 99);
            this.lvwCoinsWAmounts.MultiSelect = false;
            this.lvwCoinsWAmounts.Name = "lvwCoinsWAmounts";
            this.lvwCoinsWAmounts.Size = new System.Drawing.Size(214, 166);
            this.lvwCoinsWAmounts.TabIndex = 15;
            this.lvwCoinsWAmounts.UseCompatibleStateImageBehavior = false;
            this.lvwCoinsWAmounts.View = System.Windows.Forms.View.Details;
            this.lvwCoinsWAmounts.SelectedIndexChanged += new System.EventHandler(this.lvwCoinsWAmounts_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(168, 64);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 28);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(131, 272);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(100, 28);
            this.btnClearList.TabIndex = 17;
            this.btnClearList.Text = "Clear Coins";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnRemoveCoin
            // 
            this.btnRemoveCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveCoin.Location = new System.Drawing.Point(17, 272);
            this.btnRemoveCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCoin.Name = "btnRemoveCoin";
            this.btnRemoveCoin.Size = new System.Drawing.Size(106, 28);
            this.btnRemoveCoin.TabIndex = 16;
            this.btnRemoveCoin.Text = "Remove Coin";
            this.btnRemoveCoin.UseVisualStyleBackColor = true;
            this.btnRemoveCoin.Click += new System.EventHandler(this.btnRemoveCoin_Click);
            // 
            // btnAddCoinWCount
            // 
            this.btnAddCoinWCount.Enabled = false;
            this.btnAddCoinWCount.Location = new System.Drawing.Point(17, 64);
            this.btnAddCoinWCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCoinWCount.Name = "btnAddCoinWCount";
            this.btnAddCoinWCount.Size = new System.Drawing.Size(143, 28);
            this.btnAddCoinWCount.TabIndex = 13;
            this.btnAddCoinWCount.Text = "Add Coin With Count";
            this.btnAddCoinWCount.UseVisualStyleBackColor = true;
            this.btnAddCoinWCount.Click += new System.EventHandler(this.btnAddCoinWCount_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(128, 10);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Input Coin Count:";
            // 
            // txtCoinCount
            // 
            this.txtCoinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoinCount.Enabled = false;
            this.txtCoinCount.Location = new System.Drawing.Point(128, 32);
            this.txtCoinCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoinCount.Name = "txtCoinCount";
            this.txtCoinCount.Size = new System.Drawing.Size(103, 20);
            this.txtCoinCount.TabIndex = 12;
            this.txtCoinCount.TextChanged += new System.EventHandler(this.txtCoinCount_TextChanged);
            this.txtCoinCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoinCount_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 10);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Input Coin:";
            // 
            // txtCoin
            // 
            this.txtCoin.Location = new System.Drawing.Point(17, 32);
            this.txtCoin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(103, 20);
            this.txtCoin.TabIndex = 11;
            this.txtCoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoin_KeyDown);
            // 
            // AddCoinWAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 311);
            this.ControlBox = false;
            this.Controls.Add(this.lvwCoinsWAmounts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnRemoveCoin);
            this.Controls.Add(this.btnAddCoinWCount);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCoinCount);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCoin);
            this.Name = "AddCoinWAmount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCoinWAmount";
            this.Load += new System.EventHandler(this.AddCoinWAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lvwCoinsWAmounts;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnClearList;
        internal System.Windows.Forms.Button btnRemoveCoin;
        internal System.Windows.Forms.Button btnAddCoinWCount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCoinCount;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCoin;
    }
}