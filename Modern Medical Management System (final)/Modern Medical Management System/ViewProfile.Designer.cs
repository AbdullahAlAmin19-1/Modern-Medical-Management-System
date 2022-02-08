
namespace Modern_Medical_Management_System
{
    partial class ViewProfile
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbReceptionist = new System.Windows.Forms.RadioButton();
            this.rbDoctor = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMobileNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.gbShift = new System.Windows.Forms.GroupBox();
            this.rbNight = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDashBord = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.gbShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(70, 292);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 27);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(70, 239);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(99, 31);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(70, 134);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(99, 29);
            this.btnViewProfile.TabIndex = 6;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome To Manager\'s Profile";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(70, 186);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(99, 31);
            this.btnEditProfile.TabIndex = 9;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Date of Birth";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(86, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(12, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbReceptionist
            // 
            this.rbReceptionist.AutoSize = true;
            this.rbReceptionist.Enabled = false;
            this.rbReceptionist.Location = new System.Drawing.Point(163, 21);
            this.rbReceptionist.Name = "rbReceptionist";
            this.rbReceptionist.Size = new System.Drawing.Size(107, 21);
            this.rbReceptionist.TabIndex = 4;
            this.rbReceptionist.TabStop = true;
            this.rbReceptionist.Text = "Receptionist";
            this.rbReceptionist.UseVisualStyleBackColor = true;
            // 
            // rbDoctor
            // 
            this.rbDoctor.AutoSize = true;
            this.rbDoctor.Enabled = false;
            this.rbDoctor.Location = new System.Drawing.Point(86, 21);
            this.rbDoctor.Name = "rbDoctor";
            this.rbDoctor.Size = new System.Drawing.Size(71, 21);
            this.rbDoctor.TabIndex = 3;
            this.rbDoctor.TabStop = true;
            this.rbDoctor.Text = "Doctor";
            this.rbDoctor.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Enabled = false;
            this.rbAdmin.Location = new System.Drawing.Point(12, 21);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbAdmin.TabIndex = 2;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Enabled = false;
            this.rbDay.Location = new System.Drawing.Point(65, 21);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(54, 21);
            this.rbDay.TabIndex = 2;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Enabled = false;
            this.rbOther.Location = new System.Drawing.Point(178, 21);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(65, 21);
            this.rbOther.TabIndex = 7;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(334, 274);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(171, 22);
            this.tbAddress.TabIndex = 35;
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Enabled = false;
            this.tbMobileNumber.Location = new System.Drawing.Point(334, 225);
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.Size = new System.Drawing.Size(171, 22);
            this.tbMobileNumber.TabIndex = 34;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(334, 176);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(171, 22);
            this.tbEmail.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(334, 129);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 22);
            this.tbName.TabIndex = 32;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbOther);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(228, 444);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(277, 48);
            this.gbGender.TabIndex = 31;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rbReceptionist);
            this.gbCategory.Controls.Add(this.rbDoctor);
            this.gbCategory.Controls.Add(this.rbAdmin);
            this.gbCategory.Location = new System.Drawing.Point(228, 376);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(277, 48);
            this.gbCategory.TabIndex = 30;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // gbShift
            // 
            this.gbShift.Controls.Add(this.rbNight);
            this.gbShift.Controls.Add(this.rbDay);
            this.gbShift.Location = new System.Drawing.Point(228, 313);
            this.gbShift.Name = "gbShift";
            this.gbShift.Size = new System.Drawing.Size(277, 48);
            this.gbShift.TabIndex = 29;
            this.gbShift.TabStop = false;
            this.gbShift.Text = "Shift";
            // 
            // rbNight
            // 
            this.rbNight.AutoSize = true;
            this.rbNight.Enabled = false;
            this.rbNight.Location = new System.Drawing.Point(163, 21);
            this.rbNight.Name = "rbNight";
            this.rbNight.Size = new System.Drawing.Size(62, 21);
            this.rbNight.TabIndex = 3;
            this.rbNight.TabStop = true;
            this.rbNight.Text = "Night";
            this.rbNight.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // tbDOB
            // 
            this.tbDOB.Enabled = false;
            this.tbDOB.Location = new System.Drawing.Point(334, 516);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(171, 22);
            this.tbDOB.TabIndex = 39;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(334, 88);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(171, 22);
            this.tbId.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Id";
            // 
            // btnDashBord
            // 
            this.btnDashBord.Location = new System.Drawing.Point(70, 88);
            this.btnDashBord.Name = "btnDashBord";
            this.btnDashBord.Size = new System.Drawing.Size(99, 27);
            this.btnDashBord.TabIndex = 42;
            this.btnDashBord.Text = "DashBord";
            this.btnDashBord.UseVisualStyleBackColor = true;
            this.btnDashBord.Click += new System.EventHandler(this.btnDashBord_Click);
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 564);
            this.Controls.Add(this.btnDashBord);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDOB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbMobileNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.gbShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.label1);
            this.Name = "ViewProfile";
            this.Text = "View Profile";
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.gbShift.ResumeLayout(false);
            this.gbShift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbReceptionist;
        private System.Windows.Forms.RadioButton rbDoctor;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbMobileNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.GroupBox gbShift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNight;
        private System.Windows.Forms.Button btnDashBord;
    }
}