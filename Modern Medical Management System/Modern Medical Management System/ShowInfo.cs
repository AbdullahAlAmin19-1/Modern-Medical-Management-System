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
    public partial class ShowInfo : Form
    {
        public ShowInfo()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }

      

        //Data Retrieve functionality from Database
        List<User> GetAllUsers()
        {
            var conn = DBConnection.Connect();
            List<User> users = new List<User>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from users";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User();
                    u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    u.Name = reader.GetString(reader.GetOrdinal("Name"));
                    u.Email = reader.GetString(reader.GetOrdinal("Email"));
                    u.MobileNo = reader.GetString(reader.GetOrdinal("MobileNo"));
                    u.Shift = reader.GetString(reader.GetOrdinal("Shift"));
                    u.Address = reader.GetString(reader.GetOrdinal("Address"));
                    u.Category = reader.GetString(reader.GetOrdinal("Category"));
                    u.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    u.DateofBirth = reader.GetString(reader.GetOrdinal("DateofBirth"));
                    users.Add(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return users;
        }

        //When we just run/Refresh the From Data is Automatically Loaded from Database
        private void ShowInfo_Load(object sender, EventArgs e)
        {
            var users = GetAllUsers();
            dtUsers.DataSource = users;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                new DashBord().Show();
            
        }

        //Back to DashBoard

    }
}
