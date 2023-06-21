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
            ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
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
            //foreach (var nameitem in categoryManager.GetAll())
            //{
            //    Console.WriteLine(nameitem.CategoryName);
            //}
        }
    }
}
