using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLPostgresDemo.Models;

[Table("account_balance")]
public class AccountBalance
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("balance")]
    public decimal Balance { get; set; }
    
    [Column("last_updated")]
    public DateTime LastUpdated { get; set; }

    [ForeignKey("Account")]
    [Column("account_id")]
    public int AccountId { get; set; }
    public Account? Account { get; set; }
}
