using System.Collections.Generic;

namespace Module4.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Pie> Pies { get; set; }
    }
}