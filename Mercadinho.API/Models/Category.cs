using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mercadinho.API.Models.Base;

namespace Mercadinho.API.Models;

[Table("category")]
public class Category : BaseEntity
{
    [Required]
    [StringLength(100)]
    [Column("name")]
    public string? Name { get; set; }
}