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
    public partial class Login : Form
    {
        internal static string id = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) 
                { Application.Exit(); }
        }
        public bool check(string value)
        {
            if (value == null || value == "") { return false; }
            else { return true; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string password = tbPassword.Text.Trim();

            string errMsg = null;
            int flag = 1;
            if (check(name)) { }
            else { errMsg += "\nEnter Name"; flag = 0; }
            if (check(password)) { }
            else { errMsg += "\nEnter Password"; flag = 0; }
            if (flag == 0) { MessageBox.Show(errMsg); }
            

            if (flag == 1) 
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

                string query = string.Format("select * from users where Name='{0}' and Password='{1}'", name, password);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = "" + reader.GetInt32(reader.GetOrdinal("Id"));
                        MessageBox.Show("Login Completed");
                        this.Hide();
                        new DashBord().Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Faild");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }
    }
}
