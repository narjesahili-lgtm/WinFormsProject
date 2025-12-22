namespace GYM_APP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMemberGender = new System.Windows.Forms.ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.chkMemberActive = new System.Windows.Forms.CheckBox();
            this.tabTrainers = new System.Windows.Forms.TabPage();
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.colTrainerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTrainer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateTrainer = new System.Windows.Forms.Button();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.cmbTrainerGender = new System.Windows.Forms.ComboBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTrainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.grpTrainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabTrainers);
            this.tabControl1.Controls.Add(this.tabClasses);
            this.tabControl1.Controls.Add(this.tabBooking);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Location = new System.Drawing.Point(4, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabBooking_SelectedIndexChanged);
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Controls.Add(this.groupBox1);
            this.tabMembers.Location = new System.Drawing.Point(4, 25);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(787, 422);
            this.tabMembers.TabIndex = 0;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            this.tabMembers.Click += new System.EventHandler(this.tabMembers_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colMembership,
            this.colActive,
            this.colEnrolled});
            this.dgvMembers.Location = new System.Drawing.Point(446, 6);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(341, 399);
            this.dgvMembers.TabIndex = 8;
            this.dgvMembers.CellBorderStyleChanged += new System.EventHandler(this.dgvMembers_CellBorderStyleChanged);
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colMembership
            // 
            this.colMembership.HeaderText = "Membership";
            this.colMembership.MinimumWidth = 6;
            this.colMembership.Name = "colMembership";
            this.colMembership.ReadOnly = true;
            this.colMembership.Width = 125;
            // 
            // colActive
            // 
            this.colActive.HeaderText = "Active";
            this.colActive.MinimumWidth = 6;
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            this.colActive.Width = 125;
            // 
            // colEnrolled
            // 
            this.colEnrolled.HeaderText = "Enrolled Classes";
            this.colEnrolled.MinimumWidth = 6;
            this.colEnrolled.Name = "colEnrolled";
            this.colEnrolled.ReadOnly = true;
            this.colEnrolled.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMember);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMemberGender);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.btnUpdateMember);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.cmbMembershipType);
            this.groupBox1.Controls.Add(this.chkMemberActive);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 399);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(5, 370);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteMember.TabIndex = 11;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Member ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbMemberGender
            // 
            this.cmbMemberGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberGender.FormattingEnabled = true;
            this.cmbMemberGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbMemberGender.Location = new System.Drawing.Point(-2, 198);
            this.cmbMemberGender.Name = "cmbMemberGender";
            this.cmbMemberGender.Size = new System.Drawing.Size(121, 24);
            this.cmbMemberGender.TabIndex = 8;
            this.cmbMemberGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(-5, 179);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(52, 16);
            this.lable1.TabIndex = 7;
            this.lable1.Text = "Gender";
            this.lable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(-3, 36);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(408, 22);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(0, 330);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(185, 23);
            this.btnUpdateMember.TabIndex = 6;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(0, 95);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(408, 22);
            this.txtMemberName.TabIndex = 2;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(0, 290);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(185, 23);
            this.btnAddMember.TabIndex = 5;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.cmbMembershipType.Location = new System.Drawing.Point(-2, 142);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(142, 24);
            this.cmbMembershipType.TabIndex = 3;
            this.cmbMembershipType.Text = "Membership Type";
            // 
            // chkMemberActive
            // 
            this.chkMemberActive.AutoSize = true;
            this.chkMemberActive.Location = new System.Drawing.Point(0, 241);
            this.chkMemberActive.Name = "chkMemberActive";
            this.chkMemberActive.Size = new System.Drawing.Size(66, 20);
            this.chkMemberActive.TabIndex = 4;
            this.chkMemberActive.Text = "Active";
            this.chkMemberActive.UseVisualStyleBackColor = true;
            // 
            // tabTrainers
            // 
            this.tabTrainers.Controls.Add(this.dgvTrainers);
            this.tabTrainers.Controls.Add(this.grpTrainer);
            this.tabTrainers.Location = new System.Drawing.Point(4, 25);
            this.tabTrainers.Name = "tabTrainers";
            this.tabTrainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainers.Size = new System.Drawing.Size(787, 422);
            this.tabTrainers.TabIndex = 1;
            this.tabTrainers.Text = "Trainers";
            this.tabTrainers.UseVisualStyleBackColor = true;
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.AllowUserToAddRows = false;
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainerID,
            this.colTrainerName,
            this.colSpecialization,
            this.colTrainerGender});
            this.dgvTrainers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTrainers.Location = new System.Drawing.Point(412, 6);
            this.dgvTrainers.MultiSelect = false;
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainers.Size = new System.Drawing.Size(372, 410);
            this.dgvTrainers.TabIndex = 1;
            // 
            // colTrainerID
            // 
            this.colTrainerID.HeaderText = "Trainer ID";
            this.colTrainerID.MinimumWidth = 6;
            this.colTrainerID.Name = "colTrainerID";
            this.colTrainerID.ReadOnly = true;
            this.colTrainerID.Width = 125;
            // 
            // colTrainerName
            // 
            this.colTrainerName.HeaderText = "Name";
            this.colTrainerName.MinimumWidth = 6;
            this.colTrainerName.Name = "colTrainerName";
            this.colTrainerName.ReadOnly = true;
            this.colTrainerName.Width = 125;
            // 
            // colSpecialization
            // 
            this.colSpecialization.HeaderText = "Specialization";
            this.colSpecialization.MinimumWidth = 6;
            this.colSpecialization.Name = "colSpecialization";
            this.colSpecialization.ReadOnly = true;
            this.colSpecialization.Width = 125;
            // 
            // colTrainerGender
            // 
            this.colTrainerGender.HeaderText = "Gender";
            this.colTrainerGender.MinimumWidth = 6;
            this.colTrainerGender.Name = "colTrainerGender";
            this.colTrainerGender.ReadOnly = true;
            this.colTrainerGender.Width = 125;
            // 
            // grpTrainer
            // 
            this.grpTrainer.Controls.Add(this.label4);
            this.grpTrainer.Controls.Add(this.label3);
            this.grpTrainer.Controls.Add(this.btnUpdateTrainer);
            this.grpTrainer.Controls.Add(this.btnAddTrainer);
            this.grpTrainer.Controls.Add(this.cmbTrainerGender);
            this.grpTrainer.Controls.Add(this.cmbSpecialization);
            this.grpTrainer.Controls.Add(this.txtTrainerName);
            this.grpTrainer.Controls.Add(this.txtTrainerID);
            this.grpTrainer.Location = new System.Drawing.Point(3, 0);
            this.grpTrainer.Name = "grpTrainer";
            this.grpTrainer.Size = new System.Drawing.Size(403, 422);
            this.grpTrainer.TabIndex = 0;
            this.grpTrainer.TabStop = false;
            this.grpTrainer.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trainer\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trainer\'s ID";
            // 
            // btnUpdateTrainer
            // 
            this.btnUpdateTrainer.Location = new System.Drawing.Point(9, 359);
            this.btnUpdateTrainer.Name = "btnUpdateTrainer";
            this.btnUpdateTrainer.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateTrainer.TabIndex = 5;
            this.btnUpdateTrainer.Text = "Update Trainer";
            this.btnUpdateTrainer.UseVisualStyleBackColor = true;
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Location = new System.Drawing.Point(7, 306);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(117, 23);
            this.btnAddTrainer.TabIndex = 4;
            this.btnAddTrainer.Text = "Add Trainer";
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // cmbTrainerGender
            // 
            this.cmbTrainerGender.FormattingEnabled = true;
            this.cmbTrainerGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbTrainerGender.Location = new System.Drawing.Point(3, 236);
            this.cmbTrainerGender.Name = "cmbTrainerGender";
            this.cmbTrainerGender.Size = new System.Drawing.Size(121, 24);
            this.cmbTrainerGender.TabIndex = 3;
            this.cmbTrainerGender.Text = "Gender";
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Items.AddRange(new object[] {
            "Personal Trainer",
            "Yoga",
            "Pilates ",
            "Martial Arts"});
            this.cmbSpecialization.Location = new System.Drawing.Point(4, 181);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(121, 24);
            this.cmbSpecialization.TabIndex = 2;
            this.cmbSpecialization.Text = "Specialization";
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Location = new System.Drawing.Point(9, 111);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(320, 22);
            this.txtTrainerName.TabIndex = 1;
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Location = new System.Drawing.Point(9, 37);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(320, 22);
            this.txtTrainerID.TabIndex = 0;
            // 
            // tabClasses
            // 
            this.tabClasses.Location = new System.Drawing.Point(4, 25);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(787, 422);
            this.tabClasses.TabIndex = 2;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tabBooking
            // 
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(787, 422);
            this.tabBooking.TabIndex = 3;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(787, 422);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTrainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.grpTrainer.ResumeLayout(false);
            this.grpTrainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabTrainers;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.CheckBox chkMemberActive;
        private System.Windows.Forms.ComboBox cmbMembershipType;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembership;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnrolled;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.ComboBox cmbMemberGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.GroupBox grpTrainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateTrainer;
        private System.Windows.Forms.Button btnAddTrainer;
        private System.Windows.Forms.ComboBox cmbTrainerGender;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerGender;
    }
}

