﻿using EcommerceLibrary;

namespace DbEcommerceApp.Data.Models;
public class Product 
{
    public int Id { get; set; }
    public int Price { get; set; }  
    public string Name { get; set; } = null!;
    public string Make { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Image { get; set; } = null!;
    public bool IsInBasket { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public ICollection<OrderProduct>? OrderProducts { get; set; } 
}