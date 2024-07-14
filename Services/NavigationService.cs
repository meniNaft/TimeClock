using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.Models;

namespace TimeClock.Services
{
    public class NavigationService
    {
        private readonly Dictionary<FormsEnum, Form> forms;
        public NavigationService() { 
            forms = new Dictionary<FormsEnum, Form>
            {
                { FormsEnum.LOGIN_FORM, new LoginForm(this) },
                { FormsEnum.CLOCK_FORM, new ClockForm() },
                { FormsEnum.CHANGE_PASSWORD_FORM, new ChangePasswordForm(this) }
            };
            forms[FormsEnum.LOGIN_FORM].Show();
        }

        public void ShowForm(FormsEnum formToShow)
        {
            foreach (var form in forms)
            {
                if(form.Key == formToShow && !form.Value.Visible)
                {
                    form.Value.Show();
                }
                else
                {
                    if(form.Value.Visible)
                    form.Value.Hide();
                }
            }
        }
    }
}
