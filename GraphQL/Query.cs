using GraphQLPostgresDemo.Data;
using GraphQLPostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLPostgresDemo.GraphQL;

public class Query
{
    public IQueryable<Account> GetAccounts([Service] AppDbContext context) =>
        context.Accounts.Include(a => a.Balances);
}