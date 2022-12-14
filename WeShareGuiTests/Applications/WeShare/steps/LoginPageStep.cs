using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using WeShare.pages;
using System;



namespace WeShare.steps
{
    public class LoginPageStep
    {
        private readonly LoginPage _loginPage = new LoginPage();

        [Step("Open landing page of Weshare")]
        public void OpenLandingPageOfWeshare() => _loginPage.Open();


    [Step("Person successfully logs in with <email>")]
    public void LoginSuccess(string email){
        _loginPage.SuccessfulLogin(email).GoToHomePage(email);

    }





    }




}