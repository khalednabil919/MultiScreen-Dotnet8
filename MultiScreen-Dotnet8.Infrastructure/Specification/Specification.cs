using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.Specification
{
    public abstract class Specification<TEntity> where TEntity : class
    {
        public Expression<Func<TEntity,bool>>? Criteria { get; }
        public Specification(Expression<Func<TEntity,bool>> criteria)
        {
            Criteria = criteria;
        }
        
        public List<Expression<Func<TEntity, object>>> Includes { get; } = new();
        public Expression<Func<TEntity, object>> Order { get; private set; }
        protected void AddInclude(Expression<Func<TEntity, object>> expression)
        {
            Includes.Add(expression);
        }
        protected void OrderBy(Expression<Func<TEntity, object>> expression)
        {
            Order = expression;
        }

    }
}
