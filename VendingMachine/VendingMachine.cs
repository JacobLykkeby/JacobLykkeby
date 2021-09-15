using System;
using System.Collections.Generic;

namespace VendingMachine
{

    class VendingMachine
    {
        public void ItemDisplay()
        {
          
            Items item = new Items();
            new Product("Booster Energy", 21, 19);
            new Product("Sour Creme Onion", 12, 18);
            new Product("Power bar", 8, 10);
            new Product("Snickers bar", 15, 8);
            new Product("Coca Cola", 10, 14);
            new Product("Instant Ramen", 8, 6);


           
            while (true)
            {
                Console.WriteLine("Please Select Wanted Item");
                Console.WriteLine("1" { item.Booster_Energy.Name});
                Console.WriteLine("2" { item.Sour_Creme_Onion.Name});
                Console.WriteLine("3" { item.Power_Bar.Name});
                Console.WriteLine("4" { item.Snickers_Bar.Name});
                Console.WriteLine("5" { item.Coca_Cola.Name});
                Console.WriteLine("6" { item.Instant_Ramen.Name });

                Console.WriteLine("Price :" { item.Booster_Energy.Price});
                Console.WriteLine("Price :" { item.Sour_Creme_Onion.Price});
                Console.WriteLine("Price :" { item.Power_Bar.Price});
                Console.WriteLine("Price :" { item.Snickers_Bar.Price});
                Console.WriteLine("Price :" { item.Coca_Cola.Price});
                Console.WriteLine("Price :" { item.Instant_Ramen.Price});
                
                int userItem = Int32.Parse(Console.ReadLine());

               
            }
        }

       
    }


}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product()
    {
        int price;
        string name;

        Name = name;
        Price = price;
    }

    class Display
    {

    }

    class Items
    {
        public Product Booster_Energy { get; set; }
        public Product Sour_Creme_Onion { get; set; }
        public Product Power_Bar { get; set; }
        public Product Snickers_Bar { get; set; }
        public Product Coca_Cola { get; set; }
        public Product Instant_Ramen { get; set; }

        public Items(Product booster_energy, Product sour_creme_onion, Product power_bar, Product snickers_bar, Product coca_cola, Product instant_ramen)
            {
            Booster_Energy = booster_energy;
            Sour_Creme_Onion = sour_creme_onion;
            Power_Bar = power_bar;
            Snickers_Bar = snickers_bar;
            Coca_Cola = coca_cola;
            Instant_Ramen = instant_ramen;  
            }
        public void ItemList()
        { 
            List<Product> Products = new List<Product>();
        }
    }

    
    class ItemDispenser
    {
        List<ItemDispenser> Dispenser = new List<ItemDispenser>();

        public Dispenser();
  
        public void DispenserList()
        {
            string DispensedItem;
            dispenser.Add(DispensedItem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           VendingMachine Initiate = new VendingMachine();
        }
    }
}


   

