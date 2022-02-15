namespace LJCUI
{
    public class ViewHistory : IMenu
    {
        public void Display()
        {
            Log.Information("User is viewing main menu of store");
            Console.WriteLine("+++++++ Lake Jackson Cycling +++++++");
            Console.WriteLine("++ [1] - View Customer Order History ++");
            Console.WriteLine("++ [2] - View Store Order History    ++");
            Console.WriteLine("+++++++ Lake Jackson Cycling +++++++");
            Console.WriteLine("[0] - Exit");
        }

        public string UserInput()
        {
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    Log.Information("User went to the customer order history");
                    return "CustomerHistory";
                case "2":
                Log.Information("User went to the store order history");
                    return "StoreHsitory";
                case "0":
                Log.Information("User went back to the main menu");
                    return "MainMenu";
                default:
                Log.Warning("A user made an incorrect option");
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                break;
            }
            return "VeiwHistory";
        }
    }

}