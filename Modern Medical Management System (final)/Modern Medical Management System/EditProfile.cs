using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Modern_Medical_Management_System
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProfile().Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditProfile().Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteUser().Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var conn = DBConnection.Connect();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string id = Login.id;
            string name = "";
            string email = "";
            string moblieNumber = "";
            string address = "";
            string shift = "";
            string category = "";
            string gender = "";
            string dob = "";
            string query = "select * from users where Id = " + id;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                id = ""+reader.GetInt32(reader.GetOrdinal("Id"));
                name = reader.GetString(reader.GetOrdinal("Name"));
                email = reader.GetString(reader.GetOrdinal("Email"));
                moblieNumber = reader.GetString(reader.GetOrdinal("Mobile No"));
                shift = reader.GetString(reader.GetOrdinal("Shift"));
                address = reader.GetString(reader.GetOrdinal("Address"));
                category = reader.GetString(reader.GetOrdinal("Category"));
                gender = reader.GetString(reader.GetOrdinal("Gender"));
                dob = reader.GetString(reader.GetOrdinal("Date of Birth"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            tbId.Text = id;
            tbName.Text = name;
            tbEmail.Text = email;
            tbMobileNumber.Text = moblieNumber;
            tbAddress.Text = address;
            tbDOB.Text = dob;
            if (shift == "Day  ")
            {
                rbDay.Checked = true;
            }
            else if (shift == "Night")
            {
                rbNight.Checked = true;
            }
            if (category == "Admin       ")
            {
                rbAdmin.Checked = true;
            }
            else if (category == "Doctor      ")
            {
                rbDoctor.Checked = true;
            }
            else if (category == "Receptionist")
            {
                rbReceptionist.Checked = true;
            }
            if (gender == "Male  ")
            {
                rbMale.Checked = true;
            }
            else if (gender == "Female")
            {
                rbFemale.Checked = true;
            }
            else if (gender == "Other ")
            {
                rbOther.Checked = true;
            }
        }

        public bool check(string value)
        {
            if (value == null || value == "") { return false; }
            else { return true; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Login.id;
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string moblieNumber = tbMobileNumber.Text.Trim();
            string address = tbAddress.Text.Trim();
            string shift = "";
            string category = "";
            string gender = "";
            try
            {
                shift = gbShift.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Trim();
                category = gbCategory.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Trim();
                gender = gbGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string dob = tbDOB.Text.Trim();

            string errMsg = null;
            int flag = 1;

            var conn = DBConnection.Connect();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (check(name)){}
            else { errMsg += "\nEnter Name"; flag = 0; }
            conn.Close();

            if (check(email))
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(email, pattern)) { }
                else { errMsg += "\nEnter a valid Email"; flag = 0; }
            }
            else { errMsg += "\nEnter Email"; flag = 0; }

            if (check(moblieNumber))
            {
                Regex phonenumber = new Regex("\\d{11}");
                if (phonenumber.IsMatch(moblieNumber)) { }
                else { errMsg += "\nEnter Valid Moblie Number"; flag = 0; }
            }
            else { errMsg += "\nEnter Moblie Number"; flag = 0; }
            
            if (check(address)) { }
            else { errMsg += "\nEnter Address"; flag = 0; }
            
            if (check(shift)) { }
            else { errMsg += "\nEnter Shift"; flag = 0; }
            
            if (check(category)) { }
            else { errMsg += "\nEnter Category"; flag = 0; }
            
            if (check(gender)) { }
            else { errMsg += "\nEnter Gender"; flag = 0; }
            
            if (check(dob)) { }
            else { errMsg += "\nEnter Date of birth"; flag = 0; }
            
            if (flag == 0) { MessageBox.Show(errMsg); }

            if (flag == 1)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string query = string.Format("update users set Name='{0}',Email='{1}',[Mobile No]='{2}',Shift='{3}',Address='{4}',Category='{5}',Gender='{6}',[Date of Birth]='{7}' where Id={8}", name, email, moblieNumber, shift, address, category, gender, dob, id);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Update Completed");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            conn.Close();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();
        }
    }
}
