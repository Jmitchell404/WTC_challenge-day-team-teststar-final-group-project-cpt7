using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using WeShare.pages;
using System;



namespace WeShare.steps
{
    public class HomePageStep
    {
        private readonly PayRequestSentPage _payReqSentPage = new PayRequestSentPage();
        private readonly PayRequestReceivedPage _payReqRecPage = new PayRequestReceivedPage();

        private readonly HomePage _homePage = new HomePage();


        

        [Step("Person wants to see who owes them")]
        public void PaymentRequestSentPage() => _payReqSentPage.GoToPayRequestSent();



        [Step("Person wants to see who they owe")]
        public void PayRequestReceivedPage() => _payReqRecPage.GoToPayRequestReceived();

      [Step("Person logs out weShare")]
        public void LogOutWeShare() => _homePage.LogOutWeShare().LoggedOut();









    }




}