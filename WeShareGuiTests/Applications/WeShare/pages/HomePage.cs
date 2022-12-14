using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static WeShare.GaugeSupport;

namespace WeShare.pages 
{
    public class HomePage
    {

    private static IWebElement myExpensesHeading => Driver!.FindElement(By.XPath("/html/body/main/section/h2"));

    private static IWebElement userID => Driver!.FindElement(By.XPath("//*[@id='user']"));

    private static IWebElement payReqSentLink => Driver!.FindElement(By.XPath("//*[@id='paymentrequests_sent']"));

    private static IWebElement payReqRecLink => Driver!.FindElement(By.XPath("//*[@id='paymentrequests_received']"));

    private static IWebElement LogOut => Driver!.FindElement(By.Id("logout"));



    public void GoToHomePage(string email){

        Driver!.Title.Should().Be("WeShare");
        myExpensesHeading.Text.Should().Be("My Expenses");
        userID.Text.Should().Be(email);

    }



    public LoginPage LogOutWeShare()
    {

        LogOut.Click();
        return new LoginPage();
    }


    


    


    




    

    




    }






}