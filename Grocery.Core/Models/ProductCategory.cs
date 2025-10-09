using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public partial class ProductCategory : Model
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public ProductCategory(int id, int productId, int categoryId) : base(id, "")
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}
