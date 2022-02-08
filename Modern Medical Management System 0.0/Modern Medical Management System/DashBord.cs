using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Medical_Management_System
{
    public partial class DashBord : Form
    {
        public DashBord()
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
    }
}
