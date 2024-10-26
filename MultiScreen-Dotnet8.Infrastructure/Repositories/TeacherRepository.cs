﻿using Microsoft.EntityFrameworkCore;
using MultiScreen_Dotnet8.Core.Entities;
using MultiScreen_Dotnet8.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.Repositories
{
    public class TeacherRepository:GenericRepository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(DbContext context):base(context)
        {
            
        }
    }
}
