using LINQ.DataSources;
using LINQ.Models;

namespace LinquAssiment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get all products from the "Seafood" category. Print each +product's name and price. 

            /*  var query = Source.ProductList.Where (p => p.Category == "Seafood")
                          .Select(p => new { p.ProductName, p.UnitPrice });

              foreach (var item in query)
              {
                  Console.WriteLine(item);

              }*/

            #endregion


            #region  Get a list of only the product names from ProductList. Print each name.
           // var query = Source.ProductList.Select(p => p.ProductName);

            #endregion

                 foreach (var item in query)
            {
                Console.WriteLine(item);

            }

        }
    }
}
