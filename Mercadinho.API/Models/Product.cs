using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mercadinho.API.Models.Base;

namespace Mercadinho.API.Models;

[Table("product")]
public class Product : BaseEntity
{
    [Required]
    [StringLength(100)]
    [Column("name")]
    public string? Name { get; set; }
    [StringLength(500)]
    [Column("description")]
    public string? Description { get; set; }
    [Required]
    [Range(0, 1000)]
    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }
    [StringLength(300)]
    [Column("image_url")]
    public string? ImageUrl { get; set; }
    [Required]
    [Column("categoryId"), ForeignKey("CategoryId")]
    public Category? Category { get; set; }
    
}