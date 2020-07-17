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
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCustData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.grpbxSum = new System.Windows.Forms.GroupBox();
            this.lblISum = new System.Windows.Forms.Label();
            this.lblCSum = new System.Windows.Forms.Label();
            this.lblRSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxCustomerType.SuspendLayout();
            this.pnlIndustrial.SuspendLayout();
            this.pnlResidentialCommercial.SuspendLayout();
            this.grpbxSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(328, 9);
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
            this.grpBoxCustomerType.Location = new System.Drawing.Point(3, 90);
            this.grpBoxCustomerType.Name = "grpBoxCustomerType";
            this.grpBoxCustomerType.Size = new System.Drawing.Size(460, 100);
            this.grpBoxCustomerType.TabIndex = 1;
            this.grpBoxCustomerType.TabStop = false;
            this.grpBoxCustomerType.Text = "Select Customer Type";
            // 
            // rbtnIndustrial
            // 
            this.rbtnIndustrial.AutoSize = true;
            this.rbtnIndustrial.Location = new System.Drawing.Point(341, 42);
            this.rbtnIndustrial.Name = "rbtnIndustrial";
            this.rbtnIndustrial.Size = new System.Drawing.Size(102, 24);
            this.rbtnIndustrial.TabIndex = 2;
            this.rbtnIndustrial.Tag = "I";
            this.rbtnIndustrial.Text = "Industrial";
            this.rbtnIndustrial.UseVisualStyleBackColor = true;
            this.rbtnIndustrial.CheckedChanged += new System.EventHandler(this.rbtnIndustrial_CheckedChanged);
            // 
            // rbtnCommercial
            // 
            this.rbtnCommercial.AutoSize = true;
            this.rbtnCommercial.Location = new System.Drawing.Point(159, 42);
            this.rbtnCommercial.Name = "rbtnCommercial";
            this.rbtnCommercial.Size = new System.Drawing.Size(120, 24);
            this.rbtnCommercial.TabIndex = 1;
            this.rbtnCommercial.Tag = "C";
            this.rbtnCommercial.Text = "Commercial";
            this.rbtnCommercial.UseVisualStyleBackColor = true;
            this.rbtnCommercial.CheckedChanged += new System.EventHandler(this.rbtnCommercial_CheckedChanged);
            // 
            // rbtnResidential
            // 
            this.rbtnResidential.AutoSize = true;
            this.rbtnResidential.Checked = true;
            this.rbtnResidential.Location = new System.Drawing.Point(9, 42);
            this.rbtnResidential.Name = "rbtnResidential";
            this.rbtnResidential.Size = new System.Drawing.Size(117, 24);
            this.rbtnResidential.TabIndex = 0;
            this.rbtnResidential.TabStop = true;
            this.rbtnResidential.Tag = "R";
            this.rbtnResidential.Text = "Residential";
            this.rbtnResidential.UseVisualStyleBackColor = true;
            this.rbtnResidential.CheckedChanged += new System.EventHandler(this.rbtnResidential_CheckedChanged);
            // 
            // lblPowerUsed
            // 
            this.lblPowerUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUsed.Location = new System.Drawing.Point(1, 12);
            this.lblPowerUsed.Name = "lblPowerUsed";
            this.lblPowerUsed.Size = new System.Drawing.Size(234, 28);
            this.lblPowerUsed.TabIndex = 3;
            this.lblPowerUsed.Text = "kWh Used";
            this.lblPowerUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInputPowerUsed
            // 
            this.txtInputPowerUsed.Location = new System.Drawing.Point(285, 14);
            this.txtInputPowerUsed.Name = "txtInputPowerUsed";
            this.txtInputPowerUsed.Size = new System.Drawing.Size(143, 26);
            this.txtInputPowerUsed.TabIndex = 4;
            this.txtInputPowerUsed.Tag = "Power Used";
            // 
            // pnlIndustrial
            // 
            this.pnlIndustrial.Controls.Add(this.txtOffpeakUsage);
            this.pnlIndustrial.Controls.Add(this.lblOffpeak);
            this.pnlIndustrial.Location = new System.Drawing.Point(7, 414);
            this.pnlIndustrial.Name = "pnlIndustrial";
            this.pnlIndustrial.Size = new System.Drawing.Size(456, 59);
            this.pnlIndustrial.TabIndex = 5;
            // 
            // txtOffpeakUsage
            // 
            this.txtOffpeakUsage.Location = new System.Drawing.Point(285, 16);
            this.txtOffpeakUsage.Name = "txtOffpeakUsage";
            this.txtOffpeakUsage.Size = new System.Drawing.Size(143, 26);
            this.txtOffpeakUsage.TabIndex = 5;
            this.txtOffpeakUsage.Tag = "kWh Used(OffPeak Hours)";
            // 
            // lblOffpeak
            // 
            this.lblOffpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffpeak.Location = new System.Drawing.Point(1, 14);
            this.lblOffpeak.Name = "lblOffpeak";
            this.lblOffpeak.Size = new System.Drawing.Size(234, 28);
            this.lblOffpeak.TabIndex = 5;
            this.lblOffpeak.Text = "kWh Used(Offpeak Hours)";
            this.lblOffpeak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateBill.Location = new System.Drawing.Point(7, 496);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(121, 34);
            this.btnCalculateBill.TabIndex = 6;
            this.btnCalculateBill.Text = "&Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(848, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(488, 488);
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
            this.lblBillAmount.Location = new System.Drawing.Point(158, 496);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(105, 28);
            this.lblBillAmount.TabIndex = 9;
            this.lblBillAmount.Text = "Bill Amount";
            this.lblBillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(269, 496);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(192, 26);
            this.txtBillAmount.TabIndex = 7;
            this.txtBillAmount.TabStop = false;
            // 
            // pnlResidentialCommercial
            // 
            this.pnlResidentialCommercial.Controls.Add(this.lblPowerUsed);
            this.pnlResidentialCommercial.Controls.Add(this.txtInputPowerUsed);
            this.pnlResidentialCommercial.Location = new System.Drawing.Point(7, 354);
            this.pnlResidentialCommercial.Name = "pnlResidentialCommercial";
            this.pnlResidentialCommercial.Size = new System.Drawing.Size(456, 54);
            this.pnlResidentialCommercial.TabIndex = 11;
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNo.Location = new System.Drawing.Point(3, 230);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(234, 28);
            this.lblAcctNo.TabIndex = 12;
            this.lblAcctNo.Text = "Account Number";
            this.lblAcctNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(8, 289);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(234, 28);
            this.lblCustName.TabIndex = 13;
            this.lblCustName.Text = "Name";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(292, 232);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(143, 26);
            this.txtAcctNo.TabIndex = 2;
            this.txtAcctNo.Tag = "Account Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(292, 291);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(143, 26);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.Tag = "Customer Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(673, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstCustData
            // 
            this.lstCustData.FormattingEnabled = true;
            this.lstCustData.ItemHeight = 20;
            this.lstCustData.Location = new System.Drawing.Point(479, 104);
            this.lstCustData.Name = "lstCustData";
            this.lstCustData.Size = new System.Drawing.Size(364, 324);
            this.lstCustData.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(858, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "#Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(858, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sum of all charges";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCustomerCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.Location = new System.Drawing.Point(1043, 102);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(151, 31);
            this.lblCustomerCount.TabIndex = 11;
            this.lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSum.Location = new System.Drawing.Point(1043, 150);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(151, 31);
            this.lblTotalSum.TabIndex = 12;
            this.lblTotalSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpbxSum
            // 
            this.grpbxSum.Controls.Add(this.lblISum);
            this.grpbxSum.Controls.Add(this.lblCSum);
            this.grpbxSum.Controls.Add(this.lblRSum);
            this.grpbxSum.Controls.Add(this.label5);
            this.grpbxSum.Controls.Add(this.label4);
            this.grpbxSum.Controls.Add(this.label3);
            this.grpbxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxSum.Location = new System.Drawing.Point(864, 198);
            this.grpbxSum.Name = "grpbxSum";
            this.grpbxSum.Size = new System.Drawing.Size(341, 242);
            this.grpbxSum.TabIndex = 22;
            this.grpbxSum.TabStop = false;
            this.grpbxSum.Text = "Sum of Charges";
            // 
            // lblISum
            // 
            this.lblISum.BackColor = System.Drawing.Color.AliceBlue;
            this.lblISum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblISum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISum.Location = new System.Drawing.Point(169, 172);
            this.lblISum.Name = "lblISum";
            this.lblISum.Size = new System.Drawing.Size(151, 31);
            this.lblISum.TabIndex = 15;
            this.lblISum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCSum
            // 
            this.lblCSum.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSum.Location = new System.Drawing.Point(169, 108);
            this.lblCSum.Name = "lblCSum";
            this.lblCSum.Size = new System.Drawing.Size(151, 31);
            this.lblCSum.TabIndex = 14;
            this.lblCSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRSum
            // 
            this.lblRSum.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSum.Location = new System.Drawing.Point(169, 43);
            this.lblRSum.Name = "lblRSum";
            this.lblRSum.Size = new System.Drawing.Size(151, 31);
            this.lblRSum.TabIndex = 13;
            this.lblRSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "#Industrial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "#Commercial";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "#Residential";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBillGenerator
            // 
            this.AcceptButton = this.btnCalculateBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1232, 622);
            this.Controls.Add(this.grpbxSum);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblAcctNo);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBillGenerator_FormClosing);
            this.Load += new System.EventHandler(this.frmBillGenerator_Load);
            this.grpBoxCustomerType.ResumeLayout(false);
            this.grpBoxCustomerType.PerformLayout();
            this.pnlIndustrial.ResumeLayout(false);
            this.pnlIndustrial.PerformLayout();
            this.pnlResidentialCommercial.ResumeLayout(false);
            this.pnlResidentialCommercial.PerformLayout();
            this.grpbxSum.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstCustData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.GroupBox grpbxSum;
        private System.Windows.Forms.Label lblISum;
        private System.Windows.Forms.Label lblCSum;
        private System.Windows.Forms.Label lblRSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

