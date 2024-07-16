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
using TimeClock.DAL;
using TimeClock.Services;

namespace TimeClock
{
    public partial class LoginForm : Form//ReaLTaiizor.Forms.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            var res = ManagerService.Login(textBox_tz.Text, textBox_password.Text);
            if (res.Rows.Count > 0)
            {
                var elem = res.Rows[0];
                if ((DateTime)elem["ExpiryDate"] < DateTime.Now)
                {
                    MessageBox.Show("your password is expire\nplease change your password");
                }
                else
                {
                    NavigationService.ShowForm(Models.FormsEnum.CLOCK_FORM);
                }
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }

        private void Button_changePassword_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm(Models.FormsEnum.CHANGE_PASSWORD_FORM);
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
