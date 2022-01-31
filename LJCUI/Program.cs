// See https://aka.ms/new-console-template for more information
global using Serilog;
using LJCUI;
using LakeJacksonCyclingBL;
using LakeJacksonCyclingDL;


Log.Logger = new LoggerConfiguration().WriteTo.File("./logs/user.txt").CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();

  
    Log.Information("System displayed main menu");
    Console.WriteLine("Welcome to Lake Jackson Cycling");
    Console.WriteLine("Can I get your name?");
    string name = Console.ReadLine(); 
    Console.WriteLine("OK "+ name +", How may I help you?");
    
while(repeat)
{
    Console.Clear(); 
    /*
        The bottom four lines of code show the welcome and how may i help you responses/question when you enter the store or website
    */
  
    menu.Display();

   
    
    /// <summary>
    /// Asks for a answer then uses that to get the user to the correct menu to make some operation happen
    /// </summary>
    /// <returns></returns>
    string ans = menu.UserInput();
    switch (ans)
    {
        case "AddCustomer":
            Log.Information("Displaying add customer to user");
            menu = new AddCustomer(new LakeJacksonBL(new Repository()));
            break;
        case "MainMenu":
            Log.Information("Displaying MainMenu to user");
            menu = new MainMenu();
            break;
        case "AddProduct":
            Log.Information("Displaying Add Product menu to user");
            menu = new AddProduct(new LakeJacksonBL(new Repository()));
            break;
        case "SearchCustomer":
            Log.Information("Employee accessed search function");
            menu = new SearchCustomer(new LakeJacksonBL(new Repository()));;
            break;

        case "Exit":
            Log.Information("Exiting Application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Log.Warning("A user made an incorrect option");
            Console.WriteLine("Please enter a valid option.");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.ReadLine();
            break;
    }

}


