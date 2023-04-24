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
        public void RetrieveRecordsWRT_RatingAndUserID(List<ProductDetails> list)
        {
            var res = list.Where(x => x.Rating > 3 && (x.ProductID==1 || x.ProductID ==4 || x.ProductID == 9));
            foreach (var item in res)
            {
                Console.WriteLine("ProductID:->" + item.ProductID + "\n" + "UserID:->" + item.UserID + "\n" + "Rating:->" + item.Rating + "\n" + "Review:->" + item.Review + "\n" + "IsLikeFields:->" + item.IsLikeFields);
            }
        }
        public void RetrieveCountOfReviewPresent(List<ProductDetails> list)
        {
            var res = list.GroupBy(x => x.UserID).Select(x=>new { UserID=x.Key, Count = x.Count() });
            foreach (var item in res)
            {
                Console.WriteLine("UserID:->" + item.UserID + "\n"+item.Count);
            }
        }
    }
}
