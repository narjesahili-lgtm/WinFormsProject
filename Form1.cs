using GYM_APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_APP
{
    public partial class Form1 : Form
    {
        List<Member> members = new List<Member>();
        List<Trainer> trainers = new List<Trainer>();
        List<ClassSession> classes = new List<ClassSession>();

        private void LoadTrainersToClassCombo()
        {
            cmbBookingTrainer.Items.Clear();

            foreach (Trainer t in trainers)
            {
                cmbBookingTrainer.Items.Add(t);
            }
        }



        private void LoadMembersToBComboBox()
        {
            cmbClassMember.Items.Clear();

            foreach (Member m in members)
            {
                cmbClassMember.Items.Add(m);
            }
        }


        void RefreshClassesGrid()
        {
            dgvClasses.Rows.Clear();
            foreach (var c in classes)
            {
                dgvClasses.Rows.Add(
                    c.SessionID,
                    c.ClassName,
                    c.Trainer.Name,
                    c.ScheduleTime,
                    c.MaxSlots,
                    c.BookedMembers.Count
                );
            }
        }


        public Form1()
        {
            InitializeComponent();
           
        }

        
        private void tabBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            txtMemberID.Enabled = true;


            // to make sure that user did not leave any empty feild
            if (string.IsNullOrWhiteSpace(txtMemberID.Text) ||
            string.IsNullOrWhiteSpace(txtMemberName.Text) ||
            cmbMembershipType.SelectedIndex == -1 ||
            cmbMemberGender.SelectedIndex == -1)
            { 
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // to make sure the id is unique
            foreach (Member existing in members)
            {
                if (existing.MemberID == int.Parse(txtMemberID.Text))
                {
                    MessageBox.Show("Member ID already exists.");
                    return;
                }
            }

            // to make sure that the form sends all data to the code
            int id = int.Parse(txtMemberID.Text);
            string name = txtMemberName.Text;
            string membership = cmbMembershipType.Text;
            string gender = cmbMemberGender.Text;
            bool isActive = chkMemberActive.Checked;

            Member m = new Member();
            m.MemberID = id;
            m.Name = name;
            m.MembershipType = membership;
            m.Gender = gender;
            m.IsActive = isActive;

            //save the member in memory
            members.Add(m);
            LoadMembersToBComboBox();

            // show the member in datagridview
            dgvMembers.Rows.Add(
             m.MemberID,
             m.Name,
             m.MembershipType,
             m.Gender,
             m.IsActive,
             ""  
             );

            //clear the form before adding a new member
            txtMemberID.Clear();
            txtMemberName.Clear();
            cmbMembershipType.SelectedIndex = -1;
            cmbMemberGender.SelectedIndex = -1;
            chkMemberActive.Checked = false;


            txtMemberID.Enabled = false;


            ClearMemberFields();
           

        }

        private void dgvMembers_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)

                {

                    DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                    txtMemberID.Text = row.Cells[0].Value.ToString();    //textbox
                    txtMemberName.Text = row.Cells[1].Value.ToString();  //textbox
                    cmbMembershipType.Text = row.Cells[2].Value.ToString();   //combobox
                    cmbMemberGender.Text = row.Cells[3].Value.ToString();    //combobox
                    chkMemberActive.Checked = (bool)row.Cells[3].Value;   //checkbox

                    txtMemberID.Enabled = false;


                }

            }

        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {

            //secures data and and rejects any false update info
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMemberName.Text) ||
               cmbMembershipType.SelectedIndex == -1 ||
               cmbMemberGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            //use the same pattern
            //MemberID cannot be changed
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to update.");
                return;
            }
            int selectedIndex = dgvMembers.SelectedRows[0].Index;
            Member m = members[selectedIndex];
            m.Name = txtMemberName.Text;
            m.MembershipType = cmbMembershipType.Text;
            m.Gender = cmbMemberGender.Text;
            m.IsActive = chkMemberActive.Checked;

            //since DataGridView doesn't update on its own
            DataGridViewRow row = dgvMembers.SelectedRows[0];

            row.Cells[1].Value = m.Name;
            row.Cells[2].Value = m.MembershipType;
            row.Cells[3].Value = m.Gender;
            row.Cells[4].Value = m.IsActive;


            ClearMemberFields();
        }

        private void ClearMemberFields()
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            cmbMembershipType.SelectedIndex = -1;
            cmbMemberGender.SelectedIndex = -1;
            chkMemberActive.Checked = false;
            txtMemberID.Enabled = true;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            // code to delete member button + notify the user to make sue they didn't delete by mistake
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }
            DialogResult result = MessageBox.Show( "Are you sure you want to delete this member?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
            int index = dgvMembers.SelectedRows[0].Index;
            members.RemoveAt(index);
            dgvMembers.Rows.RemoveAt(index);
            ClearMemberFields();

            // member is not deleted if he still has classes
            // deleted for now

        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrainerID.Text) || 
                string.IsNullOrWhiteSpace (txtTrainerName.Text) ||
                cmbSpecialization.SelectedIndex == -1 ||
                cmbTrainerGender.SelectedIndex ==-1)

            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            //check duplicate ID
            foreach (Trainer tr in trainers)
            {
                if ( tr.TrainerID == int.Parse(txtTrainerID.Text) )
                {
                    MessageBox.Show("Trainer ID already exists.");
                    return;
                }
            }

            //Create trainer
            Trainer t = new Trainer();
            t.TrainerID = int.Parse(txtTrainerID.Text);
            t.Name = txtTrainerName.Text;
            t.Specialization = cmbSpecialization.Text;
            t.Gender = cmbTrainerGender.Text;

            //Add to list
            trainers.Add(t);


 
            //load to combo box
            LoadTrainersToClassCombo();


            // Add to Datagridview
            dgvTrainers.Rows.Add(t.TrainerID, t.Name, t.Specialization, t.Gender);

            // Clear fields
            txtTrainerID.Clear();
            txtTrainerName.Clear(); 
            cmbSpecialization.SelectedIndex = -1;
            cmbTrainerGender.SelectedIndex = -1;

        }

        private void tabMembers_Click(object sender, EventArgs e)
        {

        }

        private void dgvTrainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrainers.Rows[e.RowIndex];

                txtTrainerID.Text = row.Cells["colTrainerID"].Value.ToString();
                txtTrainerName.Text = row.Cells["colTrainerName"].Value.ToString();
                cmbSpecialization.Text = row.Cells["colSpecialization"].Value.ToString();
                cmbTrainerGender.Text = row.Cells["colTrainerGender"].Value.ToString();
            }
        }

        private void btnUpdateTrainer_Click(object sender, EventArgs e)
        {

            //check if the trainer exists
            if (dgvTrainers.CurrentRow == null) return;

            // if trainer exists, edit
            DataGridViewRow row = dgvTrainers.CurrentRow;

            row.Cells["colTrainerID"].Value = txtTrainerID.Text;
            row.Cells["colTrainerName"].Value = txtTrainerName.Text;
            row.Cells["colSpecialization"].Value = cmbSpecialization.Text;
            row.Cells["colTrainerGender"].Value = cmbTrainerGender.Text;


        }

        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {

            // code to remove the trainer 
            if (dgvTrainers.CurrentRow != null)
            {
                dgvTrainers.Rows.Remove(dgvTrainers.CurrentRow);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {

            // fields should not be empty
            if (txtSessionID.Text == "" || txtClassName.Text == "" || txtMaxSlots.Text == "")
            {
                MessageBox.Show("Fill all class fields");
                return;
            }

            if (cmbBookingTrainer.SelectedItem == null)
            {
                MessageBox.Show("Select a trainer");
                return;
            }
            ClassSession cs = new ClassSession();
            cs.SessionID = int.Parse(txtSessionID.Text);
            cs.ClassName = txtClassName.Text;
            cs.Trainer = (Trainer)cmbBookingTrainer.SelectedItem;
            cs.ScheduleTime = dtpClassTime.Value;
            cs.MaxSlots = int.Parse(txtMaxSlots.Text);
            classes.Add(cs);
            RefreshClassesGrid();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }
            private void btnBookClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a class first");
                return;
            }
            ClassSession selectedClass =
                classes[dgvClasses.SelectedRows[0].Index];
            Member selectedMember =
                (Member)cmbBookingMember.SelectedItem;
            if (!selectedMember.IsActive)
            {
                MessageBox.Show("Membership inactive");
                return;
            }
            if (selectedClass.BookedMembers.Count >= selectedClass.MaxSlots)
            {
                MessageBox.Show("Class is full");
                return;
            }
            // Gender rule
            if (selectedMember.Gender != selectedClass.Trainer.Gender)
            {
                MessageBox.Show("Gender mismatch");
                return;
            }
            selectedClass.BookedMembers.Add(selectedMember);

            // a member must not book the same class twice
            if (selectedClass.BookedMembers.Contains(selectedMember))
            {
                MessageBox.Show("Member already booked in this class");
                return;
            }

            RefreshClassesGrid();
            MessageBox.Show("Booking successful");
        }

      
            private void dgvClasses_SelectionChanged(object sender, EventArgs e)

        {

            lstAttendance.Items.Clear();

            if (dgvClasses.SelectedRows.Count == 0)

                return;

            ClassSession selectedClass =

                classes[dgvClasses.SelectedRows[0].Index];

            foreach (var m in selectedClass.BookedMembers)

            {

                lstAttendance.Items.Add(m.Name);

            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string report = "";
            foreach (var c in classes)
            {
                report += $"{c.ClassName} ({c.BookedMembers.Count}/{c.MaxSlots})\n";
                foreach (var m in c.BookedMembers)
                {
                    report += "  - " + m.Name + "\n";
                }
                report += "\n";
            }
            MessageBox.Show(report, "Attendance Report");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

