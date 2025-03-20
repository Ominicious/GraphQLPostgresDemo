using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLPostgresDemo.Models;

[Table("magazines")]
public class Magazine : IReadingMaterials, IThings
{
    [Key]
    [Column("magazineid")]
    public int MagazineId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("pages")]
    public int Pages { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("publishdate")]
    public DateTime PublishDate { get; set; }

    [Column("genre")]
    public BookGenre Genre { get; set; }
}