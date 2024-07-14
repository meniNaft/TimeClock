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
        private NavigationService Service;
        public ChangePasswordForm(NavigationService service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            bool success = ManagerService.ChangePassword(textBox_tz.Text, textBox_oldPassword.Text, textBox_newPassword.Text);
            if (success)
            {
                Service.ShowForm(FormsEnum.CLOCK_FORM);
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Service.ShowForm(FormsEnum.LOGIN_FORM);
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
          
        }

        protected override void OnFormClosing(FormClosingEventArgs e) => Application.Exit();
    }
}
