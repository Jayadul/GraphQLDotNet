using GraphQL;
using GraphqlPractice.Contracts;
using GraphqlPractice.Entities.Context;
using GraphqlPractice.GraphQL.GraphQLSchema;
using GraphqlPractice.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.
services.AddDbContext<ApplicationContext>(opt =>
    opt.UseSqlServer(configuration.GetConnectionString("sqlConString")));

services.AddScoped<IOwnerRepository, OwnerRepository>();
services.AddScoped<IAccountRepository, AccountRepository>();

services.AddScoped<AppSchema>();
services.AddGraphQL(b => b
    .AddSystemTextJson()
    .AddGraphTypes()
);


services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL();

app.Run();
