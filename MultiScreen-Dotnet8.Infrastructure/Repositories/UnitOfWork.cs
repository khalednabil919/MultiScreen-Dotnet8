using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.Core.Interfaces.Repository;
using MultiScreen_Dotnet8.Infrastructure.DBContexts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MultiScreenDBContext _context;

        public IStudentRepository student { get; }

        public ISubjectRepository subject { get; }

        public ITeacherRepository teacher { get; }

        public IGradeRepository grade { get; }


        public UnitOfWork(MultiScreenDBContext context)
        {
            _context = context;
            student = new StudentRepository(_context);
            subject = new SubjectRepository(_context);
            teacher = new TeacherRepository(_context);
            grade = new GradeRepository(_context);

        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IDbContextTransaction Transaction()
        {
            if (_context.Database.CurrentTransaction == null)
                return _context.Database.BeginTransaction();
            return null!;
        }
    }
}
