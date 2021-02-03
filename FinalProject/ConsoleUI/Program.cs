using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fetch Product With ID (Min = 1, Max = 8) : ");
            int enteredId = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(enteredId))
            {
                Console.WriteLine("Product Name : "+product.ProductName);
            }
        }
    }
}
