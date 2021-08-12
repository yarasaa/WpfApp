using Business.Concrete;
using DataAccess.EntityFramework;
using System;

namespace ConsoleUITester
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseManager expenseManager = new ExpenseManager(new EfExpenseDal());
            foreach (var expense in expenseManager.GetAll())
            {
                Console.WriteLine(expense.Car);
            }
        }
    }
}
