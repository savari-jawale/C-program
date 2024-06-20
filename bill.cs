using System;

namespace BillingSystem
{
    class Program
    {
        static Item[] items = new Item[100]; // Array to store items, assuming a maximum of 100 items
        static int itemCount = 0; // Variable to keep track of number of items added
        const string gstno="GST1234567";
        
        static void Main(string[] args)
        {
            string choice;

            do
            {
                DisplayMenu(); // Display menu options
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItems();
                        break;
                    case "2":
                        ViewBill();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }

            } while (choice != "3");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Billing System");
            Console.WriteLine("1. Add Items");
            Console.WriteLine("2. View Bill");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
        }

        static void AddItems()
        {
            Console.Write("How many items would you like to add? ");
            int numItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.Write("Enter item name: ");
                string name = Console.ReadLine();

                decimal price;
                do
                {
                    Console.Write("Enter item price: ");
                } while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0);

                int quantity;
                do
                {
                    Console.Write("Enter item quantity: ");
                } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0);

                items[itemCount] = new Item { Name = name, Price = price, Quantity = quantity };
                itemCount++;

                Console.WriteLine("Item added successfully.\n");
            }
        }

        static void ViewBill()
        {
            decimal total = 0;
            const decimal gstRate = 0.18m; // 18% GST

            Console.WriteLine("\nHOTEL SANJIVANI");
            DateTime curr= DateTime.Now;
            string date=curr.ToLongDateString();
            string time=curr.ToShortTimeString();
            Console.WriteLine(String.Format("{0,-20},{1,28}","Date: "+date,"Time: "+time));
            Console.WriteLine(String.Format("GST NO: {0}",gstno));
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("{0,-20}{1,10} {2,10} {3,10}", "Sr.No", "Item Name", "Quantity", "Price");
            Console.WriteLine("---------------------------------------------------------------------");

            for (int i = 0; i < itemCount; i++)
            {
                Item item = items[i];
                decimal itemTotal = item.Price * item.Quantity;
                //int srno=0;

                Console.WriteLine(String.Format("{0,-20} {1,10} {2,10:N2}",item.Name, item.Quantity, itemTotal));
                total += itemTotal;
            }

            decimal gst = total * gstRate;
            decimal grandTotal = total + gst;

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("{0,-20} {1,10} {2,10:N2}", "Total", "", total);
            Console.WriteLine("{0,-20} {1,10} {2,10:N2}", "GST (18%)", "", gst);
            Console.WriteLine("{0,-20} {1,10} {2,10:N2}", "Grand Total", "", grandTotal);
            Console.WriteLine("------------------------------------------------------------------\n");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}