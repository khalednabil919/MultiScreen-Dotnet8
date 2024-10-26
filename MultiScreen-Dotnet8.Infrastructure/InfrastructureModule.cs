using Autofac;
using Microsoft.EntityFrameworkCore;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure
{
    public class InfrastructureModule : Module 
    {
        // IOC Container Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();
        }
    }
}
