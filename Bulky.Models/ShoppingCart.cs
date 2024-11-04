using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Bulky.Models;

public class ShoppingCart
{
    public int Id{get;set;}
    public int ProductId{get;set;}
    [ForeignKey("ProductId")]
    [ValidateNever]
    public Product Product{get;set;}
    [Range(1, 1000, ErrorMessage ="Please enter a value bet 1-1000")]
    public int Count{get;set;}
    
    public string? ApplicationuserId{get;set;}
    [ForeignKey("ApplicationUserId")]
    [ValidateNever]
    public ApplicationUser ApplicationUser{get;set;}
}
