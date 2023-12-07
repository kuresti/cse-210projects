using System;

class Program
{
    static void Main(string[] args)
    {
        //Order one created
         Address customer1Address = new Address("145 N 3685 W", "South Jordan", "Utah", "USA");

         Customer customer1 = new Customer("Sara Jane", customer1Address);
         
         Order ord1 = new Order(customer1);

        //Adding Products to ord1
         Product ord1prod1 = new Product("Pair of Gloves", 28098, 10.00m, 4);
                 ord1prod1.CalculatePrice();
                 ord1.AddProduct(ord1prod1);
               
         Product ord1prod2 = new Product("Ski Hat", 34761, 6.00m, 4);
                ord1prod2.CalculatePrice();
                ord1.AddProduct(ord1prod2);
            
         Product ord1prod3 = new Product("Ski Jacket", 56781, 78.00m, 4);
                ord1prod3.CalculatePrice();
                ord1.AddProduct(ord1prod3);

         Product ord1prod4 = new Product("Scarf",98321, 15.00m, 2);
                ord1prod4.CalculatePrice();
                ord1.AddProduct(ord1prod4);

        //Shipping label for ord1
        ord1.GetShippingLabel();

        //Packing label for ord1
        ord1.GetPackingLabel();

        //Total Price for ord1
        ord1.CalculateTotalCost();

        //Order Two Created
         Address customer2Address = new Address("157 W 9038 S", "Barcelona", "Catalonia", "Spain");

         Customer customer2 = new Customer("Juan Perez Gonzalez Garcia", customer2Address);
         
         Order ord2 = new Order(customer2);

        //Adding Products to ord2
         Product ord2prod1 = new Product("Ear Buds", 456712, 75.00m, 1);
                 ord2prod1.CalculatePrice();
                 ord2.AddProduct(ord2prod1);
               
         Product ord2prod2 = new Product("Paella Pan", 000365, 96.00m, 2);
                ord2prod2.CalculatePrice();
                ord2.AddProduct(ord2prod2);
            
         Product ord2prod3 = new Product("Olive Oil", 467813, 18.00m, 3);
                ord2prod3.CalculatePrice();
                ord2.AddProduct(ord2prod3);

         Product ord2prod4 = new Product("Blue Shirt", 783928, 45.00m, 2);
                ord2prod4.CalculatePrice();
                ord2.AddProduct(ord2prod4);

        //Create line between orders
        Console.WriteLine("");
        //Shipping label for ord2
        ord2.GetShippingLabel();

        //Packing label for ord2
        ord2.GetPackingLabel();

        //Total Price for ord2
        ord2.CalculateTotalCost();

        //Order Three Created
         Address customer3Address = new Address("534 W 6789 S", "Boise", "Idaho", "USA");

         Customer customer3 = new Customer("Kalare  Urrestilla", customer3Address);
         
         Order ord3 = new Order(customer3);

        //Adding Products to ord3
         Product ord3prod1 = new Product("Ear Buds", 456712, 75.00m, 1);
                 ord3prod1.CalculatePrice();
                 ord3.AddProduct(ord3prod1);
               
         Product ord3prod2 = new Product("Paella Pan", 000365, 96.00m, 2);
                ord3prod2.CalculatePrice();
                ord3.AddProduct(ord3prod2);
            
         Product ord3prod3 = new Product("Olive Oil", 467813, 18.00m, 3);
                ord3prod3.CalculatePrice();
                ord3.AddProduct(ord3prod3);

         Product ord3prod4 = new Product("Blue Shirt", 783928, 45.00m, 2);
                ord3prod4.CalculatePrice();
                ord3.AddProduct(ord3prod4);

        //Create line between orders
        Console.WriteLine("");
        //Shipping label for ord3
        ord3.GetShippingLabel();

        //Packing label for ord3
        ord3.GetPackingLabel();

        //Total Price for ord3
        ord3.CalculateTotalCost();

        
        
    }

    
}