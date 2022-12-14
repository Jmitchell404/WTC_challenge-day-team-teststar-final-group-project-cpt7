using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static WeShare.GaugeSupport;

namespace WeShare.pages 
{
    public class PayRequestSentPage
    {

    private static IWebElement peopleThatOweMeHeading => Driver!.FindElement(By.XPath("/html/body/main/section/h2"));

    private static IWebElement paymentRequestSentLink => Driver!.FindElement(By.XPath("//*[@id='paymentrequests_sent']"));



    public void GoToPayRequestSent()
    {

        paymentRequestSentLink.Click();
        Driver!.Title.Should().Be("WeShare");
        peopleThatOweMeHeading.Text.Should().Be("People that owe me");

    }

    


    


    




    

    




    }






}