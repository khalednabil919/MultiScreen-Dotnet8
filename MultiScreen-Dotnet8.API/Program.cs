using Autofac.Extensions.DependencyInjection;
using Autofac;
using MultiScreen_Dotnet8.BussinessLogic;
using MultiScreen_Dotnet8.Infrastructure;
using MultiScreen_Dotnet8.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MultiScreen_Dotnet8.BussinessLogic.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string conStr = builder.Configuration.GetConnectionString("ConStr")!;

builder.Services.AddDbContext(conStr!);
builder.Services.AddCors();
//var isDevelopment = builder.Environment.IsDevelopment();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new InfrastructureModule());
    builder.RegisterModule(new BusinessLogicModule());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(BusinessLogicModule));

builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfile());
}).CreateMapper());

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "CorsPolicy", (conf) =>
    {
        conf.WithOrigins(builder.Configuration["CorsUrl:FrontendUrl"])
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});


var app = builder.Build();
app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
