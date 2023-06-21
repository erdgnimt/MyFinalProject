using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("------------------------------------------------------");

            CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
            foreach (var nameitem in categoryManager.GetAll())
            {
                Console.WriteLine(nameitem.CategoryName);
            }
        }
    }
}
