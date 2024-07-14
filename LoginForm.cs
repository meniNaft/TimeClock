using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClock.Services;

namespace TimeClock
{
    public partial class LoginForm : Form//ReaLTaiizor.Forms.MaterialForm
    {
        private NavigationService Service;
        public LoginForm(NavigationService service)
        {
            InitializeComponent();
            Service = service;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            bool isExist = ManagerService.Login(textBox_tz.Text, textBox_password.Text);
            if (isExist)
            {
                Service.ShowForm(Models.FormsEnum.CLOCK_FORM);
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            Service.ShowForm(Models.FormsEnum.CHANGE_PASSWORD_FORM);
        }

        protected override void OnFormClosing(FormClosingEventArgs e) => Application.Exit();
    }
}
