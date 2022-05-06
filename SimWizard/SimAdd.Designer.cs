
namespace SimWizard
{
    partial class SimAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbAcutalBalance = new System.Windows.Forms.Label();
            this.tbBalanceChange = new System.Windows.Forms.TextBox();
            this.lbBalanceChange = new System.Windows.Forms.Label();
            this.lbActual = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbValidFrom = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCreationDate = new System.Windows.Forms.TextBox();
            this.lbPuk = new System.Windows.Forms.Label();
            this.lbPin = new System.Windows.Forms.Label();
            this.mtbPin = new System.Windows.Forms.MaskedTextBox();
            this.mtbPuk = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(128, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(129, 111);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 21);
            this.cbStatus.TabIndex = 6;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(26, 114);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Status";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(272, 259);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Save";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(29, 259);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 11;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(110, 259);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbAcutalBalance
            // 
            this.lbAcutalBalance.AutoSize = true;
            this.lbAcutalBalance.Location = new System.Drawing.Point(359, 19);
            this.lbAcutalBalance.Name = "lbAcutalBalance";
            this.lbAcutalBalance.Size = new System.Drawing.Size(79, 13);
            this.lbAcutalBalance.TabIndex = 13;
            this.lbAcutalBalance.Text = "Actual Balance";
            // 
            // tbBalanceChange
            // 
            this.tbBalanceChange.Location = new System.Drawing.Point(485, 51);
            this.tbBalanceChange.Name = "tbBalanceChange";
            this.tbBalanceChange.Size = new System.Drawing.Size(100, 20);
            this.tbBalanceChange.TabIndex = 14;
            // 
            // lbBalanceChange
            // 
            this.lbBalanceChange.AutoSize = true;
            this.lbBalanceChange.Location = new System.Drawing.Point(359, 54);
            this.lbBalanceChange.Name = "lbBalanceChange";
            this.lbBalanceChange.Size = new System.Drawing.Size(97, 13);
            this.lbBalanceChange.TabIndex = 15;
            this.lbBalanceChange.Text = "Change in Balance";
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Location = new System.Drawing.Point(482, 16);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(0, 13);
            this.lbActual.TabIndex = 16;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(191, 259);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 17;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbType
            // 
            this.tbType.AutoSize = true;
            this.tbType.Location = new System.Drawing.Point(26, 151);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(31, 13);
            this.tbType.TabIndex = 18;
            this.tbType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Normal",
            "Special"});
            this.cbType.Location = new System.Drawing.Point(129, 148);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 19;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(26, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name";
            // 
            // lbValidFrom
            // 
            this.lbValidFrom.AutoSize = true;
            this.lbValidFrom.Location = new System.Drawing.Point(26, 80);
            this.lbValidFrom.Name = "lbValidFrom";
            this.lbValidFrom.Size = new System.Drawing.Size(72, 13);
            this.lbValidFrom.TabIndex = 21;
            this.lbValidFrom.Text = "Creation Date";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 22;
            // 
            // tbCreationDate
            // 
            this.tbCreationDate.Location = new System.Drawing.Point(129, 77);
            this.tbCreationDate.Name = "tbCreationDate";
            this.tbCreationDate.Size = new System.Drawing.Size(100, 20);
            this.tbCreationDate.TabIndex = 23;
            // 
            // lbPuk
            // 
            this.lbPuk.AutoSize = true;
            this.lbPuk.Location = new System.Drawing.Point(26, 224);
            this.lbPuk.Name = "lbPuk";
            this.lbPuk.Size = new System.Drawing.Size(26, 13);
            this.lbPuk.TabIndex = 25;
            this.lbPuk.Text = "Puk";
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Location = new System.Drawing.Point(26, 187);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(22, 13);
            this.lbPin.TabIndex = 24;
            this.lbPin.Text = "Pin";
            // 
            // mtbPin
            // 
            this.mtbPin.Location = new System.Drawing.Point(129, 184);
            this.mtbPin.Mask = "0000";
            this.mtbPin.Name = "mtbPin";
            this.mtbPin.Size = new System.Drawing.Size(100, 20);
            this.mtbPin.TabIndex = 26;
            this.mtbPin.ValidatingType = typeof(int);
            // 
            // mtbPuk
            // 
            this.mtbPuk.Location = new System.Drawing.Point(129, 221);
            this.mtbPuk.Mask = "000000000";
            this.mtbPuk.Name = "mtbPuk";
            this.mtbPuk.Size = new System.Drawing.Size(100, 20);
            this.mtbPuk.TabIndex = 27;
            this.mtbPuk.ValidatingType = typeof(int);
            // 
            // SimAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbPuk);
            this.Controls.Add(this.mtbPin);
            this.Controls.Add(this.lbPuk);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.tbCreationDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbValidFrom);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.lbBalanceChange);
            this.Controls.Add(this.tbBalanceChange);
            this.Controls.Add(this.lbAcutalBalance);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "SimAdd";
            this.Text = "Sim Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbAcutalBalance;
        private System.Windows.Forms.TextBox tbBalanceChange;
        private System.Windows.Forms.Label lbBalanceChange;
        private System.Windows.Forms.Label lbActual;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label tbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbValidFrom;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCreationDate;
        private System.Windows.Forms.Label lbPuk;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.MaskedTextBox mtbPin;
        private System.Windows.Forms.MaskedTextBox mtbPuk;
    }
}