using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Steps;

namespace Steps {
    public class PeopleSteps {
        private Person _person;
        private readonly PeopleApi _peopleApi = new PeopleApi(StepsHelper.BasePath);


        [Step("student logs in with correct email <email>")]
        public void StudentLogsInWithCorrectEmail(string email)
        {
            var loginDto= new LoginDTO(email);
            _person = _peopleApi.Login(loginDto);
            _person.Email.Should().Be("student1@wethinkcode.co.za");
        }
        

        [Step("student logs in with invalid email <email>")]
        public void StudentLogsInWithInvalidEmail(string email)
        {
            var loginDto= new LoginDTO(email);
            Action login = () => _peopleApi.Login(loginDto);
            login.Should().Throw<ApiException>();
        }

        
    }
}