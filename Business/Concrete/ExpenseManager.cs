using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        IExpenseDal _expenseDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public List<Expense> GetAll()
        {
            return _expenseDal.GetAll();
        }

        public void Add(Expense expense)
        {
            _expenseDal.Add(expense);
        }

        public void Update(Expense expense)
        {
            _expenseDal.Update(expense);
        }
        public void Delete(Expense expense)
        {
            _expenseDal.Delete(expense);
        }
    }
}
