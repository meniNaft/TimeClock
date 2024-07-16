using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClock.Models;
using TimeClock.Services;

namespace TimeClock
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void Button_changePassword_Click(object sender, EventArgs e)
        {
            SqlResultOption res = ManagerService.ChangePassword(textBox_tz.Text, textBox_oldPassword.Text, textBox_newPassword.Text);
            if (res == SqlResultOption.SUCCESS)
            {
                NavigationService.ShowForm(FormsEnum.CLOCK_FORM);
            }
            else if(res == SqlResultOption.NO_USER_FOUND)
            {
                MessageBox.Show("user not found");
            }
            else
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void LinkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.ShowForm(FormsEnum.LOGIN_FORM);
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
