using Linq2.Data_Sources;
using Linq2.Helpers;
using Linq2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - ${p.UnitPrice}");
            #endregion

            #region Q2
            //int pageNumber = 2;
            //int pageSize = 5;

            //var result = Source.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //foreach (var p in result)
            //    Console.WriteLine(p.ProductName);
            #endregion

            #region Q3
            //var result = Source.ProductList.TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - ${p.UnitPrice}");
            #endregion

            #region Q4
            //bool allInStock = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine(allInStock);
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };

            //bool exists = ids.Contains(9);

            //Console.WriteLine(exists); 
            #endregion

            #region Q6
            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");
            //}
            #endregion

            #region Q7
            //var result = Source.ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    ProductNames = g.Select(p => p.ProductName)
            //});

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine($"  {name}");
            //}
            #endregion

            #region Q8
            //var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);

            //foreach (var category in result)
            //    Console.WriteLine(category);
            #endregion

            #region Q9
            //var result =
            //from c in Source.CustomerList
            //group c by c.Country into countryGroup
            //select new
            //{
            //    Country = countryGroup.Key,
            //    Count = countryGroup.Count(),
            //    TotalOrderValue = countryGroup
            //        .SelectMany(c => c.Orders)
            //        .Sum(o => o.Total)
            //};

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} | Customers: {item.Count} | " +
            //        $"Total: {item.TotalOrderValue}");
            //}
            #endregion

            #region Q10
            //int totalUnits = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(totalUnits);
            #endregion

            #region Q11
            //decimal cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //decimal highestPrice = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest price: ${cheapestPrice}");
            //Console.WriteLine($"Highest price: ${highestPrice}");
            #endregion

            #region Q12
            //var result = Source.ProductList.Select(p => p.Category).Distinct();

            //foreach (var category in result)
            //    Console.WriteLine(category);
            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var id in result)
            //    Console.WriteLine(id);
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(
            //    list2,
            //    new StringCaseInsensitiveComparer());

            //foreach (string country in result)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion

            #region Q15
            //Dictionary<int, Product> productDictionary =Source.ProductList.ToDictionary(p => p.ProductID);

            //if (productDictionary.TryGetValue(18, out Product? product))
            //{
            //    Console.WriteLine(product.ProductName);
            //    Console.WriteLine(product.UnitPrice);
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            #endregion

            #region Q16
            //var product = Source.ProductList.First(p => p.UnitPrice > 50);

            //Console.WriteLine(product.ProductName);
            #endregion

            #region Q17
            //var product = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //if (product != null)
            //    Console.WriteLine(product.ProductName);
            //else
            //    Console.WriteLine("No product found.");
            #endregion

            #region Q18
            //var result = Enumerable.Range(1, 10).Select(n => $"7 x {n} = {7 * n}");

            //foreach (var line in result)
            //    Console.WriteLine(line);
            #endregion

            #region Q19
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            //foreach (var number in result)
            //    Console.WriteLine(number);
            #endregion

            #region Q20
            //var result = Source.ProductList.Take(3).Select(p => p.ProductName).Concat(Source.CustomerList.Take(3).Select(c => c.CompanyName));

            //foreach (var name in result)
            //    Console.WriteLine(name);
            #endregion

            #region Q21
            //var result = Source.ProductList.Zip(Source.CustomerList,(p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion


        }
    }
}
