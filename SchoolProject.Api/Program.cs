using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Service;
using SchoolProject.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection to Sql server
builder.Services.AddDbContext<AppliactionDBContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});

#region Dependency Injection
builder.Services.AddInfrastuctureDependencies()
    .AddServiceDependencies()
    .AddCoreDependencies();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
