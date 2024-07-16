using Microsoft.VisualBasic;
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
using TimeClock.Models;
using TimeClock.Services;

namespace TimeClock
{
    public partial class ClockForm : Form
    {
        private readonly string DateFormat = "dd/MM/yyyy HH:mm:ss";
        public ClockForm()
        {
            InitializeComponent();
            GetLastAttendance();
        }

        private void Button_enter_Click(object sender, EventArgs e)
        {
            if(label_lastEnterDateValue.Text != ""  && label_lastExitDateValue.Text == "")
            {
                MessageBox.Show("please press on exit");
            }
            else
            {
                DateTime now = DateTime.Now;
                ManagerService.NewEnter(now);
                label_lastEnterDateValue.Text = now.ToString(DateFormat);
                label_lastExitDateValue.Text = string.Empty;
            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            if(label_lastEnterDateValue.Text == "" || label_lastExitDateValue.Text != "")
            {
                MessageBox.Show("please press on enter");
            }
            else
            {
                DateTime now = DateTime.Now;
                ManagerService.NewExit(now);
                label_lastExitDateValue.Text = now.ToString(DateFormat);
            }
        }

        private void LinkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.ShowForm(FormsEnum.LOGIN_FORM);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }

            public void GetLastAttendance()
        {
            var row = ManagerService.GetLastAttendance();
            if (row != null) {
                DateTime lastEntry = (DateTime)row["EntryTime"];
                DateTime? lastExit = row["ExitTime"] != DBNull.Value ?(DateTime)row["ExitTime"] : null; 
                label_lastEnterDateValue.Text = lastEntry.ToString(DateFormat);
                label_lastExitDateValue.Text = lastExit?.ToString(DateFormat) ?? "";
                label_tzValue.Text = (string)row["employeeNat"];
            }
        }
    }
}
