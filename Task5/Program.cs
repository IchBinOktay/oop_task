using System;
namespace Task5
{


    public static class Program
    {
        public static void Main()
        {
            Electronic machine = new Electronic("iphone",300,"silver");
            Clothes clothes = new Clothes("nike", 50, "l");
            Clothes clothes2 = new Clothes("balenciaga", 100, "S");
            Order order = new Order();
            order.AddProduct(machine);
            order.AddProduct(clothes);
            order.RemoveProduct(clothes);
            order.GetDetails();
            Console.WriteLine(order.GetTotalAmount());


        }
    }
}