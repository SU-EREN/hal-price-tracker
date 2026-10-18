

namespace HalPriceTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int SourceCategoryId { get; set; }
       
        public required string Name { get; set; }
        
    }
}
