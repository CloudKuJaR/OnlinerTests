﻿using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsLogin
    {
        public static LoginForm loginForm = new LoginForm();
        public static void FillLoginForm()
        {

            loginForm.UsernameField.SendKeys(Config.Credentials.userMail);
            loginForm.PasswordField.SendKeys(Config.Credentials.userPassword);
            loginForm.loginButton.Click();

        }
    }
}
