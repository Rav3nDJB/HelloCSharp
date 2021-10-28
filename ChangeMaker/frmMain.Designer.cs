
namespace ChangeMaker
{
    partial class frmMain
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
            this.btnSetCoins = new System.Windows.Forms.Button();
            this.btnSetCoinWValues = new System.Windows.Forms.Button();
            this.btnStartVMachine = new System.Windows.Forms.Button();
            this.btnSVMachWUpsAmts = new System.Windows.Forms.Button();
            this.lvwDenomWValues = new System.Windows.Forms.ListView();
            this.lvwCDenominations = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSetCoins
            // 
            this.btnSetCoins.Location = new System.Drawing.Point(10, 10);
            this.btnSetCoins.MaximumSize = new System.Drawing.Size(133, 23);
            this.btnSetCoins.MinimumSize = new System.Drawing.Size(133, 23);
            this.btnSetCoins.Name = "btnSetCoins";
            this.btnSetCoins.Size = new System.Drawing.Size(133, 23);
            this.btnSetCoins.TabIndex = 0;
            this.btnSetCoins.Text = "Set Coin Denominations";
            this.btnSetCoins.UseVisualStyleBackColor = true;
            // 
            // btnSetCoinWValues
            // 
            this.btnSetCoinWValues.Location = new System.Drawing.Point(322, 10);
            this.btnSetCoinWValues.MaximumSize = new System.Drawing.Size(140, 23);
            this.btnSetCoinWValues.MinimumSize = new System.Drawing.Size(140, 23);
            this.btnSetCoinWValues.Name = "btnSetCoinWValues";
            this.btnSetCoinWValues.Size = new System.Drawing.Size(140, 23);
            this.btnSetCoinWValues.TabIndex = 1;
            this.btnSetCoinWValues.Text = "Set Coin Denom && Values";
            this.btnSetCoinWValues.UseVisualStyleBackColor = true;
            // 
            // btnStartVMachine
            // 
            this.btnStartVMachine.Location = new System.Drawing.Point(12, 316);
            this.btnStartVMachine.MaximumSize = new System.Drawing.Size(133, 23);
            this.btnStartVMachine.MinimumSize = new System.Drawing.Size(133, 23);
            this.btnStartVMachine.Name = "btnStartVMachine";
            this.btnStartVMachine.Size = new System.Drawing.Size(133, 23);
            this.btnStartVMachine.TabIndex = 2;
            this.btnStartVMachine.Text = "Start Vending Machine";
            this.btnStartVMachine.UseVisualStyleBackColor = true;
            // 
            // btnSVMachWUpsAmts
            // 
            this.btnSVMachWUpsAmts.Location = new System.Drawing.Point(302, 316);
            this.btnSVMachWUpsAmts.MaximumSize = new System.Drawing.Size(160, 23);
            this.btnSVMachWUpsAmts.MinimumSize = new System.Drawing.Size(160, 23);
            this.btnSVMachWUpsAmts.Name = "btnSVMachWUpsAmts";
            this.btnSVMachWUpsAmts.Size = new System.Drawing.Size(160, 23);
            this.btnSVMachWUpsAmts.TabIndex = 3;
            this.btnSVMachWUpsAmts.Text = "Start Updating VMachine";
            this.btnSVMachWUpsAmts.UseVisualStyleBackColor = true;
            // 
            // lvwDenomWValues
            // 
            this.lvwDenomWValues.HideSelection = false;
            this.lvwDenomWValues.Location = new System.Drawing.Point(261, 39);
            this.lvwDenomWValues.MinimumSize = new System.Drawing.Size(160, 190);
            this.lvwDenomWValues.Name = "lvwDenomWValues";
            this.lvwDenomWValues.Size = new System.Drawing.Size(200, 270);
            this.lvwDenomWValues.TabIndex = 4;
            this.lvwDenomWValues.UseCompatibleStateImageBehavior = false;
            // 
            // lvwCDenominations
            // 
            this.lvwCDenominations.HideSelection = false;
            this.lvwCDenominations.Location = new System.Drawing.Point(12, 39);
            this.lvwCDenominations.Name = "lvwCDenominations";
            this.lvwCDenominations.Size = new System.Drawing.Size(243, 270);
            this.lvwCDenominations.TabIndex = 4;
            this.lvwCDenominations.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.lvwDenomWValues);
            this.Controls.Add(this.lvwCDenominations);
            this.Controls.Add(this.btnSVMachWUpsAmts);
            this.Controls.Add(this.btnStartVMachine);
            this.Controls.Add(this.btnSetCoinWValues);
            this.Controls.Add(this.btnSetCoins);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(490, 390);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetCoins;
        private System.Windows.Forms.Button btnSetCoinWValues;
        private System.Windows.Forms.Button btnStartVMachine;
        private System.Windows.Forms.Button btnSVMachWUpsAmts;
        private System.Windows.Forms.ListView lvwDenomWValues;
        private System.Windows.Forms.ListView lvwCDenominations;
    }
}