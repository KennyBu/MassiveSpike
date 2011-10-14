using System;

namespace MassiveSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Products();
            
            //grab all the products
            var products = table.All();
            
            foreach (var product in products)
            {
                Console.WriteLine("id: {0}      description: {1}      cost: {2}",
                    product.ProductId,product.Description,product.Cost);
            }

            Console.ReadLine();
        }
    }
}
