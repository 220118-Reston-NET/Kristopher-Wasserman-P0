// See https://aka.ms/new-console-template for more information
global using Serilog;
using LJCUI;
using LakeJacksonCyclingBL;
using LakeJacksonCyclingDL;


Log.Logger = new LoggerConfiguration().WriteTo.File("./logs/user.txt").CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();


while(repeat)
{
    Console.Clear();
    menu.Display();

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
        case "Exit":
            Log.Information("Exiting Application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
        Log.Information("User did not make a vaild option");
        break;
    }

}


