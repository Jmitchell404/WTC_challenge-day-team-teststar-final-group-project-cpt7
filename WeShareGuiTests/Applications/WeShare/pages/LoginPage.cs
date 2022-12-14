using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static WeShare.GaugeSupport;

namespace WeShare.pages 
{
    public class LoginPage
    {

    private const string Url = "http://localhost:5050";

    private static IWebElement emailField => Driver!.FindElement(By.XPath("//*[@id='email']"));

    private static IWebElement loginButton => Driver!.FindElement(By.XPath("//*[@id='submit']"));

    private static IWebElement paymentReqSentLink => Driver!.FindElement(By.XPath("//*[@id='paymentrequests_sent']"));

    private static IWebElement showLoggedIn => Driver!.FindElement(By.XPath("/html/body/p"));

    public LoginPage Open()
    {
        GaugeSupport.Driver!.Navigate().GoToUrl(Url);
        Driver.Title.Should().Be("WeShare");

        return this;
    }


    public HomePage SuccessfulLogin(string email)
    {
        emailField.SendKeys(email);
        loginButton.Click();
        return new HomePage();
    }

    public void LoggedOut()
    {
        showLoggedIn.Text.Should().Be("You are not logged in!");

    }








    

    




    }






}