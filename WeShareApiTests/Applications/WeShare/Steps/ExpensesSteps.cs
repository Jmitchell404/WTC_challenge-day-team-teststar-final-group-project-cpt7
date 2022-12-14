using System.Collections.Generic;
using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;
using Applications.WeShare.Swagger.Client;
using System.Threading.Tasks;
using Applications.WeShare.Steps;

namespace Applications.WeShare.Steps {
    public class ExpensesSteps {
        private ExpenseDTO _expense;

        private List<ExpenseDTO> _expensesList;
        private readonly ExpensesApi _expenseApi = new ExpensesApi(StepsHelper.BasePath);

        [Step("Create new expense for personId <id> of description <desc>")]
        public void CreateNewExpense(int id, string desc)
        {
            _expense = _expenseApi.CreateExpense(new NewExpenseDTO(id, "09/12/2022", desc, 400));

        }

        [Step("Verify expense for personId <id> with description <desc> was created")]
        public void VerifyExpenseHasBeenFound(int id, string desc)
        {
            _expense.Should().NotBeNull();
            _expense.PersonId.Should().Be(id);
            _expense.Description.Should().Be(desc);
        }



        [Step("Find expense with id <id>")]
        public void FindExpenseWithId(int id)
        {
            _expense = _expenseApi.FindExpenseById(id);

        }

        [Step("Find expenses for person with personId <id>")]
        public void FindExpensesByPerson(int id)
        {
            _expensesList = _expenseApi.FindExpensesByPerson(id);

        }




        

        [Step("Verify expense has been found")]
        public void VerifyExpenseHasBeenFound()
        {
            _expense.Should().NotBeNull();
            _expense.ExpenseId.Should().Be(1);
        }

        [Step("Find all expenses")]
        public void FindAllExpenses()
        {
            _expensesList = _expenseApi.FindAllExpenses();

        }

        [Step("Verify expenses have been found")]
        public void VerifyExpensesHaveBeenFound()
        {
            _expensesList.Should().NotBeNull();
        }
    }
}