
namespace VendingMachine
{
    partial class VendMachWCCount
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lvwOutput = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTendered = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(63, 191);
            this.lstOutput.MinimumSize = new System.Drawing.Size(171, 121);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(171, 121);
            this.lstOutput.TabIndex = 18;
            // 
            // lvwOutput
            // 
            this.lvwOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwOutput.HideSelection = false;
            this.lvwOutput.Location = new System.Drawing.Point(63, 34);
            this.lvwOutput.MinimumSize = new System.Drawing.Size(171, 82);
            this.lvwOutput.Name = "lvwOutput";
            this.lvwOutput.Size = new System.Drawing.Size(171, 151);
            this.lvwOutput.TabIndex = 17;
            this.lvwOutput.UseCompatibleStateImageBehavior = false;
            this.lvwOutput.View = System.Windows.Forms.View.Details;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(7, 289);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(7, 162);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(50, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Confirm";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTendered
            // 
            this.txtTendered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTendered.Enabled = false;
            this.txtTendered.Location = new System.Drawing.Point(184, 8);
            this.txtTendered.Name = "txtTendered";
            this.txtTendered.Size = new System.Drawing.Size(50, 20);
            this.txtTendered.TabIndex = 14;
            this.txtTendered.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTendered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTendered_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(67, 8);
            this.txtTotal.MinimumSize = new System.Drawing.Size(50, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(129, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Tendered:";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label4.Location = new System.Drawing.Point(7, 191);
            this.Label4.MaximumSize = new System.Drawing.Size(50, 15);
            this.Label4.MinimumSize = new System.Drawing.Size(50, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 15);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Change:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 34);
            this.Label2.MaximumSize = new System.Drawing.Size(50, 26);
            this.Label2.MinimumSize = new System.Drawing.Size(50, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 26);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Available Change:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Amount:";
            // 
            // VendMachWCCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 321);
            this.ControlBox = false;
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lvwOutput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTendered);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendMachWCCount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VendMachWCCount";
            this.Load += new System.EventHandler(this.VendMachWCCount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstOutput;
        internal System.Windows.Forms.ListView lvwOutput;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.TextBox txtTendered;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}