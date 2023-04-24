using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public  class ProductOperations
    {
        public void RetrieveTopRecords(List<ProductDetails>list)
        {
            var res = list.Where(x => x.Rating == 5).Take(3);
            foreach(var item in res)
            {
                Console.WriteLine("ProductID:->"+item.ProductID+  "\n" + "UserID:->" + item.UserID+ "\n"+ "Rating:->" + item.Rating+ "\n"+ "Review:->" + item.Review+ "\n" + "IsLikeFields:->" + item.IsLikeFields);
            }
        }
    }
}
