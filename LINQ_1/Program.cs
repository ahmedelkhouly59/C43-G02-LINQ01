using System.Text.RegularExpressions;
using System.Threading;
using LINQ_1.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 . Restriction Operators
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Q2 . Restriction Operators
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Q3 . Restriction Operators
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((p,i) => i > p.Length);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Q1  Element Operators
            //var result = ListGenerator.ProductsList.First();
            //Console.WriteLine(result);
            #endregion
            #region Q2  Element Operators
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion
            #region Q3  Element Operators
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Where(x => x > 5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion
            #region Q1  Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(x => x%2==1);
            //Console.WriteLine(result);
            #endregion
            #region Q2  Aggregate Operators
            //var result = ListGenerator.CustomersList.Select(c => new
            //{
            //    CustomerID = c.CustomerID,
            //    Customer_Order_Number = c.Orders.Length
            //});
            //foreach (var item in result) { 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3  Aggregate Operators
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category).Select(cat => (
            //    categoryName : cat.Key,
            //    productsCount : cat.Count())
            //);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #region Q4  Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum(x => x);
            //Console.WriteLine(result);
            #endregion
            #region Q5  Aggregate Operators
            //string filePath = "dictionary_english.txt"; 
            //string[] words = File.ReadAllLines(filePath);
            //var result = words.Sum(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q6  Aggregate Operators
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);
            //int shortestLength = words.Min(x => x.Length);
            //Console.WriteLine(shortestLength);
            #endregion
            #region Q7  Aggregate Operators
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);
            //int longestText = words.Max(x => x.Length);
            //var result = words.Where(y => y.Length == longestText).First();
            //Console.WriteLine(result);
            #endregion
            #region Q8  Aggregate Operators
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);
            //int longestText = words.Max(x => x.Length);
            //Console.WriteLine(longestText);
            #endregion
            #region Q9  Aggregate Operators
            //string filePath = "dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);
            //var averageText = words.Average(x => x.Length);
            //Console.WriteLine(averageText);
            #endregion
            #region Q1  Ordering Operators
            //var result = ListGenerator.ProductsList.OrderBy(x => x.ProductName);
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2  Ordering Operators
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q3  Ordering Operators
            //var result = ListGenerator.ProductsList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4  Ordering Operators
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(x => x.Length).ThenBy(x=>x);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion
            #region Q5  Ordering Operators
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q6  Ordering Operators
            //var result = ListGenerator.ProductsList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
            //foreach(var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q7  Ordering Operators
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion
            #region Q8  Ordering Operators
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(p => p[1] == 'i').Reverse();
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q1  Transformation Operators
            //var productNames = ListGenerator.ProductsList.Select(p => p.ProductName);
            //foreach (var product in productNames)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
            #region Q2  Transformation Operators
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });
            //foreach (var word in result) { 
            //    Console.WriteLine(word);
            //}

            #endregion
            #region Q3  Transformation Operators
            //var result = ListGenerator.ProductsList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Q4  Transformation Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((x, i) => new { i,x, Result = x==i });
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion
            #region Q5  Transformation Operators
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);
            //foreach (var pair in pairs) {
            //    Console.WriteLine($"{pair.a}, {pair.b}");
            //}

            #endregion
            #region Q6  Transformation Operators
            //var result = ListGenerator.CustomersList.Select(c => new
            //                                            {
            //                                                TotalOrderAmount = c.Orders.Sum(o => o.Total)
            //                                            });
            //foreach(var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q7  Transformation Operators
            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion



        }
    }
}
