// See https://aka.ms/new-console-template for more information

using Loops;

Product product1 = new Product();
Product product2 = new Product();
Product product3 = new Product();
Product product4 = new Product();

product1.Id = 1;
product1.ProductName = "Bilgisayar";
product1.Category = 1;
product1.UnitInStock = 15;
product1.UnitPrice = 1500;

product2.Id = 2;
product2.ProductName = "Telefon";
product2.Category = 1;
product2.UnitInStock = 25;
product2.UnitPrice = 500;

product3.Id = 3;
product3.ProductName = "USB Disk";
product3.Category = 2;
product3.UnitInStock = 1500;
product3.UnitPrice = 5;

product4.Id = 4;
product4.ProductName = "Mouse";
product4.Category = 3;
product4.UnitInStock = 399;
product4.UnitPrice = 10;

Product[] products = new Product[] { product1, product2, product3, product4 };

Console.WriteLine("--------------- FOREACH ---------------");

foreach (var item in products)
{
    Console.WriteLine("ID = " + item.Id);
    Console.WriteLine("Product Name = " + item.ProductName);
    Console.WriteLine("Category = " + item.Category);
    Console.WriteLine("Stock = " + item.UnitInStock);
    Console.WriteLine("Price = " + item.UnitPrice + " $");
    Console.WriteLine("------------------------------");
}

Console.WriteLine("-------------- FOR ----------------");

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("ID = " + products[i].Id);
    Console.WriteLine("Product Name = " + products[i].ProductName);
    Console.WriteLine("Category = " + products[i].Category);
    Console.WriteLine("Stock = " + products[i].UnitInStock);
    Console.WriteLine("Price = " + products[i].UnitPrice + " $");

    Console.WriteLine("------------------------------");

}

Console.WriteLine("-------------- WHILE ----------------");

int j = 0;
while (j < products.Length)
{
    j++;
    Console.WriteLine("ID = " + products[j].Id);
    Console.WriteLine("Product Name = " + products[j].ProductName);
    Console.WriteLine("Category = " + products[j].Category);
    Console.WriteLine("Stock = " + products[j].UnitInStock);
    Console.WriteLine("Price = " + products[j].UnitPrice + " $");


    Console.WriteLine("------------------------------");

}
