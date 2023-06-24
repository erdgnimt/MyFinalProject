using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //Console.WriteLine(productManager.GetById(2).Data);


            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine($"{item.ProductId}--{item.ProductName}--{item.CategoryName}--{item.UnitsInStock}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            //foreach (var item in productManager.GetAllByCategoryId(6))
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //foreach (var item in productManager.GetAllByUnitPrice(100,200))
            //{
            //    Console.WriteLine(item.ProductName);

            //}


            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //var resultCategory = categoryManager.GetAll();
            //if (resultCategory.Success)
            //{
            //    foreach (var item in resultCategory.Data)
            //    {
            //        Console.WriteLine(item.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(resultCategory.Message); 
            //}

            //var result = categoryManager.GetById(2);
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Data.CategoryName); 
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //Console.WriteLine();
        }
    }
}
