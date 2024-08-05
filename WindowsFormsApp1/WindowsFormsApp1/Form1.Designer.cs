namespace WindowsFormsApp1
{
    partial class Form1
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
            this.gbCarculate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWaterUser = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbWateruser = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtThisMonth = new System.Windows.Forms.TextBox();
            this.txtLastMonth = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.lbThisMonth = new System.Windows.Forms.Label();
            this.lbLastMonth = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lsvWaterBill = new System.Windows.Forms.ListView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbCarculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCarculate
            // 
            this.gbCarculate.Controls.Add(this.label1);
            this.gbCarculate.Controls.Add(this.txtDescription);
            this.gbCarculate.Controls.Add(this.txtWaterUser);
            this.gbCarculate.Controls.Add(this.lbDescription);
            this.gbCarculate.Controls.Add(this.btnReset);
            this.gbCarculate.Controls.Add(this.btnDelete);
            this.gbCarculate.Controls.Add(this.btnEdit);
            this.gbCarculate.Controls.Add(this.btnAdd);
            this.gbCarculate.Controls.Add(this.lbWateruser);
            this.gbCarculate.Controls.Add(this.lbMember);
            this.gbCarculate.Controls.Add(this.txtMember);
            this.gbCarculate.Controls.Add(this.txtThisMonth);
            this.gbCarculate.Controls.Add(this.txtLastMonth);
            this.gbCarculate.Controls.Add(this.txtPhone);
            this.gbCarculate.Controls.Add(this.txtName);
            this.gbCarculate.Controls.Add(this.txtID);
            this.gbCarculate.Controls.Add(this.lbType);
            this.gbCarculate.Controls.Add(this.cbTypes);
            this.gbCarculate.Controls.Add(this.lbThisMonth);
            this.gbCarculate.Controls.Add(this.lbLastMonth);
            this.gbCarculate.Controls.Add(this.lbPhone);
            this.gbCarculate.Controls.Add(this.lbName);
            this.gbCarculate.Controls.Add(this.lbID);
            this.gbCarculate.Location = new System.Drawing.Point(12, 64);
            this.gbCarculate.Name = "gbCarculate";
            this.gbCarculate.Size = new System.Drawing.Size(1096, 272);
            this.gbCarculate.TabIndex = 0;
            this.gbCarculate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "m3";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(727, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(164, 22);
            this.txtDescription.TabIndex = 22;
            // 
            // txtWaterUser
            // 
            this.txtWaterUser.Location = new System.Drawing.Point(483, 51);
            this.txtWaterUser.Name = "txtWaterUser";
            this.txtWaterUser.ReadOnly = true;
            this.txtWaterUser.Size = new System.Drawing.Size(119, 22);
            this.txtWaterUser.TabIndex = 21;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(724, 29);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 16);
            this.lbDescription.TabIndex = 20;
            this.lbDescription.Text = "Description";
            this.lbDescription.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(529, 232);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbWateruser
            // 
            this.lbWateruser.AutoSize = true;
            this.lbWateruser.Location = new System.Drawing.Point(290, 51);
            this.lbWateruser.Name = "lbWateruser";
            this.lbWateruser.Size = new System.Drawing.Size(139, 16);
            this.lbWateruser.TabIndex = 14;
            this.lbWateruser.Text = "Amount Of Water User";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Location = new System.Drawing.Point(290, 161);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(124, 16);
            this.lbMember.TabIndex = 13;
            this.lbMember.Text = "Number Of Member";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(483, 155);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(121, 22);
            this.txtMember.TabIndex = 12;
            // 
            // txtThisMonth
            // 
            this.txtThisMonth.Location = new System.Drawing.Point(82, 177);
            this.txtThisMonth.Name = "txtThisMonth";
            this.txtThisMonth.Size = new System.Drawing.Size(100, 22);
            this.txtThisMonth.TabIndex = 11;
            // 
            // txtLastMonth
            // 
            this.txtLastMonth.Location = new System.Drawing.Point(82, 137);
            this.txtLastMonth.Name = "txtLastMonth";
            this.txtLastMonth.Size = new System.Drawing.Size(100, 22);
            this.txtLastMonth.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(290, 113);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(129, 16);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Types Of Customers";
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "1. Household",
            "2. Administrative agency",
            "3. Production unit",
            "4. Business service"});
            this.cbTypes.Location = new System.Drawing.Point(483, 107);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(121, 24);
            this.cbTypes.TabIndex = 5;
            // 
            // lbThisMonth
            // 
            this.lbThisMonth.AutoSize = true;
            this.lbThisMonth.Location = new System.Drawing.Point(6, 177);
            this.lbThisMonth.Name = "lbThisMonth";
            this.lbThisMonth.Size = new System.Drawing.Size(72, 16);
            this.lbThisMonth.TabIndex = 4;
            this.lbThisMonth.Text = "This Month";
            // 
            // lbLastMonth
            // 
            this.lbLastMonth.AutoSize = true;
            this.lbLastMonth.Location = new System.Drawing.Point(6, 140);
            this.lbLastMonth.Name = "lbLastMonth";
            this.lbLastMonth.Size = new System.Drawing.Size(71, 16);
            this.lbLastMonth.TabIndex = 3;
            this.lbLastMonth.Text = "Last Month";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(6, 107);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(46, 16);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 29);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // lsvWaterBill
            // 
            this.lsvWaterBill.HideSelection = false;
            this.lsvWaterBill.Location = new System.Drawing.Point(12, 342);
            this.lsvWaterBill.Name = "lsvWaterBill";
            this.lsvWaterBill.Size = new System.Drawing.Size(1096, 112);
            this.lsvWaterBill.TabIndex = 1;
            this.lsvWaterBill.UseCompatibleStateImageBehavior = false;
            this.lsvWaterBill.SelectedIndexChanged += new System.EventHandler(this.lsvWaterBill_SelectedIndexChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(332, 38);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(258, 23);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "CARCULATE WATER BILL";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lsvWaterBill);
            this.Controls.Add(this.gbCarculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCarculate.ResumeLayout(false);
            this.gbCarculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarculate;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label lbThisMonth;
        private System.Windows.Forms.Label lbLastMonth;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ListView lsvWaterBill;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtThisMonth;
        private System.Windows.Forms.TextBox txtLastMonth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbWateruser;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtWaterUser;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
    }
}

