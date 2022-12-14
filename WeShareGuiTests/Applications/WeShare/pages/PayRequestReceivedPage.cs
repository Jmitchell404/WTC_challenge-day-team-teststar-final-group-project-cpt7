using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using System.Threading.Tasks;
using OpenQA.Selenium;
using static WeShare.GaugeSupport;

namespace WeShare.pages 
{
    public class PayRequestReceivedPage
    {

    private static IWebElement peopleThatIOweHeading => Driver!.FindElement(By.XPath("/html/body/main/section/h2"));


    private static IWebElement payRequestReceivedLink => Driver!.FindElement(By.XPath("//*[@id='paymentrequests_received']"));


    public void GoToPayRequestReceived()
    {
        payRequestReceivedLink.Click();
        Driver!.Title.Should().Be("WeShare");
        peopleThatIOweHeading.Text.Should().Be("People that you owe");

    }

    


    


    




    

    




    }






}