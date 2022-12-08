using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;
using Applications.WeShare.Swagger.Client;
using System.Threading.Tasks;
using Applications.PetStore.Steps;

namespace Applications.WeShare.Steps {
    public class ExpensesSteps {
        private ExpenseDTO _expense;
        private readonly ExpensesApi _expenseApi = new ExpensesApi(StepsHelper.BasePath);

        [Step("Find expense with id <1>")]
        public void FindExpenseWithId(int id)
        {
            _expense = _expenseApi.FindExpenseById(id);

        }

        [Step("Verify expense has been found")]
        public void VerifyExpenseHasBeenFound()
        {
            _expense.Should().NotBeNull();
            _expense.ExpenseId.Should().Be(1);
        }
    }
}