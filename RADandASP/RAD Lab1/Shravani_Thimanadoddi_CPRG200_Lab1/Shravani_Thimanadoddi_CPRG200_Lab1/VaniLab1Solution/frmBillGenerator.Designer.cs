namespace VaniLab1Solution
{
    partial class frmBillGenerator
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpBoxCustomerType = new System.Windows.Forms.GroupBox();
            this.rbtnIndustrial = new System.Windows.Forms.RadioButton();
            this.rbtnCommercial = new System.Windows.Forms.RadioButton();
            this.rbtnResidential = new System.Windows.Forms.RadioButton();
            this.lblPowerUsed = new System.Windows.Forms.Label();
            this.txtInputPowerUsed = new System.Windows.Forms.TextBox();
            this.pnlIndustrial = new System.Windows.Forms.Panel();
            this.txtOffpeakUsage = new System.Windows.Forms.TextBox();
            this.lblOffpeak = new System.Windows.Forms.Label();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.pnlResidentialCommercial = new System.Windows.Forms.Panel();
            this.grpBoxCustomerType.SuspendLayout();
            this.pnlIndustrial.SuspendLayout();
            this.pnlResidentialCommercial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(175, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(409, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Electricity Bill";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxCustomerType
            // 
            this.grpBoxCustomerType.Controls.Add(this.rbtnIndustrial);
            this.grpBoxCustomerType.Controls.Add(this.rbtnCommercial);
            this.grpBoxCustomerType.Controls.Add(this.rbtnResidential);
            this.grpBoxCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCustomerType.Location = new System.Drawing.Point(105, 111);
            this.grpBoxCustomerType.Name = "grpBoxCustomerType";
            this.grpBoxCustomerType.Size = new System.Drawing.Size(535, 100);
            this.grpBoxCustomerType.TabIndex = 1;
            this.grpBoxCustomerType.TabStop = false;
            this.grpBoxCustomerType.Text = "Select Customer Type";
            // 
            // rbtnIndustrial
            // 
            this.rbtnIndustrial.AutoSize = true;
            this.rbtnIndustrial.Location = new System.Drawing.Point(385, 42);
            this.rbtnIndustrial.Name = "rbtnIndustrial";
            this.rbtnIndustrial.Size = new System.Drawing.Size(102, 24);
            this.rbtnIndustrial.TabIndex = 2;
            this.rbtnIndustrial.Text = "Industrial";
            this.rbtnIndustrial.UseVisualStyleBackColor = true;
            this.rbtnIndustrial.CheckedChanged += new System.EventHandler(this.rbtnIndustrial_CheckedChanged);
            // 
            // rbtnCommercial
            // 
            this.rbtnCommercial.AutoSize = true;
            this.rbtnCommercial.Location = new System.Drawing.Point(207, 42);
            this.rbtnCommercial.Name = "rbtnCommercial";
            this.rbtnCommercial.Size = new System.Drawing.Size(120, 24);
            this.rbtnCommercial.TabIndex = 1;
            this.rbtnCommercial.Text = "Commercial";
            this.rbtnCommercial.UseVisualStyleBackColor = true;
            this.rbtnCommercial.CheckedChanged += new System.EventHandler(this.rbtnCommercial_CheckedChanged);
            // 
            // rbtnResidential
            // 
            this.rbtnResidential.AutoSize = true;
            this.rbtnResidential.Checked = true;
            this.rbtnResidential.Location = new System.Drawing.Point(31, 42);
            this.rbtnResidential.Name = "rbtnResidential";
            this.rbtnResidential.Size = new System.Drawing.Size(117, 24);
            this.rbtnResidential.TabIndex = 0;
            this.rbtnResidential.TabStop = true;
            this.rbtnResidential.Text = "Residential";
            this.rbtnResidential.UseVisualStyleBackColor = true;
            this.rbtnResidential.CheckedChanged += new System.EventHandler(this.rbtnResidential_CheckedChanged);
            // 
            // lblPowerUsed
            // 
            this.lblPowerUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUsed.Location = new System.Drawing.Point(3, 12);
            this.lblPowerUsed.Name = "lblPowerUsed";
            this.lblPowerUsed.Size = new System.Drawing.Size(234, 28);
            this.lblPowerUsed.TabIndex = 3;
            this.lblPowerUsed.Text = "kWh Used";
            this.lblPowerUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputPowerUsed
            // 
            this.txtInputPowerUsed.Location = new System.Drawing.Point(259, 12);
            this.txtInputPowerUsed.Name = "txtInputPowerUsed";
            this.txtInputPowerUsed.Size = new System.Drawing.Size(143, 26);
            this.txtInputPowerUsed.TabIndex = 4;
            this.txtInputPowerUsed.Tag = "Power Used";
            // 
            // pnlIndustrial
            // 
            this.pnlIndustrial.Controls.Add(this.txtOffpeakUsage);
            this.pnlIndustrial.Controls.Add(this.lblOffpeak);
            this.pnlIndustrial.Location = new System.Drawing.Point(146, 319);
            this.pnlIndustrial.Name = "pnlIndustrial";
            this.pnlIndustrial.Size = new System.Drawing.Size(456, 59);
            this.pnlIndustrial.TabIndex = 5;
            // 
            // txtOffpeakUsage
            // 
            this.txtOffpeakUsage.Location = new System.Drawing.Point(259, 16);
            this.txtOffpeakUsage.Name = "txtOffpeakUsage";
            this.txtOffpeakUsage.Size = new System.Drawing.Size(143, 26);
            this.txtOffpeakUsage.TabIndex = 7;
            this.txtOffpeakUsage.Tag = "kWh Used(OffPeak Hours)";
            // 
            // lblOffpeak
            // 
            this.lblOffpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffpeak.Location = new System.Drawing.Point(10, 14);
            this.lblOffpeak.Name = "lblOffpeak";
            this.lblOffpeak.Size = new System.Drawing.Size(225, 28);
            this.lblOffpeak.TabIndex = 5;
            this.lblOffpeak.Text = "kWh Used(Offpeak Hours)";
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateBill.Location = new System.Drawing.Point(280, 409);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(121, 34);
            this.btnCalculateBill.TabIndex = 6;
            this.btnCalculateBill.Text = "&Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(500, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(64, 509);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 34);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.Location = new System.Drawing.Point(178, 462);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(105, 28);
            this.lblBillAmount.TabIndex = 9;
            this.lblBillAmount.Text = "Bill Amount";
            this.lblBillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(289, 462);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(192, 26);
            this.txtBillAmount.TabIndex = 10;
            // 
            // pnlResidentialCommercial
            // 
            this.pnlResidentialCommercial.Controls.Add(this.lblPowerUsed);
            this.pnlResidentialCommercial.Controls.Add(this.txtInputPowerUsed);
            this.pnlResidentialCommercial.Location = new System.Drawing.Point(146, 259);
            this.pnlResidentialCommercial.Name = "pnlResidentialCommercial";
            this.pnlResidentialCommercial.Size = new System.Drawing.Size(456, 54);
            this.pnlResidentialCommercial.TabIndex = 11;
            // 
            // frmBillGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(727, 587);
            this.Controls.Add(this.pnlResidentialCommercial);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.pnlIndustrial);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.grpBoxCustomerType);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBillGenerator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBillGenerator_Load);
            this.grpBoxCustomerType.ResumeLayout(false);
            this.grpBoxCustomerType.PerformLayout();
            this.pnlIndustrial.ResumeLayout(false);
            this.pnlIndustrial.PerformLayout();
            this.pnlResidentialCommercial.ResumeLayout(false);
            this.pnlResidentialCommercial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpBoxCustomerType;
        private System.Windows.Forms.RadioButton rbtnIndustrial;
        private System.Windows.Forms.RadioButton rbtnCommercial;
        private System.Windows.Forms.RadioButton rbtnResidential;
        private System.Windows.Forms.Label lblPowerUsed;
        private System.Windows.Forms.TextBox txtInputPowerUsed;
        private System.Windows.Forms.Panel pnlIndustrial;
        private System.Windows.Forms.TextBox txtOffpeakUsage;
        private System.Windows.Forms.Label lblOffpeak;
        private System.Windows.Forms.Button btnCalculateBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Panel pnlResidentialCommercial;
    }
}

