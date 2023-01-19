

// Make a shopping list application which uses collections to store your items. (You will be using two collections, one for the menu and one for the shopping list.)
using System.Diagnostics.Metrics;
using System.Net;

Console.WriteLine("Welcome to Tee's Market!");
Console.WriteLine();

bool NextOrder = true;
List<string> Cart = new List<string>();


while (NextOrder)
{

    Dictionary<string, decimal> Menu = new Dictionary<string, decimal>();
    Menu.Add("milk", 2.00m);
    Menu.Add("egg", 4.00m);
    Menu.Add("bread", 3.00m);
    Menu.Add("chicken", 7.00m);
    Menu.Add("beer", 3.00m);
    Menu.Add("fish", 6.00m);

    Console.WriteLine("Item\tPrice");
    Console.WriteLine("=====\t=====");

    foreach (KeyValuePair<string, decimal> item in Menu)
    {
       
        Console.WriteLine($"{item.Key}\t${item.Value}");
    }
    Console.WriteLine();
    
    bool ToContinue = true;
    string input= " ";


    while (ToContinue == true)
    {
        Console.Write("what item would you like to order? \n");
        input = Console.ReadLine().Trim().ToLower();


        Cart.Add(input);
        string receipt = " ";


        if (Menu.ContainsKey(input))
        {
            break;

        }
        else
        {
            ToContinue = true;
            Console.WriteLine("Does not exist");

            Console.WriteLine("Please look at the menu and enter valid item");
        }
    }
        Console.WriteLine($"Adding {input} to cart at ${Menu[input]}");

        Console.WriteLine("Would you like to add another item? (y/n)");
        string nextOrder = Console.ReadLine().Trim().ToLower();
        decimal total = 0;

        if (nextOrder == "y")
        {
            NextOrder = true;
        }
        else if (nextOrder == "n")
        {
            NextOrder = false;
            Console.WriteLine("Thanks for your order");
            Console.WriteLine("Here is what you order!");
            Console.WriteLine();
            foreach (string c in Cart)
            {
                Console.WriteLine($"{c}\t${Menu[c]}\n");

                List<decimal> list = new List<decimal>()
            {
                Menu[c],
            };
                foreach (decimal d in list)
                {
                    total += d;

                }
            }

            Console.WriteLine($" Average price per item in order was {Math.Round(total / Cart.Count, 2)}");

        }
        else
        {
            NextOrder = false;
        }
       
}























Console.ReadKey();






















