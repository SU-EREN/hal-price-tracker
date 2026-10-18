using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HalPriceTracker.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SourceProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public required string Name { get; set; }
       
        public required string Unit { get; set; }
            
    }
}
