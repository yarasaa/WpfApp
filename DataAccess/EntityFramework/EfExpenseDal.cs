using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfExpenseDal : IExpenseDal
    {
        public void Add(Expense entity)
        {
            using (ExpenseContext context=new ExpenseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Expense entity)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Expense> GetAll(Expression<Func<Expense, bool>> filter = null)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                return filter == null 
                    ? context.Set<Expense>().ToList() 
                    : context.Set<Expense>().Where(filter).ToList();
            }
        }

        public void Update(Expense entity)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
