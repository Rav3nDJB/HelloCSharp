
namespace VendingMachine
{
    partial class AddCoin
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
            this.lbxDenominations = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRemoveCoin = new System.Windows.Forms.Button();
            this.btnAddCoin = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxDenominations
            // 
            this.lbxDenominations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDenominations.FormattingEnabled = true;
            this.lbxDenominations.Location = new System.Drawing.Point(17, 99);
            this.lbxDenominations.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDenominations.MinimumSize = new System.Drawing.Size(135, 164);
            this.lbxDenominations.Name = "lbxDenominations";
            this.lbxDenominations.Size = new System.Drawing.Size(135, 160);
            this.lbxDenominations.TabIndex = 11;
            this.lbxDenominations.SelectedIndexChanged += new System.EventHandler(this.lbxDenominations_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(89, 63);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 28);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(100, 273);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(52, 28);
            this.btnClearList.TabIndex = 13;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnRemoveCoin
            // 
            this.btnRemoveCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveCoin.Location = new System.Drawing.Point(17, 273);
            this.btnRemoveCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCoin.Name = "btnRemoveCoin";
            this.btnRemoveCoin.Size = new System.Drawing.Size(73, 28);
            this.btnRemoveCoin.TabIndex = 12;
            this.btnRemoveCoin.Text = "Remove";
            this.btnRemoveCoin.UseVisualStyleBackColor = true;
            this.btnRemoveCoin.Click += new System.EventHandler(this.btnRemoveCoin_Click);
            // 
            // btnAddCoin
            // 
            this.btnAddCoin.Enabled = false;
            this.btnAddCoin.Location = new System.Drawing.Point(17, 63);
            this.btnAddCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCoin.Name = "btnAddCoin";
            this.btnAddCoin.Size = new System.Drawing.Size(63, 28);
            this.btnAddCoin.TabIndex = 9;
            this.btnAddCoin.Text = "Add";
            this.btnAddCoin.UseVisualStyleBackColor = true;
            this.btnAddCoin.Click += new System.EventHandler(this.btnAddCoin_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Input Coin Value:";
            // 
            // txtCoin
            // 
            this.txtCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoin.Location = new System.Drawing.Point(17, 31);
            this.txtCoin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(135, 20);
            this.txtCoin.TabIndex = 8;
            this.txtCoin.TextChanged += new System.EventHandler(this.txtCoin_TextChanged);
            this.txtCoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoin_KeyDown);
            // 
            // AddCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 311);
            this.ControlBox = false;
            this.Controls.Add(this.lbxDenominations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnRemoveCoin);
            this.Controls.Add(this.btnAddCoin);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCoin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCoin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCoin";
            this.Load += new System.EventHandler(this.AddCoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lbxDenominations;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnClearList;
        internal System.Windows.Forms.Button btnRemoveCoin;
        internal System.Windows.Forms.Button btnAddCoin;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCoin;
    }
}