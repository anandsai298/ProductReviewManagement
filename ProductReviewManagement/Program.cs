// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ProductReviewManagement;
class program
{
    static void Main(string[] args )
    {
      Console.WriteLine("ProductReviewManagement");
        List<ProductDetails> list = new List<ProductDetails>();
        list.Add( new ProductDetails { ProductID=1,UserID=1,Rating=5,Review="Good",IsLikeFields=true } );
        list.Add(new ProductDetails { ProductID = 2, UserID = 1, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 3, UserID = 1, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 5, UserID = 1, Rating = 4, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 6, UserID = 3, Rating = 3, Review = "AVG", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 7, UserID = 1, Rating = 3, Review = "AVG", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 8, UserID = 4, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 9, UserID = 3, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 10, UserID = 2, Rating = 2, Review = "BELOW_AVG", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 11, UserID = 5, Rating = 2, Review = "BELOW_AVG", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 12, UserID = 6, Rating = 1, Review = "WORST", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 13, UserID = 7, Rating = 1, Review = "WORST", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 14, UserID = 4, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 15, UserID = 5, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 16, UserID = 8, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 17, UserID = 9, Rating = 3, Review = "AVG", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 18, UserID = 10, Rating = 4, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 19, UserID = 11, Rating = 1, Review = "WORST", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 20, UserID = 12, Rating = 2, Review = "BELOW_AVG", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 21, UserID = 13, Rating = 1, Review = "WORST", IsLikeFields = false });
        list.Add(new ProductDetails { ProductID = 22, UserID = 19, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 23, UserID = 11, Rating = 5, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 24, UserID = 12, Rating = 4, Review = "Good", IsLikeFields = true });
        list.Add(new ProductDetails { ProductID = 25, UserID = 11, Rating = 5, Review = "Good", IsLikeFields = true });
        Console.WriteLine(list.Count);
        ProductOperations productOperations = new ProductOperations();
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("1.RetrieveTopRecords\n2.RetrieveRecordsWRT_RatingAndUserID\n3.RetrieveCountOfReviewPresent");
            Console.WriteLine("Select option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    productOperations.RetrieveTopRecords(list);
                    break;
                case 2:
                    productOperations.RetrieveRecordsWRT_RatingAndUserID(list);
                    break;
                case 3:
                    productOperations.RetrieveCountOfReviewPresent(list);
                    break;
            }
        }
    }
}
