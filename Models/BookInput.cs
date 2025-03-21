namespace GraphQLPostgresDemo.Models;

public class BookInput
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishDate { get; set; }
    public BookGenre Genre { get; set; }
}