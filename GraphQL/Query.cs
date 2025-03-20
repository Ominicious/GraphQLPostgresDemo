using GraphQLPostgresDemo.Data;
using GraphQLPostgresDemo.Models;
using Microsoft.EntityFrameworkCore;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace GraphQLPostgresDemo.GraphQL;

public class Query
{
    public IQueryable<Book> GetBooks([Service] AppDbContext context, string nameContains) =>
        context.Books.Where(b => b.Name.Contains(nameContains));
    
    //public IQueryable<Book> GetBooks([Service] AppDbContext context) =>
    //    context.Books;
    
    public IQueryable<Magazine> GetMagazines([Service] AppDbContext context) =>
        context.Magazines;
    
    public IQueryable<Account> GetAccounts([Service] AppDbContext context) =>
        context.Accounts.Include(a => a.Balances);

    public IQueryable<IReadingMaterials> GetReadingMaterials([Service] AppDbContext context) =>
        context.Books.Cast<IReadingMaterials>()
            .Concat(context.Magazines.Cast<IReadingMaterials>());
            
    public IQueryable<IThings> GetThings([Service] AppDbContext context) =>
        context.Books.Cast<IThings>()
            .Concat(context.Magazines.Cast<IThings>());
}