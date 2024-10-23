using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id{get;set;}
        [Range(1,100, ErrorMessage ="Display Order must be between 1-100")]
        [Display(Name="Display Order")]
        
        public int DisplayOrder{get;set;}
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string? Name{get;set;}
    }
}