using MultiScreen_Dotnet8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.Specification.SpecificationsClasses
{
    public class GetStudentByIdSpecification : Specification<Student>
    {
        public GetStudentByIdSpecification(Expression<Func<Student, bool>> criteria) : base(criteria)
        {
            AddInclude(x => x.Grade);
            OrderBy(x => x.Address);
        }

    }
}
