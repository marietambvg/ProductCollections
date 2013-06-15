// Write a program to read a large collection of products (name + price) and efficiently find the first 20 products 
// in the price range [a…b]. Test for 500 000 products and 10 000 price searches.
// Hint: you may use OrderedBag<T> and sub-ranges.

namespace ProductsCollection
{
    using System;
    using Wintellect.PowerCollections;
    using System.Linq;
    using System.Diagnostics;

    class ProductsCollection
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
                
            const int Products = 500000;
            const int ProductPrices = 10000;
            const int ResultProducts = 20;
            const int MinPrice = 500;
            const int MaxPrice = 1000;

            // create some product names
            string[] productNames = { "water", "coffee", "TV", "table", "chair", "byke", "ball", "dog-toy", "Nexsus", "cooker", "robot", "floewer" };
            int productTypes = productNames.Length;
            // create 10 000 prices
            int[] prices = new int[ProductPrices];
            for (int number = 0; number < prices.Length; number++)
            {
                prices[number] = random.Next(0, 20000);

            }

            OrderedBag<Product> productsCollection = new OrderedBag<Product>();

            // create 500 000 products
            int priceNumber = 0;
            for (int number = 0; number < Products; number++)
            {
                int price = prices[priceNumber];
                priceNumber++;
                if (priceNumber == ProductPrices)
                {
                    priceNumber = 0;
                }
                Product product = new Product(productNames[random.Next(0, productTypes)], price);
                productsCollection.Add(product);
            }

            Product first = productsCollection.FirstOrDefault(a => (a.Price > MinPrice && a.Price < MaxPrice));
            Product last = productsCollection.LastOrDefault(a => (a.Price > MinPrice && a.Price < MaxPrice));
            var productsInRange = productsCollection.Range(first, true, last, true);
            int productsToShow = ResultProducts;
            if (productsInRange.Count < ResultProducts)
            {
                productsToShow = productsInRange.Count;
            }
            for (int result = 0; result < productsToShow; result++)
            {
                Console.WriteLine("Product name: {0}; Product price: {1}", productsInRange[result].Name, productsInRange[result].Price);
            }
            stopWatch.Stop();
            Console.WriteLine("Adding and serching times: {0}",stopWatch.Elapsed);
            //Console.WriteLine(check);

        }
    }
}
