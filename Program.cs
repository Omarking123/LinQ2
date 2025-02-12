
using System.Collections;
using static LinQ2.ListGenerator;
namespace LinQ2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region video 1 
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry"
            //             select p;


            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where(p => p.Category == "Meat/Poultry");


            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == " Meat/Poultry"
            //             select p;

            //var result = ProductList.Where((p, index) => index < 10 && p.UnitsInStock == 0);

            //ArrayList arraylist = new ArrayList() { 1, 3, 4, "ahmed", "ali ", 1.3, 1.4, 1.5f, 13.4f, 1.4m };
            //var result = arraylist.OfType<int>();

            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where((p, i) => i < 5);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region video2
            //var result = ProductList.Select(p => p);
            //var result = ProductList.Select(p => p.ProductName);

            //var result = from p in ProductList
            //             select p.ProductName;


            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood")
            //    .Select(p => new {p.Category , oldprice =  p.ProductName , newprice = p.UnitPrice - p.UnitPrice *0.1m});


            //var result = CustomerList.Select(c => c.CustomerName);
            //var result = CustomerList.SelectMany(c => c.Orders);


            //var result = from c in CustomerList
            //             form o in c.orders
            //             select o;

            // var result = ProductList.Select((p, i) => new { i, p.ProductName }).Where (p=>p.i<5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
