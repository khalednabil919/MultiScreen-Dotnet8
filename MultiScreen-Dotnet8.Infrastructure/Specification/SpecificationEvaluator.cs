using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.Specification
{
    public static class SpecificationEvaluator<TEntity> where TEntity : class
    {
        public static IQueryable<TEntity> getQuery<TEnttiy>(IQueryable<TEntity> Query, Specification<TEntity> specification)
        {
            if(specification.Criteria is not null)
                Query.Where(specification.Criteria);

            if(specification.Includes.Any())
                Query = specification.Includes.Aggregate(Query, (current, include) => current.Include(include));

            if(specification.Order!=null)
                Query = Query.OrderBy(specification.Order);

            return Query;
        }

    }
}
