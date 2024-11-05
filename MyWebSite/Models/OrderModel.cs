using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models;

public class OrderModel
{
    [Key]
    public int Id{get;set;}
    
    [Required]
    public string Date{get;set;}
    
    [Required]
    public string CustomerName{get;set;}
    
    [Required]
    public int Quantity{get;set;}
    
    [Required]
    public int AdminId{get;set;}
    
    [Required]
    public int ProductId{get;set;}
    
}