using OpenQA.Selenium;
using static WeShare.GaugeSupport;
using FluentAssertions;



namespace WeShare.pages
{

    public class ResultsPage{

    private static IWebElement badEmail => Driver!.FindElement(By.XPath("/html/body/pre"));


        public ResultsPage(string text){

            if (text == "bademail"){
                badEmail.Text.Should().Be("Bad email address");
            }
        }   


    }





}