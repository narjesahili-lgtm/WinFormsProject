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
            this.btnDeleteTrainer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateTrainer = new System.Windows.Forms.Button();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.cmbTrainerGender = new System.Windows.Forms.ComboBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.colSessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSessionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cmbClassMember = new System.Windows.Forms.ComboBox();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.dtpClassTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtMaxSlots = new System.Windows.Forms.TextBox();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnBookClass = new System.Windows.Forms.Button();
            this.cmbBookingMember = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAttendance = new System.Windows.Forms.ListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBookingTrainer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTrainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.grpTrainer.SuspendLayout();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.grpClass.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabTrainers);
            this.tabControl1.Controls.Add(this.tabClasses);
            this.tabControl1.Controls.Add(this.tabBooking);
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
            this.dgvTrainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainers_CellClick);
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
            this.grpTrainer.Controls.Add(this.label12);
            this.grpTrainer.Controls.Add(this.label11);
            this.grpTrainer.Controls.Add(this.btnDeleteTrainer);
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
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.Location = new System.Drawing.Point(4, 365);
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.Size = new System.Drawing.Size(153, 23);
            this.btnDeleteTrainer.TabIndex = 8;
            this.btnDeleteTrainer.Text = "Delete Trainer";
            this.btnDeleteTrainer.UseVisualStyleBackColor = true;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click);
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
            this.btnUpdateTrainer.Location = new System.Drawing.Point(4, 325);
            this.btnUpdateTrainer.Name = "btnUpdateTrainer";
            this.btnUpdateTrainer.Size = new System.Drawing.Size(153, 23);
            this.btnUpdateTrainer.TabIndex = 5;
            this.btnUpdateTrainer.Text = "Update Trainer";
            this.btnUpdateTrainer.UseVisualStyleBackColor = true;
            this.btnUpdateTrainer.Click += new System.EventHandler(this.btnUpdateTrainer_Click);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Location = new System.Drawing.Point(3, 286);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(154, 23);
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
            this.tabClasses.Controls.Add(this.dgvClasses);
            this.tabClasses.Controls.Add(this.grpClass);
            this.tabClasses.Location = new System.Drawing.Point(4, 25);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(787, 422);
            this.tabClasses.TabIndex = 2;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSessionID,
            this.colClassName,
            this.colTrainer,
            this.colSchedule,
            this.colMaxSlots,
            this.colBooked});
            this.dgvClasses.Location = new System.Drawing.Point(336, 0);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(451, 405);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            this.dgvClasses.SelectionChanged += new System.EventHandler(this.dgvClasses_SelectionChanged);
            // 
            // colSessionID
            // 
            this.colSessionID.HeaderText = "Session ID";
            this.colSessionID.MinimumWidth = 6;
            this.colSessionID.Name = "colSessionID";
            this.colSessionID.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.HeaderText = "Class Name";
            this.colClassName.MinimumWidth = 6;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colTrainer
            // 
            this.colTrainer.HeaderText = "Trainer";
            this.colTrainer.MinimumWidth = 6;
            this.colTrainer.Name = "colTrainer";
            this.colTrainer.ReadOnly = true;
            // 
            // colSchedule
            // 
            this.colSchedule.HeaderText = "Schedule";
            this.colSchedule.MinimumWidth = 6;
            this.colSchedule.Name = "colSchedule";
            this.colSchedule.ReadOnly = true;
            // 
            // colMaxSlots
            // 
            this.colMaxSlots.HeaderText = "Max Slots";
            this.colMaxSlots.MinimumWidth = 6;
            this.colMaxSlots.Name = "colMaxSlots";
            this.colMaxSlots.ReadOnly = true;
            // 
            // colBooked
            // 
            this.colBooked.HeaderText = "Booked";
            this.colBooked.MinimumWidth = 6;
            this.colBooked.Name = "colBooked";
            this.colBooked.ReadOnly = true;
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.label10);
            this.grpClass.Controls.Add(this.cmbBookingTrainer);
            this.grpClass.Controls.Add(this.label9);
            this.grpClass.Controls.Add(this.label8);
            this.grpClass.Controls.Add(this.label5);
            this.grpClass.Controls.Add(this.txtSessionID);
            this.grpClass.Controls.Add(this.label6);
            this.grpClass.Controls.Add(this.txtClassName);
            this.grpClass.Controls.Add(this.cmbClassMember);
            this.grpClass.Controls.Add(this.btnUpdateClass);
            this.grpClass.Controls.Add(this.dtpClassTime);
            this.grpClass.Controls.Add(this.btnAddClass);
            this.grpClass.Controls.Add(this.txtMaxSlots);
            this.grpClass.Location = new System.Drawing.Point(0, 0);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(338, 405);
            this.grpClass.TabIndex = 0;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Add/ Edit Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Class ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSessionID
            // 
            this.txtSessionID.Location = new System.Drawing.Point(6, 37);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.Size = new System.Drawing.Size(327, 22);
            this.txtSessionID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Class Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(6, 92);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(327, 22);
            this.txtClassName.TabIndex = 2;
            // 
            // cmbClassMember
            // 
            this.cmbClassMember.FormattingEnabled = true;
            this.cmbClassMember.Location = new System.Drawing.Point(0, 193);
            this.cmbClassMember.Name = "cmbClassMember";
            this.cmbClassMember.Size = new System.Drawing.Size(121, 24);
            this.cmbClassMember.TabIndex = 3;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(-4, 376);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(157, 23);
            this.btnUpdateClass.TabIndex = 7;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            // 
            // dtpClassTime
            // 
            this.dtpClassTime.Location = new System.Drawing.Point(-4, 240);
            this.dtpClassTime.Name = "dtpClassTime";
            this.dtpClassTime.Size = new System.Drawing.Size(200, 22);
            this.dtpClassTime.TabIndex = 4;
            this.dtpClassTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(-4, 334);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(157, 23);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtMaxSlots
            // 
            this.txtMaxSlots.Location = new System.Drawing.Point(-4, 296);
            this.txtMaxSlots.Name = "txtMaxSlots";
            this.txtMaxSlots.Size = new System.Drawing.Size(327, 22);
            this.txtMaxSlots.TabIndex = 5;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.groupBox2);
            this.tabBooking.Controls.Add(this.grpBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(787, 422);
            this.tabBooking.TabIndex = 3;
            this.tabBooking.Text = "Booking & Reports";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.label13);
            this.grpBooking.Controls.Add(this.btnBookClass);
            this.grpBooking.Controls.Add(this.cmbBookingMember);
            this.grpBooking.Location = new System.Drawing.Point(4, 6);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(337, 183);
            this.grpBooking.TabIndex = 2;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Book Class";
            // 
            // btnBookClass
            // 
            this.btnBookClass.Location = new System.Drawing.Point(4, 93);
            this.btnBookClass.Name = "btnBookClass";
            this.btnBookClass.Size = new System.Drawing.Size(163, 23);
            this.btnBookClass.TabIndex = 1;
            this.btnBookClass.Text = "Book Selected Class";
            this.btnBookClass.UseVisualStyleBackColor = true;
            // 
            // cmbBookingMember
            // 
            this.cmbBookingMember.FormattingEnabled = true;
            this.cmbBookingMember.Location = new System.Drawing.Point(4, 51);
            this.cmbBookingMember.Name = "cmbBookingMember";
            this.cmbBookingMember.Size = new System.Drawing.Size(289, 24);
            this.cmbBookingMember.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.lstAttendance);
            this.groupBox2.Location = new System.Drawing.Point(4, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 221);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // lstAttendance
            // 
            this.lstAttendance.FormattingEnabled = true;
            this.lstAttendance.ItemHeight = 16;
            this.lstAttendance.Location = new System.Drawing.Point(0, 21);
            this.lstAttendance.Name = "lstAttendance";
            this.lstAttendance.Size = new System.Drawing.Size(333, 164);
            this.lstAttendance.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(4, 183);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(333, 32);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Attendance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "List of Members";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbBookingTrainer
            // 
            this.cmbBookingTrainer.FormattingEnabled = true;
            this.cmbBookingTrainer.Location = new System.Drawing.Point(0, 147);
            this.cmbBookingTrainer.Name = "cmbBookingTrainer";
            this.cmbBookingTrainer.Size = new System.Drawing.Size(121, 24);
            this.cmbBookingTrainer.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Trainer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Specialization";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Choose Member";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
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
            this.tabClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabTrainers;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabBooking;
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
        private System.Windows.Forms.Button btnDeleteTrainer;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtMaxSlots;
        private System.Windows.Forms.DateTimePicker dtpClassTime;
        private System.Windows.Forms.ComboBox cmbClassMember;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtSessionID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBooked;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Button btnBookClass;
        private System.Windows.Forms.ComboBox cmbBookingMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox lstAttendance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBookingTrainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}

