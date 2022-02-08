using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modern_Medical_Management_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public bool check(string value)
        {
            if (value == null || value == "") { return false; }
            else { return true; }
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string moblieNumber = tbMobileNumber.Text.Trim();
            string address = tbAddress.Text.Trim();
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
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
         
            string date = tbDate.Text.Trim();
            string month = tbMonth.Text.Trim();
            string year = tbYear.Text.Trim();
            string dob = date + "/" + month + "/" + year;

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


            if (check(name)) 
            {
                try
                {
                    string queryName = "select * from users where Name = '" + name + "'";
                    SqlCommand cmdName = new SqlCommand(queryName, conn);

                    if (cmdName.ExecuteReader().Read())
                    {
                        errMsg += "\nName Exist";
                        flag = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { errMsg += "\nEnter Name"; flag = 0; }
            conn.Close();

            if (check(email)) { }
            else { errMsg += "\nEnter Email"; flag = 0; }
            if (check(moblieNumber)) { }
            else { errMsg += "\nEnter Moblie Number"; flag = 0; }
            if (check(address)) { }
            else { errMsg += "\nEnter Address"; flag = 0; }
            
            if (check(password)) { }
            else { errMsg += "\nEnter Password"; flag = 0; }
            if (check(confirmPassword)) 
            {
                if (password != confirmPassword) { errMsg += "\nPassword & Confirm Password Must be Same"; flag = 0; }
            }
            else { errMsg += "\nEnter Confirm Password"; flag = 0; }
            
            if (check(shift)) { }
            else { errMsg += "\nEnter Shift"; flag = 0; }
            if (check(category)) { }
            else { errMsg += "\nEnter Category"; flag = 0; }
            if (check(gender)) { }
            else { errMsg += "\nEnter Gender"; flag = 0; }
            if (check(date)) { }
            else { errMsg += "\nEnter Date"; flag = 0; }
            if (check(month)) { }
            else { errMsg += "\nEnter Month"; flag = 0; }
            if (check(year)) { }
            else { errMsg += "\nEnter Year"; flag = 0; }
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
                string query = string.Format("INSERT INTO[dbo].[users]([Name] ,[Email] ,[Password] ,[Mobile No] ,[Shift] ,[Address] ,[Category] ,[Gender] ,[Date of Birth]) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", name, email, password, moblieNumber, shift, address, category, gender, dob);
                //string query = string.Format("insert into users values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", name, email, password, moblieNumber, shift, address, category, gender, dob);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Registration Completed");
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) { Application.Exit(); }
        }
    }
}
