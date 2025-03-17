using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLPostgresDemo.Models;

[Table("account")]
public class Account
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("account_number")]
    public string AccountNumber { get; set; } = string.Empty;

    [Column("holder_name")]
    public string HolderName { get; set; } = string.Empty;

    public ICollection<AccountBalance> Balances { get; set; } = new List<AccountBalance>();
}
