using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.Models;

namespace TimeClock.Services
{
    static public class NavigationService
    {
        static public bool isNavigate = false;
        static private void CloseAllforms()
        {
            isNavigate = true;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToArray())
            {
                form.Close();
            }
            isNavigate = false;
        }
       static public void ShowForm(FormsEnum formToShow)
        {
            CloseAllforms();
            Form result = formToShow switch
            {
                FormsEnum.LOGIN_FORM => new LoginForm(),
                FormsEnum.CHANGE_PASSWORD_FORM => new ChangePasswordForm(),
                FormsEnum.CLOCK_FORM => new ClockForm(),
                _ => throw new ArgumentException("Invalid form type specified.")
            };
            result.Show();
        }
    }
}
