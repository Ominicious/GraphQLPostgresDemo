using HotChocolate;
using HotChocolate.Data;
using System.Threading.Tasks;
using GraphQLPostgresDemo.Data;
using GraphQLPostgresDemo.Models;
namespace GraphQLPostgresDemo.GraphQL;

public class Mutation  {
    //[UseDbContext(typeof(AppDbContext))]
    public async Task<Book> AddBook(BookInput input,  [Service] AppDbContext context){
        var rand = new Random();
        var book = new Book{
            BookId = rand.Next(1000,10000),
            Name = input.Name,
            Pages = input.Pages,
            Price = input.Price,
            PublishDate = input.PublishDate,
            Genre = input.Genre
        };
        
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return book;
    }
}