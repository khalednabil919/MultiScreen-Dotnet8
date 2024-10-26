using Autofac;
using MultiScreen_Dotnet8.BussinessLogic.Services;
using MultiScreen_Dotnet8.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.BussinessLogic
{
    public class BusinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<StudentService>().As<IStudentService>()
                    .InstancePerLifetimeScope();

            builder.RegisterType<GradeService>().As<IGradeService>()
              .InstancePerLifetimeScope();
            builder.RegisterType<TeacherService>().As<ITeacherService>()
              .InstancePerLifetimeScope();

        }

    }
}
