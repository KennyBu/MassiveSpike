using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassiveSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Products();
            
            //grab all the products
            var products = table.All();
            
            //just grab from category 4. This uses named parameters
            //var productsFour = table.All(columns: "ProductName as Name", where: "WHERE categoryID=@0", args: 4);

            foreach (var product in products)
            {
                Console.WriteLine("id: {0}      description: {1}      cost: {2}",product.ProductId,product.Description,product.Cost);
            }

            Console.ReadLine();
        }
    }
}
