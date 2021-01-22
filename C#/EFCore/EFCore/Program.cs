using System;
using EFCore.Models;
using System.Linq;
using System.Collections.Generic;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //insertProduct();
            readProduct();
            //updateProduct();
            //deleteProduct();
            readProduct();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void insertProduct()
        {
            using (var db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Good Drive";
                db.Add(product);

                product = new Product();
                product.Name = "Memory Card";
                db.Add(product);

                db.SaveChanges();
                Console.WriteLine("Inserted 2 new products");
            }
            return;
        }

        static void readProduct()
        {
            using (var db = new EFContext())
            {
                List<Product> products = db.Products.ToList();
                foreach (Product p in products)
                {
                    Console.WriteLine("{0} {1}", p.Id, p.Name);
                }
            }
            return;
        }

        static void updateProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(1);
                product.Name = "Super Good Drive";
                db.SaveChanges();
            }
            return;
        }

        static void deleteProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(1);
                db.Products.Remove(product);
                db.SaveChanges();

                Console.WriteLine("Product {0} has been removed", product.Name);
            }
        }
    }
}
