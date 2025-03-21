using GraphQLPostgresDemo.Data;
using GraphQLPostgresDemo.GraphQL;
using GraphQLPostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

// Add GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Book>()
    .AddType<Magazine>()
    .AddInterfaceType<IReadingMaterials>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();