using System;
using System.Collections.Generic;
using System.Text;

namespace HalPriceTracker.Models
{
    public class Price
    {
        public int Id {  get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice {get; set; }
        public decimal AveragePrice { get; set; }
        public DateOnly Date { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;



    }
}
