// This is challenge work for the "C# Players Guide"
// Level 10 the Buying Inventory Challenge
// Build a simple menu system to display prices of selected items
// The challenge requires the use of either switch statments or switch expressions
// My focus for this exercise is to use switch statments

//Simple store menu system, user should select a number 1 - 7.  
Console.WriteLine ("Welcome to Tortuga Outfitters");
Console.WriteLine ("________________________________________________");
Console.WriteLine ("The following items are available for purchase: ");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("________________________________________________");
Console.WriteLine("What number do you want to see the price of? ");

//Grab the users input string and convert to an int
int userChoice =Convert.ToInt32(Console.ReadLine());

//Switch statment to generate correct price
switch (userChoice)
{
    case 1:
        Console.WriteLine("A rope is 10 gold");
        break;
    case 2:
        Console.WriteLine("A tourch is 15 gold");
        break;
    case 3:
        Console.WriteLine("Climbing equipment is 25 gold");
        break;
    case 4:
        Console.WriteLine("A liter of clean water is 1 gold");
        break;
    case 5:
        Console.WriteLine("A machete is 20 gold");
        break;
    case 6:
        Console.WriteLine("A canoe is 200 gold");
        break;
    case 7:
        Console.WriteLine("A pack of food supplies is 1 gold");
        break;
   default:
        Console.WriteLine("That is not one of the items in stock");
        break;
}

//Close out the program with a key press
Console.WriteLine("Press any key to end program");
Console.ReadKey();



