using Microsoft.EntityFrameworkCore.Storage;
using MultiScreen_Dotnet8.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        public IStudentRepository student { get; }
        public ISubjectRepository subject { get; }
        public ITeacherRepository teacher { get; }
        public IGradeRepository grade { get; }
        public IDbContextTransaction Transaction();
        public int Complete();

    }
}
