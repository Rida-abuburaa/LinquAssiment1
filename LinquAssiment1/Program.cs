using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;

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


            #region  Sort all products by UnitPrice (ascending). Print each  product's name and price. 
            // var query = Source.ProductList.OrderBy(p => p.UnitPrice)
            //   .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion


            #region  4. Get all products where UnitPrice is between 10 and 30

            //var query = Source.ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30)
            //.Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Get all products that are in stock (UnitsInStock > 0) and  belong to the "Condiments" category.
            // var query = Source.ProductList.Where(P => P.UnitPrice > 0 && P.Category == "Condiments")
            // .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion


            #region 6. Create a new anonymous type with three properties: 
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, 
            //otherwise "Out of Stock"
            //● Print the result.

            // var product = new { Name = "Laptop", unitprice = 123000 };







            #endregion

            #region 
            #endregion



            foreach (var item in query)
            {
                Console.WriteLine(item);

            }

        }
    }
}
