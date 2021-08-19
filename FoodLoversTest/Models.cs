using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLoversTest
{
    public class BranchModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime? OpenDate { get; set; }

    }

    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool WeightedItem { get; set; }
        public decimal? SuggestedSellingPrice { get; set; }
    }

    public class BranchProductModel
    {
        public int BranchID { get; set; }
        public int ProductID { get; set; }
    }
}
