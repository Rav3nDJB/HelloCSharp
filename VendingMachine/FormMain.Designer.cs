
namespace VendingMachine
{
    partial class FormMain
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
            this.btnSVMachWUpsAmts = new System.Windows.Forms.Button();
            this.btnStartVMachine = new System.Windows.Forms.Button();
            this.lvwDenomWValues = new System.Windows.Forms.ListView();
            this.btnSetCoinWValues = new System.Windows.Forms.Button();
            this.lvwCDenominations = new System.Windows.Forms.ListView();
            this.btnSetCoins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSVMachWUpsAmts
            // 
            this.btnSVMachWUpsAmts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSVMachWUpsAmts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVMachWUpsAmts.Location = new System.Drawing.Point(300, 317);
            this.btnSVMachWUpsAmts.Name = "btnSVMachWUpsAmts";
            this.btnSVMachWUpsAmts.Size = new System.Drawing.Size(160, 23);
            this.btnSVMachWUpsAmts.TabIndex = 9;
            this.btnSVMachWUpsAmts.Text = "Start Updating VMachine";
            this.btnSVMachWUpsAmts.UseVisualStyleBackColor = true;
            this.btnSVMachWUpsAmts.Click += new System.EventHandler(this.btnSVMachWUpsAmts_Click);
            // 
            // btnStartVMachine
            // 
            this.btnStartVMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartVMachine.Location = new System.Drawing.Point(11, 316);
            this.btnStartVMachine.Name = "btnStartVMachine";
            this.btnStartVMachine.Size = new System.Drawing.Size(133, 23);
            this.btnStartVMachine.TabIndex = 10;
            this.btnStartVMachine.Text = "Start Vending Machine";
            this.btnStartVMachine.UseVisualStyleBackColor = true;
            this.btnStartVMachine.Click += new System.EventHandler(this.btnStartVMachine_Click);
            // 
            // lvwDenomWValues
            // 
            this.lvwDenomWValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDenomWValues.HideSelection = false;
            this.lvwDenomWValues.Location = new System.Drawing.Point(261, 39);
            this.lvwDenomWValues.MinimumSize = new System.Drawing.Size(160, 190);
            this.lvwDenomWValues.Name = "lvwDenomWValues";
            this.lvwDenomWValues.Size = new System.Drawing.Size(200, 270);
            this.lvwDenomWValues.TabIndex = 8;
            this.lvwDenomWValues.UseCompatibleStateImageBehavior = false;
            this.lvwDenomWValues.View = System.Windows.Forms.View.Details;
            // 
            // btnSetCoinWValues
            // 
            this.btnSetCoinWValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCoinWValues.Location = new System.Drawing.Point(324, 10);
            this.btnSetCoinWValues.Name = "btnSetCoinWValues";
            this.btnSetCoinWValues.Size = new System.Drawing.Size(140, 23);
            this.btnSetCoinWValues.TabIndex = 6;
            this.btnSetCoinWValues.Text = "Set Coin Denom && Values";
            this.btnSetCoinWValues.UseVisualStyleBackColor = true;
            this.btnSetCoinWValues.Click += new System.EventHandler(this.btnSetCoinWValues_Click);
            // 
            // lvwCDenominations
            // 
            this.lvwCDenominations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwCDenominations.FullRowSelect = true;
            this.lvwCDenominations.HideSelection = false;
            this.lvwCDenominations.Location = new System.Drawing.Point(11, 39);
            this.lvwCDenominations.MinimumSize = new System.Drawing.Size(130, 190);
            this.lvwCDenominations.Name = "lvwCDenominations";
            this.lvwCDenominations.Size = new System.Drawing.Size(243, 270);
            this.lvwCDenominations.TabIndex = 7;
            this.lvwCDenominations.UseCompatibleStateImageBehavior = false;
            this.lvwCDenominations.View = System.Windows.Forms.View.Details;
            // 
            // btnSetCoins
            // 
            this.btnSetCoins.Location = new System.Drawing.Point(11, 10);
            this.btnSetCoins.Name = "btnSetCoins";
            this.btnSetCoins.Size = new System.Drawing.Size(133, 23);
            this.btnSetCoins.TabIndex = 5;
            this.btnSetCoins.Text = "Set Coin Denominations";
            this.btnSetCoins.UseVisualStyleBackColor = true;
            this.btnSetCoins.Click += new System.EventHandler(this.btnSetCoins_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.btnSVMachWUpsAmts);
            this.Controls.Add(this.btnStartVMachine);
            this.Controls.Add(this.lvwDenomWValues);
            this.Controls.Add(this.btnSetCoinWValues);
            this.Controls.Add(this.lvwCDenominations);
            this.Controls.Add(this.btnSetCoins);
            this.MinimumSize = new System.Drawing.Size(490, 390);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormMain.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSVMachWUpsAmts;
        internal System.Windows.Forms.Button btnStartVMachine;
        internal System.Windows.Forms.ListView lvwDenomWValues;
        internal System.Windows.Forms.Button btnSetCoinWValues;
        internal System.Windows.Forms.ListView lvwCDenominations;
        internal System.Windows.Forms.Button btnSetCoins;
    }
}

