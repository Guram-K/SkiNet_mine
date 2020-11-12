using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        // db.where(i => i.id == id)
        public Expression<Func<T, bool>> Criteria { get; }
        // db.Include(p => p.ProductType);
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();


        public BaseSpecification() { }
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }


        protected void AddInculde(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
