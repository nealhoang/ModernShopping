﻿namespace ModernShopping.Application.Dtos.Products
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        //public int? SupplierId { get; set; }
        //public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

        public string Category { get; set; }
        public string Supplier { get; set; }
    }
}