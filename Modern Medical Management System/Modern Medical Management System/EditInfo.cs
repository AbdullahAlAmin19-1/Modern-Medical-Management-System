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
using System.Collections;

namespace Modern_Medical_Management_System
{
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }

        private void btnSearch_Click(object sender, EventArgs e) //For search the users
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

            int id = Int32.Parse(tbSearch.Text);
            string query = "select * from users where id = " + id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User u = new User();
            while (reader.Read())
            {
              
                u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Email = reader.GetString(reader.GetOrdinal("Email"));
                u.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                u.Shift = reader.GetString(reader.GetOrdinal("Shift"));
                u.Address = reader.GetString(reader.GetOrdinal("Address"));
                u.Category = reader.GetString(reader.GetOrdinal("Category"));
                u.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                
                
            }
            conn.Close();
            tbUpdateName.Text = u.Name;
            tbUpdateEmail.Text = u.Email;
            tbUpdateMobileNo.Text = u.MobileNo;
            tbUpdateShift.Text = u.Shift;
            tbUpdateAddress.Text = u.Address;
            tbUpdateCategory.Text = u.Category;
            tbUpdateGender.Text = u.Gender;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e) //Update the Info
        {
            int id = Int32.Parse(tbSearch.Text);
            string name = tbUpdateName.Text.Trim();
            string email = tbUpdateEmail.Text.Trim();
            string mobile_no = tbUpdateMobileNo.Text.Trim();
            string shift = tbUpdateShift.Text.Trim();
            string address = tbUpdateAddress.Text.Trim();
            string category = tbUpdateCategory.Text.Trim();
            string gender = tbUpdateGender.Text.Trim();

            var conn = DBConnection.Connect();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("update users set Name='{0}', Email='{1}', MobileNo='{2}', Shift='{3}', Address='{4}', Category='{5}', Gender='{6}'where id={7}", name, email,mobile_no,shift,address,category,gender, id);

            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
           

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowInfo().Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();
        }












        private void EditInfo_Load(object sender, EventArgs e)
        {

        }

        
    }
}
