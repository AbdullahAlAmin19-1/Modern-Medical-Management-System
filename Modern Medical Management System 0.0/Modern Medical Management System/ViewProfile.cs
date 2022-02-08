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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteUser().Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditProfile().Show();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
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
    }
}
